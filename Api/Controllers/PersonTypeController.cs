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
public class TypePersonController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public TypePersonController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<PersonTypeDto>> Get(){
       var records = await _UnitOfWork.PersonTypes.GetAllAsync();
       return _Mapper.Map<List<PersonTypeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PersonTypeWithIdDto>> Get(int id){
       var record = await _UnitOfWork.PersonTypes.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<PersonTypeWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<PersonTypeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.PersonTypes.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<PersonTypeDto>>(records);
       IPager<PersonTypeDto> pager = new Pager<PersonTypeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PersonTypeDto>> Post(PersonTypeDto recordDto){
       var record = _Mapper.Map<PersonType>(recordDto);
       _UnitOfWork.PersonTypes.Add(record);
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
    public async Task<ActionResult<PersonTypeDto>> Put(int id, [FromBody]PersonTypeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<PersonType>(recordDto);
       record.Id = id;
       _UnitOfWork.PersonTypes.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.PersonTypes.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.PersonTypes.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}