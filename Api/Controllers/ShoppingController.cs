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
[ApiVersion("1.1")]
[ApiVersion("1.0")]
public class ShoppingController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public ShoppingController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<ShoppingDto>> Get(){
       var records = await _UnitOfWork.Shoppings.GetAllAsync();
       return _Mapper.Map<List<ShoppingDto>>(records);
    }

    [HttpGet("SupplierNoShopping/{year}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<object>> NoSalesSupplier(int year){

       return await _UnitOfWork.Shoppings.NoSalesSupplier(year);

    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ShoppingWithIdDto>> Get(int id){
       var record = await _UnitOfWork.Shoppings.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<ShoppingWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ShoppingDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Shoppings.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<ShoppingDto>>(records);
       IPager<ShoppingDto> pager = new Pager<ShoppingDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ShoppingDto>> Post(ShoppingDto recordDto){
       var record = _Mapper.Map<Shopping>(recordDto);
       _UnitOfWork.Shoppings.Add(record);
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
    public async Task<ActionResult<ShoppingDto>> Put(int id, [FromBody]ShoppingDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Shopping>(recordDto);
       record.Id = id;
       _UnitOfWork.Shoppings.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Shoppings.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Shoppings.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}
