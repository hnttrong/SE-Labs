using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class Repository<T> where T : class
    {
        public List<T> GetAll()
        {
            using (var context = new Lab4DbContext())
            {
                return context.Set<T>().AsNoTracking().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new Lab4DbContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Add(T entity)
        {
            using (var context = new Lab4DbContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public bool Update(T entity)
        {
            using (var context = new Lab4DbContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new Lab4DbContext())
            {
                var entity = context.Set<T>().Find(id);
                if (entity == null)
                {
                    return false;
                }

                context.Set<T>().Remove(entity);
                return context.SaveChanges() > 0;
            }
        }
    }
}
