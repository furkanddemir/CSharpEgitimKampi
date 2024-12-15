using cSharpEgitimKampi301.DataAccessLayer.Abstract;
using cSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object=context.Set<T>();       //GenericRepository çağrıldığı anda contexte obje oluşturur.
        }
        public void Delete(T entity)
        {
            var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entitiy)
        {
            var addedEntity=context.Entry(entitiy);
            context.SaveChanges();
        }

        public void Update(T entitiy)
        {
            var updatedEntity.State=context.Entry(entitiy);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
