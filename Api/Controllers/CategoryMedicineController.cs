using Api.Controllers;
using Api.Dtos;
using AutoMapper;
using Domain.Entities;
using API.Helpers;
using Dominio.Interfaces.Pager;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ApiIncidencias.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class CategoryMedicineController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public CategoryMedicineController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<MedicineCategoryDto>> Get(){
       var records = await _UnitOfWork.MedicineCategories.GetAllAsync();
       return _Mapper.Map<List<MedicineCategoryDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicineCategoryWithIdDto>> Get(int id){
       var record = await _UnitOfWork.MedicineCategories.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<MedicineCategoryWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<MedicineCategoryDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.MedicineCategories.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<MedicineCategoryDto>>(records);
       IPager<MedicineCategoryDto> pager = new Pager<MedicineCategoryDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicineCategoryDto>> Post(MedicineCategoryDto recordDto){
       var record = _Mapper.Map<MedicineCategory>(recordDto);
       _UnitOfWork.MedicineCategories.Add(record);
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
    public async Task<ActionResult<MedicineCategoryDto>> Put(int id, [FromBody]MedicineCategoryDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<MedicineCategory>(recordDto);
       record.Id = id;
       _UnitOfWork.MedicineCategories.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.MedicineCategories.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.MedicineCategories.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}