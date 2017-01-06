namespace VSMS
{
    partial class AdminF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminF));
            this.ManageEmployeesB = new System.Windows.Forms.Button();
            this.ChooseAction = new System.Windows.Forms.Label();
            this.ManageVehicles = new System.Windows.Forms.Button();
            this.EXITB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageEmployeesB
            // 
            this.ManageEmployeesB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageEmployeesB.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageEmployeesB.Location = new System.Drawing.Point(94, 118);
            this.ManageEmployeesB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManageEmployeesB.Name = "ManageEmployeesB";
            this.ManageEmployeesB.Size = new System.Drawing.Size(215, 45);
            this.ManageEmployeesB.TabIndex = 0;
            this.ManageEmployeesB.Text = "Add New Employee";
            this.ManageEmployeesB.UseVisualStyleBackColor = false;
            this.ManageEmployeesB.Click += new System.EventHandler(this.ManageEmployeesB_Click);
            // 
            // ChooseAction
            // 
            this.ChooseAction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAction.ForeColor = System.Drawing.Color.White;
            this.ChooseAction.Location = new System.Drawing.Point(126, 57);
            this.ChooseAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseAction.Name = "ChooseAction";
            this.ChooseAction.Size = new System.Drawing.Size(161, 36);
            this.ChooseAction.TabIndex = 1;
            this.ChooseAction.Text = "Choose Action";
            // 
            // ManageVehicles
            // 
            this.ManageVehicles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageVehicles.Location = new System.Drawing.Point(94, 173);
            this.ManageVehicles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManageVehicles.Name = "ManageVehicles";
            this.ManageVehicles.Size = new System.Drawing.Size(215, 45);
            this.ManageVehicles.TabIndex = 2;
            this.ManageVehicles.Text = "Manage Vehicles";
            this.ManageVehicles.UseVisualStyleBackColor = false;
            this.ManageVehicles.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // EXITB
            // 
            this.EXITB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EXITB.ForeColor = System.Drawing.SystemColors.Control;
            this.EXITB.Location = new System.Drawing.Point(94, 228);
            this.EXITB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EXITB.Name = "EXITB";
            this.EXITB.Size = new System.Drawing.Size(215, 43);
            this.EXITB.TabIndex = 3;
            this.EXITB.Text = "Exit";
            this.EXITB.UseVisualStyleBackColor = false;
            this.EXITB.Click += new System.EventHandler(this.EXITB_Click);
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.EXITB);
            this.Controls.Add(this.ManageVehicles);
            this.Controls.Add(this.ChooseAction);
            this.Controls.Add(this.ManageEmployeesB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To VSMS Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminF_FormClosed);
            this.Load += new System.EventHandler(this.AdminF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageEmployeesB;
        private System.Windows.Forms.Label ChooseAction;
        private System.Windows.Forms.Button ManageVehicles;
        private System.Windows.Forms.Button EXITB;
    }
}