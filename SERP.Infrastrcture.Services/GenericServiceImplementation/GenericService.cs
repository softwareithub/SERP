using SERP.Core.Entities.Comman;
using SERP.Core.Repository.GenericRepository;
using SERP.Core.Services.GenericService;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Infrastrcture.Services.GenericServiceImplementation
{
    public class GenericService<TEntity, T> : IGenericService<TEntity, T> where TEntity : class
    {
        private readonly IGenericRepository<TEntity, T> _IGenericRepository;

        public GenericService(IGenericRepository<TEntity, T> genericRepository)
        {
            _IGenericRepository = genericRepository;
        }
        public async  Task<ResponseStatus> Add(params TEntity[] items)
        {
            return await _IGenericRepository.Add(items);
        }

        public async Task<ResponseStatus> CreateEntity(TEntity model)
        {
            return await _IGenericRepository.CreateEntity(model);
        }

        public async Task<bool> CreateNewContext()
        {
            return await _IGenericRepository.CreateNewContext();
        }

        public async  Task<ResponseStatus> Delete(params TEntity[] items)
        {
            return await _IGenericRepository.Delete(items);
        }

        public async Task<IList<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            return await _IGenericRepository.GetAll(navigationProperties);
        }

        public async  Task<IList<TEntity>> GetList(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            return await _IGenericRepository.GetList(where, navigationProperties);
        }

        public async Task<TEntity> GetSingle(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            return await _IGenericRepository.GetSingle(where, navigationProperties);
        }

        public async Task<ResponseStatus> Update(params TEntity[] items)
        {
            return await _IGenericRepository.Update(items);
        }
    }
}
