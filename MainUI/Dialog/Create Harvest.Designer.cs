
namespace MainUI.Dialog
{
    partial class Create_Harvest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Harvest));
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.rbtnFull = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnPartial = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblProdnum = new System.Windows.Forms.Label();
            this.lblHarvest = new System.Windows.Forms.Label();
            this.txtHarvestedQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.errHarvestedQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTotalStocked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblABW = new System.Windows.Forms.Label();
            this.lblDOC = new System.Windows.Forms.Label();
            this.lblSR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPond = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCropNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblKGS = new System.Windows.Forms.Label();
            this.lblPCS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnCancel.Location = new System.Drawing.Point(177, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 32);
            this.btnCancel.TabIndex = 169;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Location = new System.Drawing.Point(266, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 32);
            this.btnSave.TabIndex = 168;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(10, 15);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(294, 39);
            this.labelTransaction.TabIndex = 167;
            this.labelTransaction.Text = "Create Pond Harvest";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 171;
            this.label8.Text = "Pond Harvest Details";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2Separator1.Location = new System.Drawing.Point(17, 270);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(321, 37);
            this.guna2Separator1.TabIndex = 170;
            // 
            // rbtnFull
            // 
            this.rbtnFull.AutoSize = true;
            this.rbtnFull.Checked = true;
            this.rbtnFull.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnFull.CheckedState.BorderThickness = 0;
            this.rbtnFull.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnFull.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnFull.CheckedState.InnerOffset = -4;
            this.rbtnFull.FlatAppearance.BorderSize = 0;
            this.rbtnFull.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFull.Location = new System.Drawing.Point(61, 333);
            this.rbtnFull.Name = "rbtnFull";
            this.rbtnFull.Size = new System.Drawing.Size(85, 19);
            this.rbtnFull.TabIndex = 172;
            this.rbtnFull.TabStop = true;
            this.rbtnFull.Text = "Full Harvest";
            this.rbtnFull.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnFull.UncheckedState.BorderThickness = 2;
            this.rbtnFull.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnFull.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnFull.CheckedChanged += new System.EventHandler(this.rbtnFull_CheckedChanged);
            // 
            // rbtnPartial
            // 
            this.rbtnPartial.AutoSize = true;
            this.rbtnPartial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPartial.CheckedState.BorderThickness = 0;
            this.rbtnPartial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPartial.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPartial.CheckedState.InnerOffset = -4;
            this.rbtnPartial.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.rbtnPartial.Location = new System.Drawing.Point(205, 333);
            this.rbtnPartial.Name = "rbtnPartial";
            this.rbtnPartial.Size = new System.Drawing.Size(99, 19);
            this.rbtnPartial.TabIndex = 173;
            this.rbtnPartial.Text = "Partial Harvest";
            this.rbtnPartial.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPartial.UncheckedState.BorderThickness = 2;
            this.rbtnPartial.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPartial.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnPartial.CheckedChanged += new System.EventHandler(this.rbtnFull_CheckedChanged);
            // 
            // lblProdnum
            // 
            this.lblProdnum.AutoSize = true;
            this.lblProdnum.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblProdnum.Location = new System.Drawing.Point(14, 302);
            this.lblProdnum.Name = "lblProdnum";
            this.lblProdnum.Size = new System.Drawing.Size(199, 15);
            this.lblProdnum.TabIndex = 174;
            this.lblProdnum.Text = "Set Production No. 0000 sampling as:";
            // 
            // lblHarvest
            // 
            this.lblHarvest.AutoSize = true;
            this.lblHarvest.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarvest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblHarvest.Location = new System.Drawing.Point(14, 384);
            this.lblHarvest.Name = "lblHarvest";
            this.lblHarvest.Size = new System.Drawing.Size(148, 15);
            this.lblHarvest.TabIndex = 178;
            this.lblHarvest.Text = "Harvested Quantity  (≈ pcs.)";
            // 
            // txtHarvestedQty
            // 
            this.txtHarvestedQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtHarvestedQty.BorderRadius = 6;
            this.txtHarvestedQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarvestedQty.DefaultText = "";
            this.txtHarvestedQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarvestedQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarvestedQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarvestedQty.DisabledState.Parent = this.txtHarvestedQty;
            this.txtHarvestedQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarvestedQty.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtHarvestedQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarvestedQty.FocusedState.Parent = this.txtHarvestedQty;
            this.txtHarvestedQty.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtHarvestedQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtHarvestedQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarvestedQty.HoverState.Parent = this.txtHarvestedQty;
            this.txtHarvestedQty.Location = new System.Drawing.Point(17, 402);
            this.txtHarvestedQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHarvestedQty.Name = "txtHarvestedQty";
            this.txtHarvestedQty.PasswordChar = '\0';
            this.txtHarvestedQty.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtHarvestedQty.PlaceholderText = "0000000";
            this.txtHarvestedQty.SelectedText = "";
            this.txtHarvestedQty.ShadowDecoration.Parent = this.txtHarvestedQty;
            this.txtHarvestedQty.Size = new System.Drawing.Size(175, 30);
            this.txtHarvestedQty.TabIndex = 177;
            this.txtHarvestedQty.TextChanged += new System.EventHandler(this.txtHarvestedQty_TextChanged);
            this.txtHarvestedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarvestedQty_KeyPress);
            this.txtHarvestedQty.Validated += new System.EventHandler(this.txtHarvestedQty_Validated);
            // 
            // errHarvestedQty
            // 
            this.errHarvestedQty.AutoSize = true;
            this.errHarvestedQty.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errHarvestedQty.ForeColor = System.Drawing.Color.Red;
            this.errHarvestedQty.Location = new System.Drawing.Point(14, 431);
            this.errHarvestedQty.Name = "errHarvestedQty";
            this.errHarvestedQty.Size = new System.Drawing.Size(34, 13);
            this.errHarvestedQty.TabIndex = 179;
            this.errHarvestedQty.Text = "*error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 182;
            this.label1.Text = "Total Fry Stocked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 181;
            this.label2.Text = "Pond Sampling Details";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2Separator2.Location = new System.Drawing.Point(17, 68);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(321, 37);
            this.guna2Separator2.TabIndex = 180;
            // 
            // lblTotalStocked
            // 
            this.lblTotalStocked.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblTotalStocked.Location = new System.Drawing.Point(234, 127);
            this.lblTotalStocked.Name = "lblTotalStocked";
            this.lblTotalStocked.Size = new System.Drawing.Size(104, 19);
            this.lblTotalStocked.TabIndex = 183;
            this.lblTotalStocked.Text = "000,000";
            this.lblTotalStocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 184;
            this.label4.Text = "Actual Body Weight / Size (g/s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(42, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 185;
            this.label5.Text = "Days of Culture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(42, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 186;
            this.label6.Text = "Survival Rate ( % )";
            // 
            // lblABW
            // 
            this.lblABW.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblABW.Location = new System.Drawing.Point(234, 151);
            this.lblABW.Name = "lblABW";
            this.lblABW.Size = new System.Drawing.Size(104, 19);
            this.lblABW.TabIndex = 187;
            this.lblABW.Text = "00.00";
            this.lblABW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDOC
            // 
            this.lblDOC.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblDOC.Location = new System.Drawing.Point(234, 175);
            this.lblDOC.Name = "lblDOC";
            this.lblDOC.Size = new System.Drawing.Size(104, 19);
            this.lblDOC.TabIndex = 188;
            this.lblDOC.Text = "000";
            this.lblDOC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSR
            // 
            this.lblSR.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblSR.Location = new System.Drawing.Point(234, 199);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(104, 19);
            this.lblSR.TabIndex = 189;
            this.lblSR.Text = "000";
            this.lblSR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 190;
            this.label3.Text = "Pond";
            // 
            // lblPond
            // 
            this.lblPond.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblPond.Location = new System.Drawing.Point(234, 103);
            this.lblPond.Name = "lblPond";
            this.lblPond.Size = new System.Drawing.Size(104, 19);
            this.lblPond.TabIndex = 191;
            this.lblPond.Text = "Pond00";
            this.lblPond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(42, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 192;
            this.label9.Text = "Crop No.";
            // 
            // lblCropNo
            // 
            this.lblCropNo.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCropNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblCropNo.Location = new System.Drawing.Point(234, 225);
            this.lblCropNo.Name = "lblCropNo";
            this.lblCropNo.Size = new System.Drawing.Size(104, 19);
            this.lblCropNo.TabIndex = 193;
            this.lblCropNo.Text = "00";
            this.lblCropNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(286, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 194;
            this.label10.Text = "(kg/s)";
            // 
            // lblKGS
            // 
            this.lblKGS.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKGS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblKGS.Location = new System.Drawing.Point(266, 406);
            this.lblKGS.Name = "lblKGS";
            this.lblKGS.Size = new System.Drawing.Size(72, 19);
            this.lblKGS.TabIndex = 195;
            this.lblKGS.Text = "100,000";
            this.lblKGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPCS
            // 
            this.lblPCS.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblPCS.Location = new System.Drawing.Point(212, 406);
            this.lblPCS.Name = "lblPCS";
            this.lblPCS.Size = new System.Drawing.Size(55, 19);
            this.lblPCS.TabIndex = 197;
            this.lblPCS.Text = "1000";
            this.lblPCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label13.Location = new System.Drawing.Point(222, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 196;
            this.label13.Text = "(pc/g)";
            // 
            // Create_Harvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(358, 518);
            this.Controls.Add(this.lblPCS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblKGS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCropNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSR);
            this.Controls.Add(this.lblDOC);
            this.Controls.Add(this.lblABW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalStocked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.lblHarvest);
            this.Controls.Add(this.txtHarvestedQty);
            this.Controls.Add(this.errHarvestedQty);
            this.Controls.Add(this.lblProdnum);
            this.Controls.Add(this.rbtnPartial);
            this.Controls.Add(this.rbtnFull);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTransaction);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Harvest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Harvest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label labelTransaction;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        protected System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPartial;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnFull;
        private System.Windows.Forms.Label lblHarvest;
        public Guna.UI2.WinForms.Guna2TextBox txtHarvestedQty;
        private System.Windows.Forms.Label errHarvestedQty;
        private System.Windows.Forms.Label lblProdnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public System.Windows.Forms.Label lblSR;
        public System.Windows.Forms.Label lblDOC;
        public System.Windows.Forms.Label lblABW;
        public System.Windows.Forms.Label lblTotalStocked;
        public System.Windows.Forms.Label lblPond;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblCropNo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblKGS;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblPCS;
        private System.Windows.Forms.Label label13;
    }
}