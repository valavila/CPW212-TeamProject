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

        public Vehicle UserInput { get; set; }

        private void AddCarBTN_Click(object sender, EventArgs e)
        {
            //Input is most likly valid

            Vehicle newVehicle = new Vehicle();

            newVehicle.VehicleIdNum = Convert.ToString(VINbox);
            newVehicle.PlateNum = Convert.ToString(PlateBox);
            newVehicle.Make = Convert.ToString(MakeBox);
            newVehicle.Model = Convert.ToString(ModelBox);
            newVehicle.Year = Convert.ToInt32(YearBox);
            newVehicle.Color = Convert.ToString(ColorBox);

            UserInput = newVehicle;

            MessageBox.Show($"Thank you for inputting {newVehicle.VehicleInfo}");
            Close();
        }
    }
}
