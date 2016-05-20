﻿using System;
using System.Collections.Generic;
using System.Linq;
using Abp.EntityFramework;
using SPWA.People;

namespace SPWA.EntityFramework.Repositories
{
    public class PersonRepository : SPWARepositoryBase<Person, Int32>, IPersonRepository
    {
        public PersonRepository(IDbContextProvider<SPWADbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Person> GetPersons()
        {
            //在仓储方法中，不用处理数据库连接、DbContext和数据事务，ABP框架会自动处理。
            //GetAll() 返回一个 IQueryable<T>接口类型
            var query = GetAll();
            return query.OrderByDescending(p => p.Id).ToList();
        }
    }
}