﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
  public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entitiy);

    }
}
