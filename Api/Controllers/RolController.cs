using Api.Controllers;
using Api.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Dominio.Interfaces.Pager;
using Microsoft.AspNetCore.Mvc;

[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class RoleController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public RoleController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<RolDto>> Get(){
       var records = await _UnitOfWork.Roles.FindFirst(null);
       return _Mapper.Map<List<RolDto>>(records);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<RolXUserDtos>>> Get11([FromQuery]Params conf){
        var param = new Param(conf);
        IEnumerable<Role>? records = await _UnitOfWork.Roles.GetAllAsync(null,param);
        var recordDtos = _Mapper.Map<List<RolXUserDtos>>(records);
        IPager<RolXUserDtos> pager = new Pager<RolXUserDtos>(recordDtos, records?.Count(), param);
        return Ok(pager);
    }
/* 
 var param = new Param(conf);
       var records = await _UnitOfWork.Hamburguesas.GetAllAsync(null,param);
       Console.WriteLine(records.Count());
       var recordDtos = _Mapper.Map<List<HamburguesaSimpleDto>>(records);
       IPager<HamburguesaSimpleDto> pager = new Pager<HamburguesaSimpleDto>(recordDtos,records.Count(),param) ;
        
        return Ok(pager);
 */
    [HttpGet("{id}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolXUserDtos>> Get(int id){
       var record = await _UnitOfWork.Roles.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<RolXUserDtos>(record);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolDto>> Post(RolDto recordDto){
       var record = _Mapper.Map<Role>(recordDto);
       _UnitOfWork.Roles.Add(record);
       await _UnitOfWork.SaveChanges();
       if (record == null){
           return BadRequest();
       }
       return CreatedAtAction(nameof(Post),new {id= record.Id, recordDto});
    }

    [HttpPut]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolDtoWithId>> Put([FromBody]RolDtoWithId? recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Role>(recordDto);
       _UnitOfWork.Roles.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Roles.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Roles.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}