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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newCar = new Vehicle
            {
                VehicleIdNum = "1C4RJFCTXCC204076",
                PlateNum = "576 ADV",
                Make = "Nissan",
                Model = "Sentra",
                Year = 2011,
                Color = "Black"
            };
            VehilceDb.Add(newCar);

            newCar.Color = "Red";
            VehilceDb.Update(newCar);

            List<Vehicle> vehicles = VehilceDb.GetAllVehicles();

            VehilceDb.Delete(newCar);
        }
    }
}
