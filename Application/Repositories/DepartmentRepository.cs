using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class DepartmentRepository : GenericRepositoryIntId<Department>, IDepartmentRepository{
    public DepartmentRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(Department entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
}