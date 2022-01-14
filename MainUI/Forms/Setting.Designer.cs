
namespace MainUI
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtFarmName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestConnection = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.errorFarmName = new System.Windows.Forms.Label();
            this.tabSettings = new Guna.UI2.WinForms.Guna2TabControl();
            this.pgFarm = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnFarmCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveFarm = new Guna.UI2.WinForms.Guna2Button();
            this.pgProfile = new System.Windows.Forms.TabPage();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.errAddr = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.errContact = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUserPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.errUserPass = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserUname = new Guna.UI2.WinForms.Guna2TextBox();
            this.errUserUname = new System.Windows.Forms.Label();
            this.pbxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUserCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.errFullname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pgConnection = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.errPort = new System.Windows.Forms.Label();
            this.errUsername = new System.Windows.Forms.Label();
            this.errPassword = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errDatabase = new System.Windows.Forms.Label();
            this.errServer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tglSecurity = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabase = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tabSettings.SuspendLayout();
            this.pgFarm.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.pgProfile.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.pgConnection.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.txtFarmName.Location = new System.Drawing.Point(14, 84);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.PasswordChar = '\0';
            this.txtFarmName.PlaceholderText = "";
            this.txtFarmName.SelectedText = "";
            this.txtFarmName.ShadowDecoration.Parent = this.txtFarmName;
            this.txtFarmName.Size = new System.Drawing.Size(216, 28);
            this.txtFarmName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Farm Name:";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.White;
            this.btnTestConnection.BorderRadius = 6;
            this.btnTestConnection.CheckedState.Parent = this.btnTestConnection;
            this.btnTestConnection.CustomImages.Parent = this.btnTestConnection;
            this.btnTestConnection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTestConnection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTestConnection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTestConnection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTestConnection.DisabledState.Parent = this.btnTestConnection;
            this.btnTestConnection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnTestConnection.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnTestConnection.HoverState.Parent = this.btnTestConnection;
            this.btnTestConnection.Location = new System.Drawing.Point(12, 390);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.ShadowDecoration.Parent = this.btnTestConnection;
            this.btnTestConnection.Size = new System.Drawing.Size(217, 28);
            this.btnTestConnection.TabIndex = 7;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEdit.IconSize = 30;
            this.btnEdit.Location = new System.Drawing.Point(342, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errorFarmName
            // 
            this.errorFarmName.AutoSize = true;
            this.errorFarmName.BackColor = System.Drawing.Color.White;
            this.errorFarmName.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFarmName.ForeColor = System.Drawing.Color.Red;
            this.errorFarmName.Location = new System.Drawing.Point(12, 110);
            this.errorFarmName.Name = "errorFarmName";
            this.errorFarmName.Size = new System.Drawing.Size(28, 12);
            this.errorFarmName.TabIndex = 6;
            this.errorFarmName.Text = "*error";
            // 
            // tabSettings
            // 
            this.tabSettings.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabSettings.Controls.Add(this.pgFarm);
            this.tabSettings.Controls.Add(this.pgProfile);
            this.tabSettings.Controls.Add(this.pgConnection);
            this.tabSettings.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.ItemSize = new System.Drawing.Size(120, 40);
            this.tabSettings.Location = new System.Drawing.Point(9, 47);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(372, 483);
            this.tabSettings.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSettings.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabSettings.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSettings.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSettings.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabSettings.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSettings.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabSettings.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabSettings.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabSettings.TabButtonSize = new System.Drawing.Size(120, 40);
            this.tabSettings.TabIndex = 7;
            this.tabSettings.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // pgFarm
            // 
            this.pgFarm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pgFarm.Controls.Add(this.guna2GroupBox2);
            this.pgFarm.Location = new System.Drawing.Point(124, 4);
            this.pgFarm.Margin = new System.Windows.Forms.Padding(0);
            this.pgFarm.Name = "pgFarm";
            this.pgFarm.Size = new System.Drawing.Size(244, 475);
            this.pgFarm.TabIndex = 0;
            this.pgFarm.Text = "Farm";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox2.BorderRadius = 6;
            this.guna2GroupBox2.Controls.Add(this.btnFarmCancel);
            this.guna2GroupBox2.Controls.Add(this.btnSaveFarm);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.txtFarmName);
            this.guna2GroupBox2.Controls.Add(this.errorFarmName);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(244, 475);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Farm Setting";
            // 
            // btnFarmCancel
            // 
            this.btnFarmCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnFarmCancel.BorderRadius = 6;
            this.btnFarmCancel.CheckedState.Parent = this.btnFarmCancel;
            this.btnFarmCancel.CustomImages.Parent = this.btnFarmCancel;
            this.btnFarmCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFarmCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFarmCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFarmCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFarmCancel.DisabledState.Parent = this.btnFarmCancel;
            this.btnFarmCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnFarmCancel.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmCancel.ForeColor = System.Drawing.Color.Red;
            this.btnFarmCancel.HoverState.Parent = this.btnFarmCancel;
            this.btnFarmCancel.Location = new System.Drawing.Point(70, 434);
            this.btnFarmCancel.Name = "btnFarmCancel";
            this.btnFarmCancel.ShadowDecoration.Parent = this.btnFarmCancel;
            this.btnFarmCancel.Size = new System.Drawing.Size(72, 28);
            this.btnFarmCancel.TabIndex = 5;
            this.btnFarmCancel.Text = "Cancel";
            this.btnFarmCancel.Click += new System.EventHandler(this.btnFarmCancel_Click);
            // 
            // btnSaveFarm
            // 
            this.btnSaveFarm.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFarm.BorderRadius = 6;
            this.btnSaveFarm.CheckedState.Parent = this.btnSaveFarm;
            this.btnSaveFarm.CustomImages.Parent = this.btnSaveFarm;
            this.btnSaveFarm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveFarm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveFarm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveFarm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveFarm.DisabledState.Parent = this.btnSaveFarm;
            this.btnSaveFarm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSaveFarm.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFarm.ForeColor = System.Drawing.Color.White;
            this.btnSaveFarm.HoverState.Parent = this.btnSaveFarm;
            this.btnSaveFarm.Location = new System.Drawing.Point(158, 434);
            this.btnSaveFarm.Name = "btnSaveFarm";
            this.btnSaveFarm.ShadowDecoration.Parent = this.btnSaveFarm;
            this.btnSaveFarm.Size = new System.Drawing.Size(72, 28);
            this.btnSaveFarm.TabIndex = 4;
            this.btnSaveFarm.Text = "Save";
            this.btnSaveFarm.Click += new System.EventHandler(this.btnSaveFarm_Click);
            // 
            // pgProfile
            // 
            this.pgProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pgProfile.Controls.Add(this.guna2GroupBox3);
            this.pgProfile.Location = new System.Drawing.Point(124, 4);
            this.pgProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pgProfile.Name = "pgProfile";
            this.pgProfile.Size = new System.Drawing.Size(244, 475);
            this.pgProfile.TabIndex = 1;
            this.pgProfile.Text = "Profile";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox3.BorderRadius = 6;
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.txtAddress);
            this.guna2GroupBox3.Controls.Add(this.errAddr);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.txtContact);
            this.guna2GroupBox3.Controls.Add(this.errContact);
            this.guna2GroupBox3.Controls.Add(this.label14);
            this.guna2GroupBox3.Controls.Add(this.txtUserPass);
            this.guna2GroupBox3.Controls.Add(this.errUserPass);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.Controls.Add(this.txtUserUname);
            this.guna2GroupBox3.Controls.Add(this.errUserUname);
            this.guna2GroupBox3.Controls.Add(this.pbxProfile);
            this.guna2GroupBox3.Controls.Add(this.btnUserCancel);
            this.guna2GroupBox3.Controls.Add(this.btnUserSave);
            this.guna2GroupBox3.Controls.Add(this.txtFullname);
            this.guna2GroupBox3.Controls.Add(this.errFullname);
            this.guna2GroupBox3.Controls.Add(this.label10);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(244, 475);
            this.guna2GroupBox3.TabIndex = 6;
            this.guna2GroupBox3.Text = "Profile Setting";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label18.Location = new System.Drawing.Point(10, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 15);
            this.label18.TabIndex = 18;
            this.label18.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(13, 220);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(216, 28);
            this.txtAddress.TabIndex = 17;
            // 
            // errAddr
            // 
            this.errAddr.AutoSize = true;
            this.errAddr.BackColor = System.Drawing.Color.White;
            this.errAddr.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddr.ForeColor = System.Drawing.Color.Red;
            this.errAddr.Location = new System.Drawing.Point(11, 246);
            this.errAddr.Name = "errAddr";
            this.errAddr.Size = new System.Drawing.Size(28, 12);
            this.errAddr.TabIndex = 19;
            this.errAddr.Text = "*error";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label16.Location = new System.Drawing.Point(10, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "Contact No.:";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtContact.BorderRadius = 10;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(13, 153);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.Size = new System.Drawing.Size(216, 28);
            this.txtContact.TabIndex = 14;
            // 
            // errContact
            // 
            this.errContact.AutoSize = true;
            this.errContact.BackColor = System.Drawing.Color.White;
            this.errContact.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContact.ForeColor = System.Drawing.Color.Red;
            this.errContact.Location = new System.Drawing.Point(11, 179);
            this.errContact.Name = "errContact";
            this.errContact.Size = new System.Drawing.Size(28, 12);
            this.errContact.TabIndex = 16;
            this.errContact.Text = "*error";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label14.Location = new System.Drawing.Point(10, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Password";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.White;
            this.txtUserPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUserPass.BorderRadius = 10;
            this.txtUserPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPass.DefaultText = "";
            this.txtUserPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPass.DisabledState.Parent = this.txtUserPass;
            this.txtUserPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPass.FocusedState.Parent = this.txtUserPass;
            this.txtUserPass.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUserPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPass.HoverState.Parent = this.txtUserPass;
            this.txtUserPass.Location = new System.Drawing.Point(13, 360);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '\0';
            this.txtUserPass.PlaceholderText = "";
            this.txtUserPass.SelectedText = "";
            this.txtUserPass.ShadowDecoration.Parent = this.txtUserPass;
            this.txtUserPass.Size = new System.Drawing.Size(216, 28);
            this.txtUserPass.TabIndex = 11;
            // 
            // errUserPass
            // 
            this.errUserPass.AutoSize = true;
            this.errUserPass.BackColor = System.Drawing.Color.White;
            this.errUserPass.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUserPass.ForeColor = System.Drawing.Color.Red;
            this.errUserPass.Location = new System.Drawing.Point(11, 386);
            this.errUserPass.Name = "errUserPass";
            this.errUserPass.Size = new System.Drawing.Size(28, 12);
            this.errUserPass.TabIndex = 13;
            this.errUserPass.Text = "*error";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(10, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Username";
            // 
            // txtUserUname
            // 
            this.txtUserUname.BackColor = System.Drawing.Color.White;
            this.txtUserUname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUserUname.BorderRadius = 10;
            this.txtUserUname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserUname.DefaultText = "";
            this.txtUserUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserUname.DisabledState.Parent = this.txtUserUname;
            this.txtUserUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserUname.FocusedState.Parent = this.txtUserUname;
            this.txtUserUname.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUserUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserUname.HoverState.Parent = this.txtUserUname;
            this.txtUserUname.Location = new System.Drawing.Point(13, 292);
            this.txtUserUname.Name = "txtUserUname";
            this.txtUserUname.PasswordChar = '\0';
            this.txtUserUname.PlaceholderText = "";
            this.txtUserUname.SelectedText = "";
            this.txtUserUname.ShadowDecoration.Parent = this.txtUserUname;
            this.txtUserUname.Size = new System.Drawing.Size(216, 28);
            this.txtUserUname.TabIndex = 8;
            // 
            // errUserUname
            // 
            this.errUserUname.AutoSize = true;
            this.errUserUname.BackColor = System.Drawing.Color.White;
            this.errUserUname.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUserUname.ForeColor = System.Drawing.Color.Red;
            this.errUserUname.Location = new System.Drawing.Point(11, 318);
            this.errUserUname.Name = "errUserUname";
            this.errUserUname.Size = new System.Drawing.Size(28, 12);
            this.errUserUname.TabIndex = 10;
            this.errUserUname.Text = "*error";
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackColor = System.Drawing.Color.White;
            this.pbxProfile.Image = global::MainUI.Properties.Resources.user;
            this.pbxProfile.ImageRotate = 0F;
            this.pbxProfile.Location = new System.Drawing.Point(13, 48);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxProfile.ShadowDecoration.Parent = this.pbxProfile;
            this.pbxProfile.Size = new System.Drawing.Size(64, 64);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfile.TabIndex = 7;
            this.pbxProfile.TabStop = false;
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnUserCancel.BorderRadius = 6;
            this.btnUserCancel.CheckedState.Parent = this.btnUserCancel;
            this.btnUserCancel.CustomImages.Parent = this.btnUserCancel;
            this.btnUserCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserCancel.DisabledState.Parent = this.btnUserCancel;
            this.btnUserCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnUserCancel.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancel.ForeColor = System.Drawing.Color.Red;
            this.btnUserCancel.HoverState.Parent = this.btnUserCancel;
            this.btnUserCancel.Location = new System.Drawing.Point(70, 434);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.ShadowDecoration.Parent = this.btnUserCancel;
            this.btnUserCancel.Size = new System.Drawing.Size(72, 28);
            this.btnUserCancel.TabIndex = 5;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSave.BorderRadius = 6;
            this.btnUserSave.CheckedState.Parent = this.btnUserSave;
            this.btnUserSave.CustomImages.Parent = this.btnUserSave;
            this.btnUserSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserSave.DisabledState.Parent = this.btnUserSave;
            this.btnUserSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUserSave.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSave.ForeColor = System.Drawing.Color.White;
            this.btnUserSave.HoverState.Parent = this.btnUserSave;
            this.btnUserSave.Location = new System.Drawing.Point(158, 434);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.ShadowDecoration.Parent = this.btnUserSave;
            this.btnUserSave.Size = new System.Drawing.Size(72, 28);
            this.btnUserSave.TabIndex = 4;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.White;
            this.txtFullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFullname.BorderRadius = 10;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.DefaultText = "";
            this.txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.DisabledState.Parent = this.txtFullname;
            this.txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname.FocusedState.Parent = this.txtFullname;
            this.txtFullname.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname.HoverState.Parent = this.txtFullname;
            this.txtFullname.Location = new System.Drawing.Point(94, 76);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.PlaceholderText = "";
            this.txtFullname.SelectedText = "";
            this.txtFullname.ShadowDecoration.Parent = this.txtFullname;
            this.txtFullname.Size = new System.Drawing.Size(135, 28);
            this.txtFullname.TabIndex = 1;
            // 
            // errFullname
            // 
            this.errFullname.AutoSize = true;
            this.errFullname.BackColor = System.Drawing.Color.White;
            this.errFullname.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFullname.ForeColor = System.Drawing.Color.Red;
            this.errFullname.Location = new System.Drawing.Point(92, 102);
            this.errFullname.Name = "errFullname";
            this.errFullname.Size = new System.Drawing.Size(28, 12);
            this.errFullname.TabIndex = 6;
            this.errFullname.Text = "*error";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(93, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fullname";
            // 
            // pgConnection
            // 
            this.pgConnection.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pgConnection.Controls.Add(this.guna2GroupBox1);
            this.pgConnection.Location = new System.Drawing.Point(124, 4);
            this.pgConnection.Margin = new System.Windows.Forms.Padding(0);
            this.pgConnection.Name = "pgConnection";
            this.pgConnection.Size = new System.Drawing.Size(244, 475);
            this.pgConnection.TabIndex = 2;
            this.pgConnection.Text = "Connection";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox1.BorderRadius = 6;
            this.guna2GroupBox1.Controls.Add(this.errPort);
            this.guna2GroupBox1.Controls.Add(this.errUsername);
            this.guna2GroupBox1.Controls.Add(this.errPassword);
            this.guna2GroupBox1.Controls.Add(this.btnCancel);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.btnTestConnection);
            this.guna2GroupBox1.Controls.Add(this.errDatabase);
            this.guna2GroupBox1.Controls.Add(this.errServer);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.tglSecurity);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txtPort);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.txtPassword);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txtUsername);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.txtDatabase);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtServer);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Enabled = false;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(244, 475);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Connectivity Setting";
            // 
            // errPort
            // 
            this.errPort.AutoSize = true;
            this.errPort.BackColor = System.Drawing.Color.White;
            this.errPort.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPort.ForeColor = System.Drawing.Color.Red;
            this.errPort.Location = new System.Drawing.Point(10, 229);
            this.errPort.Name = "errPort";
            this.errPort.Size = new System.Drawing.Size(28, 12);
            this.errPort.TabIndex = 20;
            this.errPort.Text = "*error";
            // 
            // errUsername
            // 
            this.errUsername.AutoSize = true;
            this.errUsername.BackColor = System.Drawing.Color.White;
            this.errUsername.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsername.ForeColor = System.Drawing.Color.Red;
            this.errUsername.Location = new System.Drawing.Point(10, 301);
            this.errUsername.Name = "errUsername";
            this.errUsername.Size = new System.Drawing.Size(28, 12);
            this.errUsername.TabIndex = 19;
            this.errUsername.Text = "*error";
            // 
            // errPassword
            // 
            this.errPassword.AutoSize = true;
            this.errPassword.BackColor = System.Drawing.Color.White;
            this.errPassword.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPassword.ForeColor = System.Drawing.Color.Red;
            this.errPassword.Location = new System.Drawing.Point(10, 363);
            this.errPassword.Name = "errPassword";
            this.errPassword.Size = new System.Drawing.Size(28, 12);
            this.errPassword.TabIndex = 18;
            this.errPassword.Text = "*error";
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
            this.btnCancel.Location = new System.Drawing.Point(71, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 6;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(159, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errDatabase
            // 
            this.errDatabase.AutoSize = true;
            this.errDatabase.BackColor = System.Drawing.Color.White;
            this.errDatabase.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDatabase.ForeColor = System.Drawing.Color.Red;
            this.errDatabase.Location = new System.Drawing.Point(10, 159);
            this.errDatabase.Name = "errDatabase";
            this.errDatabase.Size = new System.Drawing.Size(28, 12);
            this.errDatabase.TabIndex = 17;
            this.errDatabase.Text = "*error";
            // 
            // errServer
            // 
            this.errServer.AutoSize = true;
            this.errServer.BackColor = System.Drawing.Color.White;
            this.errServer.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errServer.ForeColor = System.Drawing.Color.Red;
            this.errServer.Location = new System.Drawing.Point(10, 97);
            this.errServer.Name = "errServer";
            this.errServer.Size = new System.Drawing.Size(28, 12);
            this.errServer.TabIndex = 7;
            this.errServer.Text = "*error";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(166, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Security";
            // 
            // tglSecurity
            // 
            this.tglSecurity.BackColor = System.Drawing.Color.White;
            this.tglSecurity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglSecurity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglSecurity.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglSecurity.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglSecurity.CheckedState.Parent = this.tglSecurity;
            this.tglSecurity.Location = new System.Drawing.Point(169, 201);
            this.tglSecurity.Name = "tglSecurity";
            this.tglSecurity.ShadowDecoration.Parent = this.tglSecurity;
            this.tglSecurity.Size = new System.Drawing.Size(60, 28);
            this.tglSecurity.TabIndex = 15;
            this.tglSecurity.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglSecurity.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglSecurity.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglSecurity.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglSecurity.UncheckedState.Parent = this.tglSecurity;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(10, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPort.BorderRadius = 10;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultText = "";
            this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.DisabledState.Parent = this.txtPort;
            this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.FocusedState.Parent = this.txtPort;
            this.txtPort.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.HoverState.Parent = this.txtPort;
            this.txtPort.Location = new System.Drawing.Point(13, 201);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PlaceholderText = "";
            this.txtPort.SelectedText = "";
            this.txtPort.ShadowDecoration.Parent = this.txtPort;
            this.txtPort.Size = new System.Drawing.Size(140, 28);
            this.txtPort.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(10, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(13, 334);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(10, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(13, 272);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.White;
            this.txtDatabase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtDatabase.BorderRadius = 10;
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.DefaultText = "";
            this.txtDatabase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDatabase.DisabledState.Parent = this.txtDatabase;
            this.txtDatabase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDatabase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDatabase.FocusedState.Parent = this.txtDatabase;
            this.txtDatabase.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtDatabase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDatabase.HoverState.Parent = this.txtDatabase;
            this.txtDatabase.Location = new System.Drawing.Point(13, 130);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PlaceholderText = "";
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.ShadowDecoration.Parent = this.txtDatabase;
            this.txtDatabase.Size = new System.Drawing.Size(216, 28);
            this.txtDatabase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtServer.BorderRadius = 10;
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.DefaultText = "";
            this.txtServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServer.DisabledState.Parent = this.txtServer;
            this.txtServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServer.FocusedState.Parent = this.txtServer;
            this.txtServer.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServer.HoverState.Parent = this.txtServer;
            this.txtServer.Location = new System.Drawing.Point(13, 68);
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PlaceholderText = "";
            this.txtServer.SelectedText = "";
            this.txtServer.ShadowDecoration.Parent = this.txtServer;
            this.txtServer.Size = new System.Drawing.Size(216, 28);
            this.txtServer.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(352, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(388, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.tabSettings.ResumeLayout(false);
            this.pgFarm.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.pgProfile.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.pgConnection.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFarmName;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label errorFarmName;
        private Guna.UI2.WinForms.Guna2Button btnTestConnection;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnFarmCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveFarm;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label errPort;
        private System.Windows.Forms.Label errUsername;
        private System.Windows.Forms.Label errPassword;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label errDatabase;
        private System.Windows.Forms.Label errServer;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglSecurity;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPort;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDatabase;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtServer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label errAddr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label errContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label errUserPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label errUserUname;
        private Guna.UI2.WinForms.Guna2Button btnUserCancel;
        private Guna.UI2.WinForms.Guna2Button btnUserSave;
        private System.Windows.Forms.Label errFullname;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnClose;
        public Guna.UI2.WinForms.Guna2TabControl tabSettings;
        public System.Windows.Forms.TabPage pgFarm;
        public System.Windows.Forms.TabPage pgProfile;
        public System.Windows.Forms.TabPage pgConnection;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        public Guna.UI2.WinForms.Guna2TextBox txtContact;
        public Guna.UI2.WinForms.Guna2TextBox txtUserPass;
        public Guna.UI2.WinForms.Guna2TextBox txtUserUname;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbxProfile;
        public Guna.UI2.WinForms.Guna2TextBox txtFullname;
    }
}