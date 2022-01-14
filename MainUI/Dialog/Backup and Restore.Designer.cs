
namespace MainUI.Dialog
{
    partial class Backup_and_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_and_Restore));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorFarmName = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btBackup = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFarmName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errRestore = new System.Windows.Forms.Label();
            this.btnCancelRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRestorePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwBackup = new System.ComponentModel.BackgroundWorker();
            this.bwRestore = new System.ComponentModel.BackgroundWorker();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 61);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(365, 323);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorFarmName);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btBackup);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtFarmName);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorFarmName
            // 
            this.errorFarmName.AutoSize = true;
            this.errorFarmName.BackColor = System.Drawing.Color.White;
            this.errorFarmName.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFarmName.ForeColor = System.Drawing.Color.Red;
            this.errorFarmName.Location = new System.Drawing.Point(32, 119);
            this.errorFarmName.Name = "errorFarmName";
            this.errorFarmName.Size = new System.Drawing.Size(28, 12);
            this.errorFarmName.TabIndex = 8;
            this.errorFarmName.Text = "*error";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnCancel.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(163, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btBackup
            // 
            this.btBackup.BackColor = System.Drawing.Color.Transparent;
            this.btBackup.BorderRadius = 6;
            this.btBackup.CheckedState.Parent = this.btBackup;
            this.btBackup.CustomImages.Parent = this.btBackup;
            this.btBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBackup.DisabledState.Parent = this.btBackup;
            this.btBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btBackup.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.ForeColor = System.Drawing.Color.White;
            this.btBackup.HoverState.Parent = this.btBackup;
            this.btBackup.Location = new System.Drawing.Point(251, 222);
            this.btBackup.Name = "btBackup";
            this.btBackup.ShadowDecoration.Parent = this.btBackup;
            this.btBackup.Size = new System.Drawing.Size(72, 28);
            this.btBackup.TabIndex = 6;
            this.btBackup.Text = "Save";
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup Folder Path:";
            // 
            // txtFarmName
            // 
            this.txtFarmName.BackColor = System.Drawing.Color.White;
            this.txtFarmName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFarmName.BorderRadius = 10;
            this.txtFarmName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFarmName.DefaultText = "";
            this.txtFarmName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFarmName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFarmName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFarmName.DisabledState.Parent = this.txtFarmName;
            this.txtFarmName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFarmName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFarmName.FocusedState.Parent = this.txtFarmName;
            this.txtFarmName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFarmName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFarmName.HoverState.Parent = this.txtFarmName;
            this.txtFarmName.Location = new System.Drawing.Point(34, 88);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.PasswordChar = '\0';
            this.txtFarmName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFarmName.PlaceholderText = "Click here to find path";
            this.txtFarmName.SelectedText = "";
            this.txtFarmName.ShadowDecoration.Parent = this.txtFarmName;
            this.txtFarmName.Size = new System.Drawing.Size(289, 28);
            this.txtFarmName.TabIndex = 2;
            this.txtFarmName.Click += new System.EventHandler(this.txtFarmName_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errRestore);
            this.tabPage2.Controls.Add(this.btnCancelRestore);
            this.tabPage2.Controls.Add(this.btnRestore);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtRestorePath);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errRestore
            // 
            this.errRestore.AutoSize = true;
            this.errRestore.BackColor = System.Drawing.Color.White;
            this.errRestore.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errRestore.ForeColor = System.Drawing.Color.Red;
            this.errRestore.Location = new System.Drawing.Point(32, 119);
            this.errRestore.Name = "errRestore";
            this.errRestore.Size = new System.Drawing.Size(28, 12);
            this.errRestore.TabIndex = 13;
            this.errRestore.Text = "*error";
            // 
            // btnCancelRestore
            // 
            this.btnCancelRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelRestore.BorderRadius = 6;
            this.btnCancelRestore.CheckedState.Parent = this.btnCancelRestore;
            this.btnCancelRestore.CustomImages.Parent = this.btnCancelRestore;
            this.btnCancelRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelRestore.DisabledState.Parent = this.btnCancelRestore;
            this.btnCancelRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnCancelRestore.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRestore.ForeColor = System.Drawing.Color.Red;
            this.btnCancelRestore.HoverState.Parent = this.btnCancelRestore;
            this.btnCancelRestore.Location = new System.Drawing.Point(163, 222);
            this.btnCancelRestore.Name = "btnCancelRestore";
            this.btnCancelRestore.ShadowDecoration.Parent = this.btnCancelRestore;
            this.btnCancelRestore.Size = new System.Drawing.Size(72, 28);
            this.btnCancelRestore.TabIndex = 12;
            this.btnCancelRestore.Text = "Cancel";
            this.btnCancelRestore.Click += new System.EventHandler(this.btnCancelRestore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BorderRadius = 6;
            this.btnRestore.CheckedState.Parent = this.btnRestore;
            this.btnRestore.CustomImages.Parent = this.btnRestore;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.DisabledState.Parent = this.btnRestore;
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRestore.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.Parent = this.btnRestore;
            this.btnRestore.Location = new System.Drawing.Point(251, 222);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShadowDecoration.Parent = this.btnRestore;
            this.btnRestore.Size = new System.Drawing.Size(72, 28);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(31, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Retore File Path:";
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.BackColor = System.Drawing.Color.White;
            this.txtRestorePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtRestorePath.BorderRadius = 10;
            this.txtRestorePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestorePath.DefaultText = "";
            this.txtRestorePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRestorePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRestorePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.DisabledState.Parent = this.txtRestorePath;
            this.txtRestorePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.FocusedState.Parent = this.txtRestorePath;
            this.txtRestorePath.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestorePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtRestorePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.HoverState.Parent = this.txtRestorePath;
            this.txtRestorePath.Location = new System.Drawing.Point(34, 88);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.PasswordChar = '\0';
            this.txtRestorePath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRestorePath.PlaceholderText = "Click here to find path";
            this.txtRestorePath.SelectedText = "";
            this.txtRestorePath.ShadowDecoration.Parent = this.txtRestorePath;
            this.txtRestorePath.Size = new System.Drawing.Size(289, 28);
            this.txtRestorePath.TabIndex = 9;
            this.txtRestorePath.Click += new System.EventHandler(this.txtRestorePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup and Restore";
            // 
            // bwBackup
            // 
            this.bwBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBackup_DoWork);
            this.bwBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwBackup_ProgressChanged);
            this.bwBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBackup_RunWorkerCompleted);
            // 
            // bwRestore
            // 
            this.bwRestore.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRestore_DoWork);
            this.bwRestore.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRestore_RunWorkerCompleted);
            // 
            // Backup_and_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(389, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TabControl1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Backup_and_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup_and_Restore";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFarmName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btBackup;
        private System.Windows.Forms.Label errorFarmName;
        private System.ComponentModel.BackgroundWorker bwBackup;
        private System.Windows.Forms.Label errRestore;
        private Guna.UI2.WinForms.Guna2Button btnCancelRestore;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtRestorePath;
        private System.ComponentModel.BackgroundWorker bwRestore;
    }
}