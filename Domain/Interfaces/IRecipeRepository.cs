using Domain.Entities;
using Domain.Interfaces.Generics.GenericById;

namespace Domain.Interfaces;
public interface IRecipeRepository: IGenericRepositoryStringId<Recipe>{
    Task<IEnumerable<Object>> GetDateJunary2023(int year);

}