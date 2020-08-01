﻿using SERP.Core.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SERP.Core.Services.GenericService
{
    public interface IGenericService<TEntity,T> where TEntity:class
    {
        Task<IList<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties);
        Task<IList<TEntity>> GetList(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties);
        Task<TEntity> GetSingle(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties);
        Task<ResponseStatus> Add(params TEntity[] items);
        Task<ResponseStatus> Update(params TEntity[] items);
        Task<ResponseStatus> Delete(params TEntity[] items);
        Task<ResponseStatus> CreateEntity(TEntity model);
        Task<bool> CreateNewContext();
    }
}
