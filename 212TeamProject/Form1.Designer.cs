﻿namespace _212TeamProject
{
    partial class Form1
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
            this.CarListCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChosenCarsLBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarListCbox
            // 
            this.CarListCbox.FormattingEnabled = true;
            this.CarListCbox.Location = new System.Drawing.Point(178, 92);
            this.CarListCbox.Name = "CarListCbox";
            this.CarListCbox.Size = new System.Drawing.Size(260, 28);
            this.CarListCbox.TabIndex = 1;
            this.CarListCbox.SelectedIndexChanged += new System.EventHandler(this.CarListCbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Car: ";
            // 
            // ChosenCarsLBox
            // 
            this.ChosenCarsLBox.FormattingEnabled = true;
            this.ChosenCarsLBox.ItemHeight = 20;
            this.ChosenCarsLBox.Location = new System.Drawing.Point(48, 206);
            this.ChosenCarsLBox.Name = "ChosenCarsLBox";
            this.ChosenCarsLBox.Size = new System.Drawing.Size(555, 104);
            this.ChosenCarsLBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chosen Cars Specifications:";
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(477, 92);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(126, 35);
            this.AddBTN.TabIndex = 6;
            this.AddBTN.Text = "Add Car";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChosenCarsLBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarListCbox);
            this.Name = "Form1";
            this.Text = "Car Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CarListCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ChosenCarsLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBTN;
    }
}

