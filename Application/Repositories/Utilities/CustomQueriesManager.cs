using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;
public sealed class CustomQueriesManager: ICustomQueriesManager{
    private static DataContext _Context;
    
    public CustomQueriesManager(DataContext context)=> _Context = context;

    public async Task<IEnumerable<object>> ProvidersWhoHaveProvidedDifferentMedications(ProvidersWhoHaveProvidedDifferentMedicationsModel data = null){
        var medicines =  await (from detail in _Context.Set<ShoppingDetail>()
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join info in _Context.Set<MedicineInfo>() on inventory.MedicineInfoId equals info.Id
            select new {
                Supplier = person.Name,
                info.Name,                
                shopping.ShoppingDate,
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.ShoppingDate <= data.FinalDate  && 
                    x.ShoppingDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.ShoppingDate >= data.InitialDate ).ToList();
            } 
        }

        return from medicine in medicines
            group medicine by medicine.Supplier into supplierGrups
            let medicineGroups = from supplierGrup in supplierGrups
                group supplierGrup by supplierGrup.Name into medicineGroups
                let TotalMedicines = medicineGroups.Count()
                select new {
                    medicineGroups.First().Name,
                    TotalMedicines
                }
            let TotalMedications = medicineGroups.Sum(a => a.TotalMedicines)
            let NumberOfDifferentMedications = medicineGroups.Count()
            where NumberOfDifferentMedications >= data.MinimumNumberOfDifferentMedications
            select new {
                supplierGrups.First().Supplier,
                TotalMedications,
                NumberOfDifferentMedications,
                Medications = medicineGroups
            };
    }
    public async Task<IEnumerable<object>> MedicinesByPriceAndStock(MedicinesByPriceAndStockModel data = null){
        var medicines = await (from detail in _Context.Set<ShoppingDetail>()
            join medicine in _Context.Set<Medicine>() on detail.MedicineId equals medicine.Id
            join state in _Context.Set<State>() on medicine.StateId equals state.Id
            join inventory in _Context.Set<Inventory>() on medicine.InventoryId equals inventory.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on inventory.MedicineInfo.Id equals medicineInfo.Id
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            where state.Id == 1 
            select new {
                Supplier = person.Name,
                medicineInfo.Name,
                medicineInfo.Price                
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroups
            let Stock = medicineGroups.Count()
            let TotalEstimated = medicineGroups.Sum(x => x.Price)
            let suppliers = from medicineGroup in medicineGroups
                group medicineGroup by medicineGroup.Supplier into supplierGrups
                let TotalPurchases = supplierGrups.Sum(x => x.Price).ToString("c")
                let Units = supplierGrups.Count()
                select new{
                    supplierGrups.First().Supplier,
                    Units
                }
            select new{
                medicineGroups.First().Name,
                Stock,                
                UnitPrice = medicineGroups.First().Price,
                TotalEstimated,
                suppliers
            };

        if(data?.Price != null && data?.Price >= 0){
            if(data.HasAHigherPrice == true){
                res = res.Where(x => x.UnitPrice >= data.Price).ToList();
            }else{
                res = res.Where(x => x.UnitPrice <= data.Price).ToList();
            }
        }
        if(data?.Stock != null && data?.Stock >= 0){
            if(data.HasAHigherStock == true){
                res = res.Where(x => x.Stock >= data.Stock).ToList();
            }else{
                res = res.Where(x => x.Stock <= data.Stock).ToList();
            }
        }

        return res.Select(res => new{
                res.Name,
                res.Stock,                
                UnitPrice = res.UnitPrice.ToString("c"),
                res.TotalEstimated,
                res.suppliers
            });
    }
    public async Task<IEnumerable<object>> SuppliersWhoHaveSuppliedMedications(SuppliersWhoHaveSuppliedMedicationsModel data = null){
        var medicines = await (from detail in _Context.Set<ShoppingDetail>()
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicineInfo.Id
            join supplier in _Context.Set<Supplier>() on shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                Supplier = person.Name,
                medicineInfo.Name,
                shopping.ShoppingDate,
                Price,
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.ShoppingDate <= data.FinalDate  && 
                    x.ShoppingDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.ShoppingDate >= data.InitialDate ).ToList();
            } 
        }        

        var res =  from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup
            let MoneyInvested = medicineGroup.Sum(x => x.Price)
            let TotalPurchases = medicineGroup.Count()
            orderby TotalPurchases descending
            let medicinesTotals = from medicineTotal in medicineGroup
                group medicineTotal by medicineTotal.Name into medicineTotalGroup
                select  new {
                    medicineTotalGroup.First().Name,
                    TotalPurchases = medicineTotalGroup.Sum(x => x.Price).ToString("c"), 
                    medicinesTotals = medicineTotalGroup.Count()
                }
            select new {
                medicineGroup.First().Supplier,  
                medicines = medicinesTotals,           
                MoneyInvested = MoneyInvested.ToString("c"),
                TotalPurchases
            };    

        if(data?.IsUnder != false){
            return res.Where(x => x.TotalPurchases <= data.MinimalMedications);    
        }
        return res.Where(x => x.TotalPurchases >= data.MinimalMedications);     
    }
    public async Task<IEnumerable<object>> EmployeesWhoHaveMadeSales(EmployeesWhoHaveMadeSalesModel data = null){
        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            join sale in _Context.Set<Sale>() on detail.SaleId equals sale.Id
            join employee in _Context.Set<Employee>() on sale.EmployeeId equals employee.Id
            join person in _Context.Set<Person>() on employee.PersonId equals person.Id
            join medicineInfo in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfoId equals medicineInfo.Id
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))
            select new {
                person.Name,
                Price,
                sale.SaleDate
            }).ToListAsync();

        if(data?.InitialDate != null ){
            if( data?.FinalDate != null && data.InitialDate < data.FinalDate){
                medicines = medicines.Where(x => 
                    x.SaleDate <= data.FinalDate  && 
                    x.SaleDate >= data.InitialDate
                ).ToList();
            }else {
                medicines = medicines.Where(x => x.SaleDate >= data.InitialDate ).ToList();
            } 
        }

        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            let RaisedMoney = medicineGroup.Sum(x => x.Price)
            let TotalSales = medicineGroup.Count()
            select new {
                medicineGroup.First().Name,
                RaisedMoney = RaisedMoney.ToString("c"),
                TotalSales
            };
        if(data?.IsUnder != false){
            return res.Where(x => x.TotalSales <= data.MinimumSales);    
        }
        return res.Where(x => x.TotalSales >= data.MinimumSales);
    }
    public async Task<IEnumerable<object>> MedicineWithMinStock (int minStock){
        return await (from medicineItem in _Context.Set<MedicineInfo>()
            select new {
                Medicine = new{
                    medicineItem.Id,
                    medicineItem.Name,
                    medicineItem.Price,
                    medicineItem.Discount,
                    medicineItem.Image,
                    medicineItem.RequiredRecipe,
                    MedicineBrand = medicineItem.MedicineBrand.Name,
                    MedicinePresentation = medicineItem.MedicinePresentation.Name,
                    MedicineCategory = medicineItem.MedicineCategory.Name
                },
                TotalStock = _Context.Set<Medicine>().Where(x => x.Inventory.MedicineInfo.Name == medicineItem.Name && x.StateId == 1).Count()
            }).ToListAsync();        
    }
    public async Task<IEnumerable<object>> PurchasedBySupplier (MedicineInfoSupplierModel data ){
        var medicines =  await(from detail in _Context.Set<ShoppingDetail>()
            join supplier in _Context.Set<Supplier>() on detail.Shopping.SupplierId equals supplier.Id
            join person in _Context.Set<Person>() on supplier.PersonId equals person.Id
            join shopping in _Context.Set<Shopping>() on detail.ShoppingId equals shopping.Id
            let medicineInfo = detail.Medicine.Inventory.MedicineInfo
            let Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100))

            select new {
                Date = shopping.ShoppingDate,
                Supplier = person.Name,
                medicineInfo.Name,
                Price                
            }).ToListAsync();
            if (data.InitialDate != null){            
            if (data.FinalDate != null && data.FinalDate < data.InitialDate){
                medicines = medicines.Where(x => 
                    x.Date >= (
                        data.HasCoincidence
                            ?data.InitialDate 
                            :data.FinalDate) && 
                    x.Date <= (
                        data.HasCoincidence
                            ?data.FinalDate 
                            :data.InitialDate) 
                ).ToList();
            }else{
                medicines = medicines.Where(x => 
                    data.HasCoincidence
                        ? x.Date >= data.InitialDate
                        : x.Date <= data.InitialDate
                ).ToList();
            }
        }
        var res = from medicine in medicines
            group medicine by medicine.Supplier into medicineGroup
            let Total = medicineGroup.Sum(x => x.Price)
            let Units = medicineGroup.Count()
            select new {
                medicineGroup.First().Supplier,
                Total,
                Units
            };

        if (data.SupplierName != null){
            return res.Where(x => 
                data.HasCoincidence
                    ?x.Supplier == data.SupplierName
                    :x.Supplier != data.SupplierName
            );            
        }
        return res;
    } 
    public async Task<IEnumerable<MedicineDetailTotalModel>> TotalDrugSales(string MedicineName){
        var data  = await (from detail in _Context.Set<SaleDetail>()
                join state in _Context.Set<State>() on detail.Medicine.StateId equals state.Id
                where detail.Medicine.Inventory.MedicineInfo.Name.Trim().ToLower() == MedicineName.Trim().ToLower() && state.Id == 1
                select detail.Medicine.Inventory.MedicineInfo
            ).ToListAsync();            
        return MovementDetail( data );
    }    
    public async Task<IEnumerable<object>> TotalMedicationsSoldByProvider(){
        var medicines = await (
                from detail in _Context.Set<ShoppingDetail>()
                let medicineInfo = detail.Medicine.Inventory.MedicineInfo
                join supplier in _Context.Set<Supplier>() on detail.Shopping.SupplierId equals supplier.Id
                join Person in _Context.Set<Person>() on supplier.PersonId equals Person.Id
                select  new {                                
                    medicineInfo.Name,
                    Price = medicineInfo.Price - (medicineInfo.Price * (medicineInfo.Discount / 100)),
                    medicineInfo.Description,
                    medicineInfo.Image,
                    Supplier = Person.Name
                }).ToListAsync();
        return from medicine in medicines 
            group medicine by medicine.Supplier into medicineGroup               
            select new {
                medicineGroup.First().Supplier,
                TotalSaled = medicineGroup.Sum(x => x.Price).ToString("c"),
                TotalUnits = medicineGroup.Count()
            };
    }
    public async Task<float> MoneyRaisedFromSales(string medicineName = null){

        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            let medicine = detail.Medicine.Inventory.MedicineInfo
            select new {
                medicine.Name,
                Price = medicine.Price - (medicine.Price * (medicine.Discount / 100)),
            }).ToListAsync();
        
        var res = from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            select new {
                medicineGroup.First().Name,
                TotalPrice = medicineGroup.Sum(x => x.Price) * medicineGroup.Count(),                
            };

        if(medicineName!= null){
            return res.Where(x => x.Name == medicineName).Sum(x => x.TotalPrice);
        }
        return res.Sum(x => x.TotalPrice);

    }
    public async Task<IEnumerable<object>> TotalMedicineSold(TotalMedicineSoldModel conditions = null){
        var medicines = await (from detail in _Context.Set<SaleDetail>()
            join sale in _Context.Set<Sale>() on detail.SaleId equals sale.Id
            join medicine in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                sale.SaleDate,                
                medicine.Name,
                medicine.Description,
                medicine.Image,
                Price
            }).ToListAsync();
        if (conditions != null && conditions?.InitialDate != null){            
            if (conditions.FinalDate != null && conditions.FinalDate < conditions.InitialDate){
                medicines = medicines.Where(x => 
                    x.SaleDate >= conditions.InitialDate && 
                    x.SaleDate <= conditions.FinalDate
                ).ToList();
            }else{
                medicines = medicines.Where(x => x.SaleDate >= conditions.InitialDate).ToList();
            }
        }
        var res =  from medicine in medicines 
            group medicine by medicine.Name into medicineGroup
            let TotalSale = medicineGroup.Sum(x => x.Price)
            let Units = medicineGroup.Count()
            let salesAverage = TotalSale / Units            
            orderby TotalSale descending
            select new {
                medicineGroup.First().Name,
                salesAverage,
                TotalSale = TotalSale.ToString("c"),
                Units
            };
        if (conditions?.GetLessSales == true){
            var avarange = res.Average(x => x.salesAverage);
            return res.Where(x => x.salesAverage <= avarange);
        }
        return res;
    }
    public async Task<IEnumerable<object>> PatientsWhoHaveAcquiredParacetamol(string Patients = null){
        var medicines =  await (from detail in _Context.Set<SaleDetail>()
            join person in _Context.Set<Person>() on detail.Sale.PersonId equals person.Id
            join medicine in _Context.Set<MedicineInfo>() on detail.Medicine.Inventory.MedicineInfo.Id equals medicine.Id
            let Price = medicine.Price - (medicine.Price * (medicine.Discount / 100))
            select new {
                Patient = person.Name,
                medicine.Name,
                medicine.Description,
                medicine.Image,
                Price
            }).ToListAsync();

        var res = from medicine in medicines 
            group medicine by medicine.Patient into medicineGroup
            let TotalUnits = medicineGroup.Count()
            let TotalPrice = medicineGroup.Sum(x => x.Price)             
            select new {
                medicineGroup.First().Patient,
                medicineGroup.First().Name,
                TotalUnits,
                TotalPrice
            };
        if(Patients != null){
            return res.Where(x => x.Patient.Trim().ToLower() == Patients.Trim().ToLower());
        }
        return res;
    }
    public async Task<IEnumerable<object>> MedicationsThatHaveNotBeenSold(int? year){
        year ??= DateTime.Now.Year;
        var medicines =  await (from medicine in _Context.Set<Medicine>()
            join info in _Context.Set<MedicineInfo>() on medicine.Inventory.MedicineInfo.Id 
            equals info.Id
            join state in _Context.Set<State>() on medicine.StateId equals state.Id
            where !medicine.Sales.Any() && state.Description == "default" && medicine.CreationDate.Year == year
            select new {
                medicine.Id,
                info.Name,
                medicine.ExpirationDate,
                medicine.CreationDate,
            }).ToListAsync();
        return from medicine in medicines
            group medicine by medicine.Name into medicineGroup
            let units = medicineGroup.Count()
            select new {
                Name = medicineGroup.First().Name,
                TotalUnits = units
            };
    }

    private static IEnumerable<MedicineDetailTotalModel> MovementDetail(IEnumerable<MedicineInfo> data){
        var medicines =(from detail in data             
            select new MedicineDetailModel{                                
                Name = detail?.Name,
                Price = detail.Price - (detail.Price * (detail.Discount / 100)),
                Description = detail?.Description,
                Image = detail?.Image,
            }).ToList();

        return from medicine in medicines
            group medicine by medicine.Name into grouped
            select new MedicineDetailTotalModel{
                Medicine = grouped.First(),
                Total = grouped.Count()
            };
    }    

        public async Task<IEnumerable<object>> MedicineExpireBeforeYear(int year){
        return await (
            from medicineInfo in _Context.Set<MedicineInfo>()
                join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.MedicineInfoId
                join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.InventoryId
                where medicine.ExpirationDate.Year > year
                select new
                {
                    id = medicine.Id,
                    Medicine = medicineInfo.Name,
                    Expiration = medicine.ExpirationDate
                }).ToListAsync();            
    }

    public async Task<IEnumerable<object>> MedicineExpireInYear(int year){
            return await (
                from medicineInfo in _Context.Set<MedicineInfo>()
                    join inventory in _Context.Set<Inventory>() on medicineInfo.Id equals inventory.MedicineInfoId
                    join medicine in _Context.Set<Medicine>() on inventory.Id equals medicine.InventoryId
                    where medicine.ExpirationDate.Year == year
                    select new
                    {
                        id = medicine.Id,
                        Medicine = medicineInfo.Name,
                        Expiration = medicine.ExpirationDate
                    }).ToListAsync();            
        }

    
}
