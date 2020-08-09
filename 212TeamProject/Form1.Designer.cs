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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.CarListCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCarsBtn = new System.Windows.Forms.Button();
            this.ChosenCarsLBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(103, 162);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(160, 64);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarListCbox
            // 
            this.CarListCbox.FormattingEnabled = true;
            this.CarListCbox.Location = new System.Drawing.Point(179, 92);
            this.CarListCbox.Name = "CarListCbox";
            this.CarListCbox.Size = new System.Drawing.Size(121, 28);
            this.CarListCbox.TabIndex = 1;
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
            // ShowCarsBtn
            // 
            this.ShowCarsBtn.Location = new System.Drawing.Point(103, 283);
            this.ShowCarsBtn.Name = "ShowCarsBtn";
            this.ShowCarsBtn.Size = new System.Drawing.Size(160, 72);
            this.ShowCarsBtn.TabIndex = 3;
            this.ShowCarsBtn.Text = "Show Chosen Car(s)";
            this.ShowCarsBtn.UseVisualStyleBackColor = true;
            // 
            // ChosenCarsLBox
            // 
            this.ChosenCarsLBox.FormattingEnabled = true;
            this.ChosenCarsLBox.ItemHeight = 20;
            this.ChosenCarsLBox.Location = new System.Drawing.Point(440, 148);
            this.ChosenCarsLBox.Name = "ChosenCarsLBox";
            this.ChosenCarsLBox.Size = new System.Drawing.Size(228, 104);
            this.ChosenCarsLBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chosen Cars Specifications:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChosenCarsLBox);
            this.Controls.Add(this.ShowCarsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarListCbox);
            this.Controls.Add(this.EnterBtn);
            this.Name = "Form1";
            this.Text = "Car Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.ComboBox CarListCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowCarsBtn;
        private System.Windows.Forms.ListBox ChosenCarsLBox;
        private System.Windows.Forms.Label label2;
    }
}

