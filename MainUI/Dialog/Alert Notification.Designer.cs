
namespace MainUI.Dialog
{
    partial class Alert_Dialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert_Dialog));
            this.panelAlert = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxAlertIcon = new FontAwesome.Sharp.IconPictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tmAlert = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlertIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlert
            // 
            this.panelAlert.Controls.Add(this.pbxAlertIcon);
            this.panelAlert.Controls.Add(this.labelMessage);
            this.panelAlert.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelAlert.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlert.Location = new System.Drawing.Point(0, 0);
            this.panelAlert.Name = "panelAlert";
            this.panelAlert.ShadowDecoration.Parent = this.panelAlert;
            this.panelAlert.Size = new System.Drawing.Size(380, 70);
            this.panelAlert.TabIndex = 0;
            // 
            // pbxAlertIcon
            // 
            this.pbxAlertIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxAlertIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbxAlertIcon.IconChar = FontAwesome.Sharp.IconChar.NotEqual;
            this.pbxAlertIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbxAlertIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxAlertIcon.IconSize = 46;
            this.pbxAlertIcon.Location = new System.Drawing.Point(16, 16);
            this.pbxAlertIcon.Name = "pbxAlertIcon";
            this.pbxAlertIcon.Size = new System.Drawing.Size(50, 46);
            this.pbxAlertIcon.TabIndex = 3;
            this.pbxAlertIcon.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelMessage.Location = new System.Drawing.Point(72, 12);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(301, 46);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Success";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmAlert
            // 
            this.tmAlert.Interval = 1;
            this.tmAlert.Tick += new System.EventHandler(this.tmAlert_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Alert_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 70);
            this.Controls.Add(this.panelAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert_Dialog";
            this.Text = "Alert_Dialog";
            this.panelAlert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlertIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAlert;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Timer tmAlert;
        public FontAwesome.Sharp.IconPictureBox pbxAlertIcon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}