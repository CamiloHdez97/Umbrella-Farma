using Api.Controllers;
using Api.Dtos;
using AutoMapper;
using Domain.Entities;
using API.Helpers;
using Dominio.Interfaces.Pager;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class PresentationMedicineController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public PresentationMedicineController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<MedicinePresentationDto>> Get(){
       var records = await _UnitOfWork.MedicinePresentations.GetAllAsync();
       return _Mapper.Map<List<MedicinePresentationDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicinePresentationWithIdDto>> Get(int id){
       var record = await _UnitOfWork.MedicinePresentations.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<MedicinePresentationWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<MedicinePresentationDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.MedicinePresentations.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<MedicinePresentationDto>>(records);
       IPager<MedicinePresentationDto> pager = new Pager<MedicinePresentationDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicinePresentationDto>> Post(MedicinePresentationDto recordDto){
       var record = _Mapper.Map<MedicinePresentation>(recordDto);
       _UnitOfWork.MedicinePresentations.Add(record);
       await _UnitOfWork.SaveChanges();
       if (record == null){
           return BadRequest();
       }
       return CreatedAtAction(nameof(Post),new {id= record.Id, recordDto});
    }

    [HttpPut("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicinePresentationDto>> Put(int id, [FromBody]MedicinePresentationDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<MedicinePresentation>(recordDto);
       record.Id = id;
       _UnitOfWork.MedicinePresentations.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.MedicinePresentations.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.MedicinePresentations.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}