using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineRepository : GenericRepositoryIntId<Medicine>, IMedicineRepository{
    public MedicineRepository(DataContext context) : base(context){}
}