﻿using ePizzaHub.Repositories.Interfaces;
using ePizzaHub.Services.Interfaces;

namespace ePizzaHub.Services.Implementations
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        IRepository<TEntity> _repo;
        public Service(IRepository<TEntity> repo)
        {
            _repo = repo;   
        }

        public void Add(TEntity entity)
        {
            _repo.Add(entity);
            _repo.SaveChanges();
        }

        public void Delete(object Id)
        {
            _repo.Delete(Id);
            _repo.SaveChanges();
        }

        public TEntity Find(object Id)
        {
            return _repo.Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _repo.GetAll();
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
            _repo.SaveChanges();
        }
    }
}
