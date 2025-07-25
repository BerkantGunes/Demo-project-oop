﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); // T classından türeyen t nesnesi
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
