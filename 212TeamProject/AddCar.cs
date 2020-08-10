using EntityFrameworkCRUDApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _212TeamProject
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        public Vehicle newVehicle { get; set; }

        private void AddCarBTN_Click(object sender, EventArgs e)
        {
            //Input is most likly valid
            if(newVehicle == null)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.VehicleIdNum = Convert.ToString(VINbox.Text);
                vehicle.PlateNum = Convert.ToString(PlateBox.Text);
                vehicle.Make = Convert.ToString(MakeBox.Text);
                vehicle.Model = Convert.ToString(ModelBox.Text);
                vehicle.Year = Convert.ToInt32(YearBox.Text);
                vehicle.Color = Convert.ToString(ColorBox.Text);

                VehilceDb.Add(vehicle);
            }
            else
            {

            }


            Close();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }
    }
}
