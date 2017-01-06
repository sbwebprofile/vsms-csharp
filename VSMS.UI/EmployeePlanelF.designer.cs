namespace VSMS
{
    partial class EmployeePlanelF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePlanelF));
            this.AddViewvehicleButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ViewSoldVehiclesButton = new System.Windows.Forms.Button();
            this.BackToAdminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddViewvehicleButton
            // 
            this.AddViewvehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddViewvehicleButton.Location = new System.Drawing.Point(76, 128);
            this.AddViewvehicleButton.Name = "AddViewvehicleButton";
            this.AddViewvehicleButton.Size = new System.Drawing.Size(208, 32);
            this.AddViewvehicleButton.TabIndex = 0;
            this.AddViewvehicleButton.Text = "ADD | VIEW | SELL VEHICLE";
            this.AddViewvehicleButton.UseVisualStyleBackColor = true;
            this.AddViewvehicleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(76, 280);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(208, 32);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ViewSoldVehiclesButton
            // 
            this.ViewSoldVehiclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSoldVehiclesButton.Location = new System.Drawing.Point(76, 204);
            this.ViewSoldVehiclesButton.Name = "ViewSoldVehiclesButton";
            this.ViewSoldVehiclesButton.Size = new System.Drawing.Size(208, 32);
            this.ViewSoldVehiclesButton.TabIndex = 2;
            this.ViewSoldVehiclesButton.Text = "VIEW SOLD VEHICLES";
            this.ViewSoldVehiclesButton.UseVisualStyleBackColor = true;
            this.ViewSoldVehiclesButton.Click += new System.EventHandler(this.ViewSoldVehiclesButton_Click);
            // 
            // BackToAdminButton
            // 
            this.BackToAdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToAdminButton.Location = new System.Drawing.Point(76, 242);
            this.BackToAdminButton.Name = "BackToAdminButton";
            this.BackToAdminButton.Size = new System.Drawing.Size(208, 32);
            this.BackToAdminButton.TabIndex = 4;
            this.BackToAdminButton.Text = "BACK TO ADMIN";
            this.BackToAdminButton.UseVisualStyleBackColor = true;
            this.BackToAdminButton.Click += new System.EventHandler(this.BackToAdminButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "ADD NEW CAR MODEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EmployeePlanelF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackToAdminButton);
            this.Controls.Add(this.ViewSoldVehiclesButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddViewvehicleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeePlanelF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Employee Panel Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeePlanelF_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddViewvehicleButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ViewSoldVehiclesButton;
        private System.Windows.Forms.Button BackToAdminButton;
        private System.Windows.Forms.Button button1;
    }
}