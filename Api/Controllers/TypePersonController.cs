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
    public async Task<IEnumerable<TypePersonDto>> Get(){
       var records = await _UnitOfWork.TypesPerson.GetAllAsync();
       return _Mapper.Map<List<TypePersonDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypePersonWithIdDto>> Get(int id){
       var record = await _UnitOfWork.TypesPerson.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<TypePersonWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<TypePersonDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.TypesPerson.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<TypePersonDto>>(records);
       IPager<TypePersonDto> pager = new Pager<TypePersonDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypePersonDto>> Post(TypePersonDto recordDto){
       var record = _Mapper.Map<TypePerson>(recordDto);
       _UnitOfWork.TypesPerson.Add(record);
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
    public async Task<ActionResult<TypePersonDto>> Put(int id, [FromBody]TypePersonDto? recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<TypePerson>(recordDto);
       record.Id = id;
       _UnitOfWork.TypesPerson.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.TypesPerson.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.TypesPerson.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}