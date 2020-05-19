using QuizGUI1.Database.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Database.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        private IDbSet<TEntity> Set;

        public Repository(DbContext context)
        {
            this.Context = context;
            this.Set = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Set.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Add(entity);
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Set.Where(predicate);
        }

        public TEntity Get(int ID)
        {
            return Set.Find(ID);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Set.ToList();
        }

        public void Remove(TEntity entity)
        {
            Set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Remove(entity);
            }
        }

        public void Update(TEntity entity)
        {
            Set.AddOrUpdate(entity);
        }
    }
}
