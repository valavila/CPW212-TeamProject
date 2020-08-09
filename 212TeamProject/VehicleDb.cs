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
        /// <summary>
        /// Adds vehicle to database. Returns the vehicle
        /// with the <see cref="Vehicle.VehicleId"/> populated
        /// </summary>
        /// <param name="v">Vehicle to be added</param>
        /// <returns></returns>
        public static Vehicle Add(Vehicle v)
        {
            VehicleContext context = new VehicleContext();
            context.Vehicles.Add(v);
            context.SaveChanges();

            return v;
        }

        public static Vehicle Update(Vehicle v)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Vehicle v)
        {

            throw new NotImplementedException();
        }

        public static void Delete(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
