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
public class DepartmentController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public DepartmentController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<DepartmentDto>> Get(){
       var records = await _UnitOfWork.Departments.GetAllAsync();
       return _Mapper.Map<List<DepartmentDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DepartmentWithIdDto>> Get(int id){
       var record = await _UnitOfWork.Departments.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<DepartmentWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<DepartmentDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Departments.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<DepartmentDto>>(records);
       IPager<DepartmentDto> pager = new Pager<DepartmentDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DepartmentDto>> Post(DepartmentDto recordDto){
       var record = _Mapper.Map<Department>(recordDto);
       _UnitOfWork.Departments.Add(record);
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
    public async Task<ActionResult<DepartmentDto>> Put(int id, [FromBody]DepartmentDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Department>(recordDto);
       record.Id = id;
       _UnitOfWork.Departments.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Departments.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Departments.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}