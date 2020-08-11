using _212TeamProject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCRUDApp
{
    public static class VehilceDb
    {
        public static List<Vehicle> GetAllVehicles()
        {
            using (var context = new VehicleModel())
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

        public static void Add(Vehicle v)
        {
            //SqlConnection con = dbHelper.GetConnection();

            //SqlCommand insertCmd = new SqlCommand();
            //insertCmd.Connection = con;
            //insertCmd.CommandText = "INSERT INTO Vehicles(VehicleIdNum, PlateNum, Make, Model, Year, Color)" +
            //    "VALUES(@VehIDNum, @PlateNum, @Make, @Model, @Year, @Color)";
            //insertCmd.Parameters.AddWithValue("@VehIDNum", v.VehicleIdNum);
            //insertCmd.Parameters.AddWithValue("@PlateNum", v.PlateNum);
            //insertCmd.Parameters.AddWithValue("@Make", v.Make);
            //insertCmd.Parameters.AddWithValue("@Model", v.Model);
            //insertCmd.Parameters.AddWithValue("@Year", v.Year);
            //insertCmd.Parameters.AddWithValue("@Color", v.Color);

            //// open connection
            //con.Open();

            //// Execute command
            //insertCmd.ExecuteNonQuery();

            //// Colse connection 
            //con.Close();

            // Everything done above can just be done like this below with less errors
            using (var context = new VehicleModel())
            {
                context.Vehicles.Add(v); // prepares insert query
                context.SaveChanges(); //Executes all pending insert update and delete 
            }
        }

        public static Vehicle Update(Vehicle v)
        {
            using (var context = new VehicleModel())
            {
                context.Database.Log = Console.WriteLine;
                context.Entry(v).State = EntityState.Modified;
                context.SaveChanges();

                return v;
            }
        }

        public static void Delete(Vehicle v)
        {
            using (var context = new VehicleModel())
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(v).State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public static void Delete(int Id)
        {
            using(var context = new VehicleModel())
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
