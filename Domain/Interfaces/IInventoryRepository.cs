using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IInventoryRepository: IGenericRepositoryIntId<Inventory>{}