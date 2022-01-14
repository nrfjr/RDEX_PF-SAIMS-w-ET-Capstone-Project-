
namespace MainUI.Dialog
{
    partial class Plan_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan_Entry));
            this.labelTransaction = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cmbPond = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtCropNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFarmName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateStocked = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpHarvest = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFryStocked = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductionNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDOC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.lblBiomass = new System.Windows.Forms.Label();
            this.lblFeedsRequired = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errFryStock = new System.Windows.Forms.Label();
            this.errProdNum = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCropNumber)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(9, 13);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(261, 39);
            this.labelTransaction.TabIndex = 64;
            this.labelTransaction.Text = "Create Pond Entry";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cmbPond
            // 
            this.cmbPond.BackColor = System.Drawing.Color.Transparent;
            this.cmbPond.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbPond.BorderRadius = 6;
            this.cmbPond.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPond.Enabled = false;
            this.cmbPond.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPond.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPond.FocusedState.Parent = this.cmbPond;
            this.cmbPond.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbPond.HoverState.Parent = this.cmbPond;
            this.cmbPond.ItemHeight = 24;
            this.cmbPond.ItemsAppearance.Parent = this.cmbPond;
            this.cmbPond.Location = new System.Drawing.Point(490, 127);
            this.cmbPond.Name = "cmbPond";
            this.cmbPond.ShadowDecoration.Parent = this.cmbPond;
            this.cmbPond.Size = new System.Drawing.Size(123, 30);
            this.cmbPond.TabIndex = 105;
            this.cmbPond.SelectionChangeCommitted += new System.EventHandler(this.cmbPond_SelectionChangeCommitted);
            this.cmbPond.TextChanged += new System.EventHandler(this.cmbPond_TextChanged);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label101.Location = new System.Drawing.Point(487, 108);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(35, 15);
            this.label101.TabIndex = 104;
            this.label101.Text = "Pond";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 107;
            this.label8.Text = "Pond Entry Details";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2Separator1.Location = new System.Drawing.Point(17, 66);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(596, 32);
            this.guna2Separator1.TabIndex = 106;
            // 
            // txtCropNumber
            // 
            this.txtCropNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtCropNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCropNumber.BorderRadius = 6;
            this.txtCropNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCropNumber.DisabledState.Parent = this.txtCropNumber;
            this.txtCropNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCropNumber.FocusedState.Parent = this.txtCropNumber;
            this.txtCropNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCropNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCropNumber.Location = new System.Drawing.Point(415, 127);
            this.txtCropNumber.Name = "txtCropNumber";
            this.txtCropNumber.ShadowDecoration.Parent = this.txtCropNumber;
            this.txtCropNumber.Size = new System.Drawing.Size(59, 30);
            this.txtCropNumber.TabIndex = 108;
            this.txtCropNumber.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCropNumber.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(413, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 109;
            this.label1.Text = "Crop No.";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblArea.Location = new System.Drawing.Point(489, 156);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 15);
            this.lblArea.TabIndex = 110;
            this.lblArea.Text = "Area: 0,000";
            // 
            // lblFarmName
            // 
            this.lblFarmName.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblFarmName.Location = new System.Drawing.Point(23, 130);
            this.lblFarmName.Name = "lblFarmName";
            this.lblFarmName.Size = new System.Drawing.Size(310, 19);
            this.lblFarmName.TabIndex = 111;
            this.lblFarmName.Text = "Farm Branch Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 112;
            this.label4.Text = "Farm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(207, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 113;
            this.label5.Text = "Date Stocked :";
            // 
            // dtpDateStocked
            // 
            this.dtpDateStocked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpDateStocked.BorderRadius = 6;
            this.dtpDateStocked.BorderThickness = 1;
            this.dtpDateStocked.CheckedState.Parent = this.dtpDateStocked;
            this.dtpDateStocked.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDateStocked.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateStocked.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStocked.HoverState.Parent = this.dtpDateStocked;
            this.dtpDateStocked.Location = new System.Drawing.Point(210, 213);
            this.dtpDateStocked.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateStocked.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateStocked.Name = "dtpDateStocked";
            this.dtpDateStocked.ShadowDecoration.Parent = this.dtpDateStocked;
            this.dtpDateStocked.Size = new System.Drawing.Size(123, 30);
            this.dtpDateStocked.TabIndex = 114;
            this.dtpDateStocked.Value = new System.DateTime(2021, 12, 20, 17, 57, 23, 413);
            // 
            // dtpHarvest
            // 
            this.dtpHarvest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpHarvest.BorderRadius = 6;
            this.dtpHarvest.BorderThickness = 1;
            this.dtpHarvest.CheckedState.Parent = this.dtpHarvest;
            this.dtpHarvest.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpHarvest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHarvest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHarvest.HoverState.Parent = this.dtpHarvest;
            this.dtpHarvest.Location = new System.Drawing.Point(351, 213);
            this.dtpHarvest.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHarvest.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHarvest.Name = "dtpHarvest";
            this.dtpHarvest.ShadowDecoration.Parent = this.dtpHarvest;
            this.dtpHarvest.Size = new System.Drawing.Size(123, 30);
            this.dtpHarvest.TabIndex = 116;
            this.dtpHarvest.Value = new System.DateTime(2021, 12, 20, 17, 57, 23, 413);
            this.dtpHarvest.ValueChanged += new System.EventHandler(this.dtpHarvest_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(348, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 115;
            this.label6.Text = "Date of Harvest :";
            // 
            // txtFryStocked
            // 
            this.txtFryStocked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFryStocked.BorderRadius = 6;
            this.txtFryStocked.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFryStocked.DefaultText = "";
            this.txtFryStocked.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFryStocked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFryStocked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFryStocked.DisabledState.Parent = this.txtFryStocked;
            this.txtFryStocked.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFryStocked.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFryStocked.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFryStocked.FocusedState.Parent = this.txtFryStocked;
            this.txtFryStocked.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtFryStocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFryStocked.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFryStocked.HoverState.Parent = this.txtFryStocked;
            this.txtFryStocked.Location = new System.Drawing.Point(17, 213);
            this.txtFryStocked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFryStocked.Name = "txtFryStocked";
            this.txtFryStocked.PasswordChar = '\0';
            this.txtFryStocked.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFryStocked.PlaceholderText = "0000000";
            this.txtFryStocked.SelectedText = "";
            this.txtFryStocked.ShadowDecoration.Parent = this.txtFryStocked;
            this.txtFryStocked.Size = new System.Drawing.Size(175, 30);
            this.txtFryStocked.TabIndex = 117;
            this.txtFryStocked.TextChanged += new System.EventHandler(this.txtFryStocked_TextChanged);
            this.txtFryStocked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFryStocked_KeyPress);
            this.txtFryStocked.Validated += new System.EventHandler(this.txtFryStocked_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(14, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 118;
            this.label7.Text = "Total Fry Stock  (≈ pcs.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(412, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 120;
            this.label9.Text = "Production No.:";
            // 
            // txtProductionNumber
            // 
            this.txtProductionNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtProductionNumber.BorderRadius = 6;
            this.txtProductionNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductionNumber.DefaultText = "";
            this.txtProductionNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtProductionNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductionNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductionNumber.DisabledState.Parent = this.txtProductionNumber;
            this.txtProductionNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductionNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtProductionNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductionNumber.FocusedState.Parent = this.txtProductionNumber;
            this.txtProductionNumber.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtProductionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtProductionNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductionNumber.HoverState.Parent = this.txtProductionNumber;
            this.txtProductionNumber.Location = new System.Drawing.Point(415, 29);
            this.txtProductionNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductionNumber.Name = "txtProductionNumber";
            this.txtProductionNumber.PasswordChar = '\0';
            this.txtProductionNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductionNumber.PlaceholderText = "0000000";
            this.txtProductionNumber.SelectedText = "";
            this.txtProductionNumber.ShadowDecoration.Parent = this.txtProductionNumber;
            this.txtProductionNumber.Size = new System.Drawing.Size(198, 30);
            this.txtProductionNumber.TabIndex = 119;
            this.txtProductionNumber.Click += new System.EventHandler(this.txtProductionNumber_Click);
            this.txtProductionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFryStocked_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(488, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 121;
            this.label10.Text = "Days of Culture";
            // 
            // lblDOC
            // 
            this.lblDOC.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblDOC.Location = new System.Drawing.Point(487, 220);
            this.lblDOC.Name = "lblDOC";
            this.lblDOC.Size = new System.Drawing.Size(121, 19);
            this.lblDOC.TabIndex = 122;
            this.lblDOC.Text = "0";
            this.lblDOC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(203, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 15);
            this.label12.TabIndex = 123;
            this.label12.Text = "Stock Density (pcs. / m²)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label13.Location = new System.Drawing.Point(348, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 124;
            this.label13.Text = "Biomass (g / m²)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label14.Location = new System.Drawing.Point(487, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 125;
            this.label14.Text = "Feeds Required";
            // 
            // lblSD
            // 
            this.lblSD.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblSD.Location = new System.Drawing.Point(206, 284);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(127, 19);
            this.lblSD.TabIndex = 127;
            this.lblSD.Text = "0";
            this.lblSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBiomass
            // 
            this.lblBiomass.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiomass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblBiomass.Location = new System.Drawing.Point(351, 284);
            this.lblBiomass.Name = "lblBiomass";
            this.lblBiomass.Size = new System.Drawing.Size(123, 19);
            this.lblBiomass.TabIndex = 128;
            this.lblBiomass.Text = "0";
            this.lblBiomass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeedsRequired
            // 
            this.lblFeedsRequired.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedsRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblFeedsRequired.Location = new System.Drawing.Point(490, 284);
            this.lblFeedsRequired.Name = "lblFeedsRequired";
            this.lblFeedsRequired.Size = new System.Drawing.Size(123, 19);
            this.lblFeedsRequired.TabIndex = 129;
            this.lblFeedsRequired.Text = "0";
            this.lblFeedsRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
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
            this.btnCancel.Location = new System.Drawing.Point(454, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 131;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
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
            this.btnSave.Location = new System.Drawing.Point(541, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(207, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 1);
            this.panel1.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(351, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 1);
            this.panel2.TabIndex = 133;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(490, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 1);
            this.panel3.TabIndex = 134;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 1);
            this.panel5.TabIndex = 135;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(490, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 1);
            this.panel4.TabIndex = 135;
            // 
            // errFryStock
            // 
            this.errFryStock.AutoSize = true;
            this.errFryStock.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFryStock.ForeColor = System.Drawing.Color.Red;
            this.errFryStock.Location = new System.Drawing.Point(14, 242);
            this.errFryStock.Name = "errFryStock";
            this.errFryStock.Size = new System.Drawing.Size(34, 13);
            this.errFryStock.TabIndex = 136;
            this.errFryStock.Text = "*error";
            // 
            // errProdNum
            // 
            this.errProdNum.AutoSize = true;
            this.errProdNum.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errProdNum.ForeColor = System.Drawing.Color.Red;
            this.errProdNum.Location = new System.Drawing.Point(413, 58);
            this.errProdNum.Name = "errProdNum";
            this.errProdNum.Size = new System.Drawing.Size(34, 13);
            this.errProdNum.TabIndex = 137;
            this.errProdNum.Text = "*error";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel6.Location = new System.Drawing.Point(17, 156);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(316, 1);
            this.panel6.TabIndex = 138;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbSupplier.BorderRadius = 6;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.FocusedState.Parent = this.cmbSupplier;
            this.cmbSupplier.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbSupplier.HoverState.Parent = this.cmbSupplier;
            this.cmbSupplier.ItemHeight = 24;
            this.cmbSupplier.ItemsAppearance.Parent = this.cmbSupplier;
            this.cmbSupplier.Location = new System.Drawing.Point(16, 277);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.ShadowDecoration.Parent = this.cmbSupplier;
            this.cmbSupplier.Size = new System.Drawing.Size(176, 30);
            this.cmbSupplier.TabIndex = 139;
            this.cmbSupplier.TextChanged += new System.EventHandler(this.cmbSupplier_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(14, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 140;
            this.label2.Text = "Supplier";
            // 
            // Plan_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(634, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtProductionNumber);
            this.Controls.Add(this.errProdNum);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFeedsRequired);
            this.Controls.Add(this.lblBiomass);
            this.Controls.Add(this.lblSD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDOC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFryStocked);
            this.Controls.Add(this.dtpHarvest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateStocked);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFarmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCropNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cmbPond);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.errFryStock);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plan_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan_Entry";
            ((System.ComponentModel.ISupportInitialize)(this.txtCropNumber)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransaction;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label101;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFarmName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtFryStocked;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox txtProductionNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label errFryStock;
        private System.Windows.Forms.Label errProdNum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox cmbPond;
        public Guna.UI2.WinForms.Guna2NumericUpDown txtCropNumber;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpDateStocked;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpHarvest;
        public System.Windows.Forms.Label lblFeedsRequired;
        public System.Windows.Forms.Label lblBiomass;
        public System.Windows.Forms.Label lblSD;
        public Guna.UI2.WinForms.Guna2ComboBox cmbSupplier;
        protected System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblDOC;
        public System.Windows.Forms.Label lblArea;
    }
}