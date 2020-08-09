using _212TeamProject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCRUDApp
{
    static class VehilceDb
    {
        public static List<Vehicle> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public static Vehicle Add(Vehicle v)
        {
            throw new NotImplementedException();
        }

        public static Vehicle Update(Vehicle v)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Vehicle v)
        {
            using (VehicleContext context = new VehicleContext())
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(v).State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public static void Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
