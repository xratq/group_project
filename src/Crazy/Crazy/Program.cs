using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ShopContext())
            {
                dbContext.Additional_characteristics.Add(new Additional_characteristic { });
                dbContext.SaveChanges();
            }
            using (var dbContext = new ShopContext())
            {
                dbContext.Audiences.Add(new Audience { });
                dbContext.SaveChanges();
            }
            using (var dbContext = new ShopContext())
            {
                dbContext.Educational_buildings.Add(new Educational_building {});
                dbContext.SaveChanges();
            }
            using (var dbContext = new ShopContext())
            {
                dbContext.Equipment_lists.Add(new Equipment_list { });
                dbContext.SaveChanges();
            }
            using (var dbContext = new ShopContext())
            {
                dbContext.Software_lists.Add(new Software_list { });
                dbContext.SaveChanges();
            }
        }
    }
}
