namespace VSMS
{
    partial class ResetPassF
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
            this.ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.EnterNewPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmNewPassword
            // 
            this.ConfirmNewPassword.Location = new System.Drawing.Point(364, 164);
            this.ConfirmNewPassword.Name = "ConfirmNewPassword";
            this.ConfirmNewPassword.Size = new System.Drawing.Size(129, 20);
            this.ConfirmNewPassword.TabIndex = 7;
            // 
            // EnterNewPassword
            // 
            this.EnterNewPassword.Location = new System.Drawing.Point(364, 104);
            this.EnterNewPassword.Name = "EnterNewPassword";
            this.EnterNewPassword.Size = new System.Drawing.Size(129, 20);
            this.EnterNewPassword.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(62, 159);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(253, 38);
            this.Password.TabIndex = 5;
            this.Password.Text = "Confirm New Password";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserName.Location = new System.Drawing.Point(62, 99);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(274, 38);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Enter New Password";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Black;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(410, 241);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 30);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Black;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ResetButton.Location = new System.Drawing.Point(287, 241);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(82, 30);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // ResetPassF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VSMS.UI.Properties.Resources._6962075_download_high_res_car_wallpaper;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConfirmNewPassword);
            this.Controls.Add(this.EnterNewPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResetPassF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfirmNewPassword;
        private System.Windows.Forms.TextBox EnterNewPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResetButton;
    }
}