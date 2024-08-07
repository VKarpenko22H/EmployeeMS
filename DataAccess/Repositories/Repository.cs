﻿using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class 
    {
        protected DbContext context;
        protected Repository(DbContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> GetAll() => context.Set<T>().ToList();

        public T GetById<IdType>(IdType id) => context.Set<T>().Find(id);
        
        public IEnumerable<T> Create(T t) => context.Set<T>().ToList();
    }
}

