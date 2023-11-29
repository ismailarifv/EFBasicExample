﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity.Interfaces
{
    internal interface ICrud<T>
    {
        List<T> GetList();

        T Get(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);

    }
}
