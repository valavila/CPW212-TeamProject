namespace _212TeamProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {

        public int VehicleId { get; set; }

        [Required]
        [StringLength(17)]
        public string VehicleIdNum { get; set; }

        [Required]
        [StringLength(8)]
        public string PlateNum { get; set; }

        [Required]
        [StringLength(40)]
        public string Make { get; set; }

        [Required]
        [StringLength(70)]
        public string Model { get; set; }

        public string VehicleName
        {
            get
            {
                return $"{Make} {Model}"; ;
            }
        }

        public string VehicleInfo
        {
            get
            {
                return $"{VehicleIdNum}: {PlateNum} {Make} {Model} {Year} {Color}"; ;
            }
        }

        public int Year { get; set; }

        [Required]
        [StringLength(30)]
        public string Color { get; set; }

        public string VehicleName()
        {
            return Make + " " + Model;
            
        }
    }
}
