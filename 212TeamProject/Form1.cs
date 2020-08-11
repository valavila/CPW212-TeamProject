using EntityFrameworkCRUDApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _212TeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateVehiclesLisrBox();
        }

        /// <summary>
        /// Shows Vehicle specifications when a car is selected 
        /// from the drop down list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Populates drop down list of Vehicles to choose from
        /// </summary>
        private void PopulateVehiclesLisrBox()
        {
            List<Vehicle> allVehicles = VehilceDb.GetAllVehicles();

            CarListCbox.DataSource = allVehicles;
            CarListCbox.DisplayMember = nameof(Vehicle.VehicleName);

        }

        /// <summary>
        /// Opens Add car form then adds new car car to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBTN_Click(object sender, EventArgs e)
        {
            AddCar addCarForm = new AddCar();
            addCarForm.ShowDialog();

            List<Vehicle> allVehicles = VehilceDb.GetAllVehicles();
            PopulateVehiclesLisrBox();
        }
    }
}
