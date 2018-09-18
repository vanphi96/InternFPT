﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> SelectAll();
        Task<T> Get(object id);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(object id);
    }
}
