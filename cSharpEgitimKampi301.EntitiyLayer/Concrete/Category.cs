using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEgitimKampi301.EntitiyLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
    Field-Variable-Property

Eğer bir değişken direkt olarak sınıf içine tanımlanırsa bu bir field'dır.
int z; --> Field

Eğer o değişken yapısı sonuna  {get; set;} diye 2 değer alırsa bu bir property'dir.
public  int y { get; set; } --> Property

Eğer bir değer metot içinde tanımlanıyorsa bu bir Variable'dır.
void test()
{
    int z;          --> Variable
}
 
 */
