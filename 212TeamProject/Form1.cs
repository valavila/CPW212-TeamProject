﻿using EntityFrameworkCRUDApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _212TeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TEST DATA

            //var newCar = new Vehicle
            //{
            //    VehicleIdNum = "1C4RJFCTXCC204076",
            //    PlateNum = "576 ADV",
            //    Make = "Nissan",
            //    Model = "Sentra",
            //    Year = 2011,
            //    Color = "Black"
            //};
            //VehilceDb.Add(newCar);

            //newCar.Color = "Red";
            //VehilceDb.Update(newCar);

            //List<Vehicle> vehicles = VehilceDb.GetAllVehicles();

            //VehilceDb.Delete(newCar);


        }

        private void CarListCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenCarsLBox.Items.Clear();

            VehicleModel db = new VehicleModel();

            List<Vehicle> vehicles =
                (from v in db.Vehicles
                 select v).ToList();

            foreach (Vehicle v in vehicles)
            {
                if (CarListCbox.Text == v.VehicleName)
                {
                    ChosenCarsLBox.Items.Add(v.VehicleInfo);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vehicle> allVehicles = VehilceDb.GetAllVehicles();
            CarListCbox.DataSource = allVehicles;
            CarListCbox.DisplayMember = nameof(Vehicle.VehicleName);

            // Find a way to only have one of each car make and model


            // gets car info
            ChosenCarsLBox.Items.Clear();

            VehicleModel db = new VehicleModel();

            List<Vehicle> vehicles =
                (from v in db.Vehicles
                 select v).ToList();

            foreach (Vehicle v in vehicles)
            {
                if (CarListCbox.Text == v.VehicleName)
                {
                    ChosenCarsLBox.Items.Add(v.VehicleInfo);
                }
            }
        }
    }
}
