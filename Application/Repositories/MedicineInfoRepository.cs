using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Application.Repositories.Generics.GenericById;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Persistence;

namespace Application.Repositories;
public sealed class MedicineInfoRepository : GenericRepositoryIntId<MedicineInfo>, IMedicineInfoRepository{    

    public MedicineInfoRepository(DataContext context) : base(context){}

    protected override bool PaginateExpression(MedicineInfo entity, string search){
        return entity.Name.Trim().StartsWith(search);
    }
    protected override async Task<IEnumerable<MedicineInfo>> GetAll(Expression<Func<MedicineInfo, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.MedicineBrand)
                .Include(x => x.MedicinePresentation)
                .Include(x => x.MedicineCategory)
                .Where(expression).ToListAsync();
        }

        return await _Entities
            .Include(x => x.MedicinePresentation)
            .Include(x => x.MedicineCategory)
            .Include(x => x.MedicineBrand)            
            .ToListAsync();
    }

}