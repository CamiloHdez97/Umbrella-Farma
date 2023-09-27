using System;
using Api.Controllers;
using Api.Dtos;
using AutoMapper;
using Domain.Entities;
using API.Helpers;
using Dominio.Interfaces.Pager;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Domain.Models;
using Microsoft.AspNetCore.Builder.Extensions;

namespace ApiIncidencias.Controllers;
[ApiVersion("1.0")]
public class MedicineInfoController : BaseApiController{
    private readonly IUnitOfWork _UnitOfWork;
    private readonly IMapper _Mapper;

    public MedicineInfoController (IUnitOfWork unitOfWork,IMapper mapper){
        _UnitOfWork = unitOfWork;
        _Mapper = mapper;
    }
    
    //*1 Obtener todos los medicamentos con menos de 50 unidades en stock
    [HttpGet("MinStock")]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<object>> MinStock(int minStock){
       return await _UnitOfWork.MedicineInfos.MedicineWithMinStock(minStock);                                                       
    }
    //*Fin de la consulta 1

   //*3 Medicamentos comprados al ‘Proveedor A’
   //*11 Número de medicamentos por proveedor.
   [HttpGet("PurchasedBySupplier/{supplierName}")]
   //[Authorize]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<IEnumerable<MedicineDetailTotalModel>> PurchasedBySupplier(string supplierName){
      return await _UnitOfWork.MedicineInfos.PurchasedBySupplier(supplierName);
   }
   //* fin de la consulta 
   
   //*5 Total de ventas del medicamento ‘Paracetamol’
   [HttpGet("TotalDrugSales/{MedicineName}")]
   //[Authorize]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName){
      return await _UnitOfWork.MedicineInfos.TotalDrugSales(MedicineName);
   }
   //* fin de la consulta

   //*7 Total de medicamentos vendidos por cada proveedor.
   [HttpGet("TotalMedicationsSoldByProvider")]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<IEnumerable<object>> TotalMedicationsSoldByProvider(){
      return await _UnitOfWork.MedicineInfos.TotalMedicationsSoldByProvider();
   }
   //* fin de la consulta

   //*8 Cantidad total de dinero recaudado por las ventas de medicamentos.
   [HttpGet("MoneyRaisedFromSales/{medicineName?}")]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<float> MoneyRaisedFromSales(string medicineName = null){
      return await _UnitOfWork.MedicineInfos.MoneyRaisedFromSales(medicineName);
   }
   //* fin de la consulta

   //*9 Medicamentos que no han sido vendidos
   [HttpGet("MedicationsThatWereNotSold")]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<IEnumerable<MedicineDetailTotalModel>> MedicationsThatWereNotSold(){
      return await _UnitOfWork.MedicineInfos.MedicationsThatWereNotSold();
   }
   //* fin de la consulta

   //*10 Obtener el medicamento más caro
   [HttpGet("GetTheMostExpensiveMedicine")]
   [MapToApiVersion("1.0")]
   [ProducesResponseType(StatusCodes.Status200OK)]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   public async Task<MedicineInfoSimpleDto> GetTheMostExpensiveMedicine(){
      var medicines = await _UnitOfWork.MedicineInfos.GetAllAsync();
      float maxPrice = medicines.Max(x => x.Price - (x.Price * (x.Discount / 100)));
      var MostExpensiveMedicine = medicines.First(x => x.Price - (x.Price * (x.Discount / 100)) == maxPrice);
      return _Mapper.Map<MedicineInfoSimpleDto>(MostExpensiveMedicine);

   }
   //* fin de la consulta
    [HttpGet]
    //[Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IEnumerable<MedicineInfoDto>> Get(){
       var records = await _UnitOfWork.MedicineInfos.GetAllAsync();
       return _Mapper.Map<List<MedicineInfoDto>>(records);
    }

    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicineInfoWithIdDto>> Get(int id){
       var record = await _UnitOfWork.MedicineInfos.GetByIdAsync(id);
       if (record == null){
           return NotFound();
       }
       return _Mapper.Map<MedicineInfoWithIdDto>(record);
    }

    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<MedicineInfoDto>>> Get11([FromQuery] Params conf){
       var param = new Param(conf);
       var records = await _UnitOfWork.MedicineInfos.GetAllAsync(param);
       var recordDtos = _Mapper.Map<List<MedicineInfoDto>>(records);
       IPager<MedicineInfoDto> pager = new Pager<MedicineInfoDto>(recordDtos,records?.Count(),param) ;
       return Ok(pager);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MedicineInfoDto>> Post(MedicineInfoDto recordDto){
       var record = _Mapper.Map<MedicineInfo>(recordDto);
       _UnitOfWork.MedicineInfos.Add(record);
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
    public async Task<ActionResult<MedicineInfoDto>> Put(int id, [FromBody]MedicineInfoDto recordDto){
       if(recordDto == null)
           return NotFound();
       var record = _Mapper.Map<MedicineInfo>(recordDto);
       record.Id = id;
       _UnitOfWork.MedicineInfos.Update(record);
       await _UnitOfWork.SaveChanges();
       return recordDto;
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
       var record = await _UnitOfWork.MedicineInfos.GetByIdAsync(id);
       if(record == null){
           return NotFound();
       }
       _UnitOfWork.MedicineInfos.Remove(record);
       await _UnitOfWork.SaveChanges();
       return NoContent();
    }
}
