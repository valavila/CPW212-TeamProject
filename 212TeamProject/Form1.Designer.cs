namespace _212TeamProject
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
            this.CarListCbox.Location = new System.Drawing.Point(119, 60);
            this.CarListCbox.Margin = new System.Windows.Forms.Padding(2);
            this.CarListCbox.Name = "CarListCbox";
            this.CarListCbox.Size = new System.Drawing.Size(175, 21);
            this.CarListCbox.TabIndex = 1;
            this.CarListCbox.SelectedIndexChanged += new System.EventHandler(this.CarListCbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Car: ";
            // 
            // ChosenCarsLBox
            // 
            this.ChosenCarsLBox.FormattingEnabled = true;
            this.ChosenCarsLBox.Location = new System.Drawing.Point(32, 134);
            this.ChosenCarsLBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChosenCarsLBox.Name = "ChosenCarsLBox";
            this.ChosenCarsLBox.Size = new System.Drawing.Size(262, 69);
            this.ChosenCarsLBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chosen Cars Specifications:";
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(318, 60);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(84, 23);
            this.AddBTN.TabIndex = 6;
            this.AddBTN.Text = "Add Car";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChosenCarsLBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarListCbox);
            this.Margin = new System.Windows.Forms.Padding(2);
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

