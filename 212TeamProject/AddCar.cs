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

            newVehicle = new Vehicle();

            newVehicle.VehicleIdNum = Convert.ToString(VINbox.Text);
            newVehicle.PlateNum = Convert.ToString(PlateBox.Text);
            newVehicle.Make = Convert.ToString(MakeBox.Text);
            newVehicle.Model = Convert.ToString(ModelBox.Text);
            newVehicle.Year = Convert.ToInt32(YearBox.Text);
            newVehicle.Color = Convert.ToString(ColorBox.Text);

            MessageBox.Show($"Thank you for inputting {newVehicle.VehicleInfo}");
            Close();
        }
    }
}
