﻿using RealEstateApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RealEstateApp.Core.Interfaces
{
    public interface IRepository<T> where T : class, IAggregateRoot
    {
        Task <IReadOnlyList<T>> GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
