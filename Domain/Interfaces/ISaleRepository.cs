using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface ISaleRepository: IGenericRepositoryIntId<Sale>{
    Task<object> VipBuyer();
    Task<IEnumerable<object>> AllSaleCustomer(int year);
    Task<object> GetSaleParacetamol(String medicineInput, int Year);


}