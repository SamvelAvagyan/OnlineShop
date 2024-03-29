﻿using OnlineShop.Repository;
using OnlineShop.Repository.Models;
using System.Linq;

namespace OnlineShop.Service.Impl
{
    public class BaseService<T> : IBaseService<T>
        where T : BaseModel
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(T model)
        {
            _baseRepository.Add(model);
        }

        public IQueryable<T> GetAll() 
        {
            return _baseRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _baseRepository.GetAll().FirstOrDefault(model => model.Id == id);
        }

        public void Update(T model)
        {
            _baseRepository.Update(model);
        }
    }
}
