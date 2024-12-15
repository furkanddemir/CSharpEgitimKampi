using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entitiy);
        void Update(T entitiy);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
