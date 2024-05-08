﻿using E_Commerce.Core.Entities;
using E_Commerce.Core.Repositories.Contract;
using E_Commerce.Core.Specifications;
using E_Commerce.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.APIs.Controllers
{
    public class GenericReposity<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext _dbcontext;
        public GenericReposity(ProjectContext dbcontext) {
            _dbcontext = dbcontext;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

       

        public async Task<T?> GetAsync(int id)
        {
                return await _dbcontext.Set<T>().FindAsync(id);
        }



        public async Task<IReadOnlyList<T>> GetAllSpecAsync(ISpecifications<T> spec)
        {
            return await ApplySpecifications(spec).ToListAsync();
        }
        public async Task<T?> GetSpecAsync(ISpecifications<T> spec)
        {

            return await ApplySpecifications(spec).FirstOrDefaultAsync();

        }

        private IQueryable<T> ApplySpecifications(ISpecifications<T> spec)
        {
            return SpecificationsEvalutor<T>.GetQuery(_dbcontext.Set<T>(), spec);
        }

        public async Task<int> GetCount(ISpecifications<T> spec)
        {
            return await ApplySpecifications(spec).CountAsync();
        }
    }
}
