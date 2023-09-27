using System.Linq.Expressions;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Persistence;

namespace Application.Repositories;
public sealed class RecipeRepository : GenericRepositoryStringId<Recipe>, IRecipeRepository{
    private readonly DataContext _context;
    public RecipeRepository(DataContext context) : base(context){
        _context = context;
    }
    protected override bool PaginateExpression(Recipe entity, string search){        
        if(DateTime.TryParse(search,out DateTime searchDate)){
            return entity.RecipeDate.Equals(searchDate);
        }
        return true;
    }

    protected override async Task<IEnumerable<Recipe>> GetAll(Expression<Func<Recipe, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Sale)
                .Include(x => x.Eps)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Sale)            
            .Include(x => x.Eps)
            .ToListAsync();
    }

            public async Task<IEnumerable<object>> GetDateJunary2023(int year){
                
            return await _context.Recipes.Where(recipe => recipe.RecipeDate > new DateTime(year,1,1)).ToListAsync();

        }


    
}