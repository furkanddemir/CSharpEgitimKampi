using cSharpEgitimKampi301.DataAccessLayer.Abstract;
using cSharpEgitimKampi301.DataAccessLayer.Repositories;
using cSharpEgitimKampi301.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEgitimKampi301.DataAccessLayer.EntitiyFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
