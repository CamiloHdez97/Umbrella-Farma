using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class ShoppingRepository : GenericRepositoryIntId<Shopping>, IShoppingRepository{
    public ShoppingRepository(DataContext context) : base(context){}
}