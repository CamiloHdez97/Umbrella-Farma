using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class RecipeRepository : GenericRepositoryStringId<Recipe>, IRecipeRepository{
    public RecipeRepository(DataContext context) : base(context){}
    protected override bool PaginateExpression(Recipe entity, string search){        
        if(DateTime.TryParse(search,out DateTime searchDate)){
            return entity.RecipeDate.Equals(searchDate);
        }
        return true;
    }
}