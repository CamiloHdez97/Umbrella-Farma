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
public class CityController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public CityController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<CityDto>> Get(){
       var records = await _UnitOfWork.Cities.GetAllAsync();
       return _Mapper.Map<List<CityDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CityWithIdDto>> Get(int id){
       var record = await _UnitOfWork.Cities.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<CityWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<CityDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Cities.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<CityDto>>(records);
       IPager<CityDto> pager = new Pager<CityDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CityDto>> Post(CityDto recordDto){
       var record = _Mapper.Map<City>(recordDto);
       _UnitOfWork.Cities.Add(record);
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
    public async Task<ActionResult<CityDto>> Put(int id, [FromBody]CityDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<City>(recordDto);
       record.Id = id;
       _UnitOfWork.Cities.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Cities.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Cities.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}