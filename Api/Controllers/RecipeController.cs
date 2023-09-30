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
public class RecipeController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public RecipeController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<RecipeDto>> Get(){
       var records = await _UnitOfWork.Recipes.GetAllAsync();
       return _Mapper.Map<List<RecipeDto>>(records);
    }

    [HttpGet("year/{year}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<RecipeDto>> Get(int year){
       var records = await _UnitOfWork.Recipes.GetDateJunary2023(year);
       return _Mapper.Map<List<RecipeDto>>(records);
    }

    

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RecipeWithIdDto>> Get(string id){
       var record = await _UnitOfWork.Recipes.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<RecipeWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<RecipeDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Recipes.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<RecipeDto>>(records);
       IPager<RecipeDto> pager = new Pager<RecipeDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RecipeDto>> Post(RecipeDto recordDto){
       var record = _Mapper.Map<Recipe>(recordDto);
       _UnitOfWork.Recipes.Add(record);
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
    public async Task<ActionResult<RecipeDto>> Put(string id, [FromBody]RecipeDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Recipe>(recordDto);
       record.Id = id;
       _UnitOfWork.Recipes.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }


    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(string id){
       var record = await _UnitOfWork.Recipes.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Recipes.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}