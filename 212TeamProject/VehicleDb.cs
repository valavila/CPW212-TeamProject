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
        public static List<Vehicle> GetAllVehicles()
        {
            using (var context = new VehicleContext())
            {
                List<Vehicle> allVehicles =
                    (from car in context.Vehicles
                     select car).ToList();
                return allVehicles;
            }
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
            using (var context = new VehicleContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Entry(v).State = EntityState.Modified;
                context.SaveChanges();

                return v;
            }
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
            using(var context = new VehicleContext())
            {
                Vehicle carToDelete =
                    (from car in context.Vehicles
                     where car.VehicleId == Id
                     select car).Single();

                context.Entry(carToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
