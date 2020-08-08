using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212TeamProject
{
    public class Vehicle
    {
        /// <summary>
        /// Id of vehicle
        /// </summary>
        public int VehicleId { get; set; }

        /// <summary>
        /// VIN of the car
        /// </summary>
        public string VehicleIdNum { get; set; }

        /// <summary>
        /// Liecinse plate number
        /// </summary>
        public string PlateNum { get; set; }

        /// <summary>
        /// what company made the car BMW, Jeep, etc.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// What version of the car Compass, Mita, Model S
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Year the car is made
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Color of the car
        /// </summary>
        public string Color { get; set; }


    }
}
