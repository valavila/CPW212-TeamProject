namespace _212TeamProject
{
    partial class AddCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VINbox = new System.Windows.Forms.TextBox();
            this.PlateBox = new System.Windows.Forms.TextBox();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VINbox
            // 
            this.VINbox.Location = new System.Drawing.Point(101, 12);
            this.VINbox.Name = "VINbox";
            this.VINbox.Size = new System.Drawing.Size(100, 20);
            this.VINbox.TabIndex = 0;
            // 
            // PlateBox
            // 
            this.PlateBox.Location = new System.Drawing.Point(101, 38);
            this.PlateBox.Name = "PlateBox";
            this.PlateBox.Size = new System.Drawing.Size(100, 20);
            this.PlateBox.TabIndex = 1;
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(101, 64);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(100, 20);
            this.MakeBox.TabIndex = 2;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(101, 90);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(100, 20);
            this.ModelBox.TabIndex = 3;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(101, 116);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(100, 20);
            this.YearBox.TabIndex = 4;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(101, 142);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(100, 20);
            this.ColorBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "VIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Licensce Plate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Make:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color:";
            // 
            // AddCarBTN
            // 
            this.AddCarBTN.Location = new System.Drawing.Point(52, 184);
            this.AddCarBTN.Name = "AddCarBTN";
            this.AddCarBTN.Size = new System.Drawing.Size(75, 23);
            this.AddCarBTN.TabIndex = 12;
            this.AddCarBTN.Text = "Add Car";
            this.AddCarBTN.UseVisualStyleBackColor = true;
            this.AddCarBTN.Click += new System.EventHandler(this.AddCarBTN_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 245);
            this.Controls.Add(this.AddCarBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.PlateBox);
            this.Controls.Add(this.VINbox);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VINbox;
        private System.Windows.Forms.TextBox PlateBox;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCarBTN;
    }
}