using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class EmployeeRepository : GenericRepositoryIntId<Employee>, IEmployeeRepository{
    public EmployeeRepository(DataContext context) : base(context){}
}