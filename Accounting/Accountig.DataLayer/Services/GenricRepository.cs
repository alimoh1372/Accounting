using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accountig.DataLayer.Services
{
    public class GenricRepository<TEntity> where TEntity : class
    {
        private Accountig_DBEntities _db;

        private DbSet<TEntity> _dbSet;

        public GenricRepository(Accountig_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = _dbSet.Where(where);
            }
            return query.ToList();
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);

        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object Id)
        {
            TEntity entity = GetById(Id);
            Delete(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

    }
}
