using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityApplication.Data;
using UniversityApplication.Services;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected UniversityDataContext UniversityDataContext;

        public RepositoryBase(UniversityDataContext universityDataContext)
        {
            UniversityDataContext = universityDataContext;
        }


        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? UniversityDataContext.Set<T>().AsNoTracking() : UniversityDataContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges
                ? UniversityDataContext.Set<T>().Where(expression).AsNoTracking()
                : UniversityDataContext.Set<T>().Where(expression);

        public void Create(T entity) => UniversityDataContext.Set<T>().Add(entity);

        public void Update(T entity) => UniversityDataContext.Set<T>().Update(entity);

        public void Delete(T entity) => UniversityDataContext.Set<T>().Remove(entity);
    }
}
