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
public class SaleController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public SaleController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }

    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<SaleDto>> Get(){
       var records = await _UnitOfWork.Sales.GetAllAsync();
       return _Mapper.Map<List<SaleDto>>(records);
    }

    
    [HttpGet("VipApi")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<Object> GetVipApi(){

        return await _UnitOfWork.Sales.VipBuyer();
       //return _Mapper.Map<List<SaleDto>>(records);
    }

    [HttpGet("AllSaleCustomer/{year}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<Object>> AllSaleCustomer(int year){
        return await _UnitOfWork.Sales.AllSaleCustomer(year);
       //return _Mapper.Map<List<SaleDto>>(records);
    }

    
    [HttpGet("SaleMedicine/{medidineInput}/{year}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<Object> GetSaleParacetamol(string medidineInput,int year){

        return await _UnitOfWork.Sales.GetSaleMedicineYear(medidineInput,year);
       //return _Mapper.Map<List<SaleDto>>(records);
    }

    [HttpGet("PersonNoPurchase/{year}")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<object>> PersonNoPurchasedYear(int year){

        return await _UnitOfWork.Sales.PersonNoPurchasedYear(year);
       //return _Mapper.Map<List<SaleDto>>(records);
    }


    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SaleWithIdDto>> Get(int id){
       var record = await _UnitOfWork.Sales.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<SaleWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<SaleDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.Sales.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<SaleDto>>(records);
       IPager<SaleDto> pager = new Pager<SaleDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SaleDto>> Post(SaleDto recordDto){
       var record = _Mapper.Map<Sale>(recordDto);
       _UnitOfWork.Sales.Add(record);
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
    public async Task<ActionResult<SaleDto>> Put(int id, [FromBody]SaleDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<Sale>(recordDto);
       record.Id = id;
       _UnitOfWork.Sales.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.Sales.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.Sales.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}