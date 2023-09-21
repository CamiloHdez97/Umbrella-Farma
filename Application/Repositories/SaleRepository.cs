using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class SaleRepository : GenericRepositoryIntId<Sale>, ISaleRepository{
    public SaleRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Sale entity, string search){        
        if(DateTime.TryParse(search,out DateTime searchDate)){
            return entity.SaleDate.Equals(searchDate);
        }
        return true;
    }
}