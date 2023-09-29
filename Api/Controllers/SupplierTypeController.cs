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
[ApiVersion("1.1")]
[ApiVersion("1.0")]
public class SupplierTypeController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public SupplierTypeController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<SupplierTypeDto>> Get(){
        var records = await _UnitOfWork.SupplierTypes.GetAllAsync();
        return _Mapper.Map<List<SupplierTypeDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SupplierTypeWithIdDto>> Get(int id){
       var record = await _UnitOfWork.SupplierTypes.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<SupplierTypeWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<SupplierTypeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.SupplierTypes.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<SupplierTypeDto>>(records);
       IPager<SupplierTypeDto> pager = new Pager<SupplierTypeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SupplierTypeDto>> Post(SupplierTypeDto recordDto){
       var record = _Mapper.Map<SupplierType>(recordDto);
       _UnitOfWork.SupplierTypes.Add(record);
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
    public async Task<ActionResult<SupplierTypeDto>> Put(int id, [FromBody]SupplierTypeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<SupplierType>(recordDto);
       record.Id = id;
       _UnitOfWork.SupplierTypes.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.SupplierTypes.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.SupplierTypes.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}