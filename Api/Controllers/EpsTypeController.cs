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
public class EpsTypeController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public EpsTypeController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<EpsTypeDto>> Get(){
       var records = await _UnitOfWork.EpsTypes.GetAllAsync();
       return _Mapper.Map<List<EpsTypeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EpsTypeWithIdDto>> Get(int id){
       var record = await _UnitOfWork.EpsTypes.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<EpsTypeWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<EpsTypeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.EpsTypes.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<EpsTypeDto>>(records);
       IPager<EpsTypeDto> pager = new Pager<EpsTypeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EpsTypeDto>> Post(EpsTypeDto recordDto){
       var record = _Mapper.Map<EpsType>(recordDto);
       _UnitOfWork.EpsTypes.Add(record);
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
    public async Task<ActionResult<EpsTypeDto>> Put(int id, [FromBody]EpsTypeDto? recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<EpsType>(recordDto);
       record.Id = id;
       _UnitOfWork.EpsTypes.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.EpsTypes.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.EpsTypes.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}