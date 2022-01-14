
namespace MainUI.Dialog
{
    partial class Stock_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Management));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.cmbFType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelFType = new System.Windows.Forms.Label();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errQty = new System.Windows.Forms.Label();
            this.cmbUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsume = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errConsume = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRestock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRefNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errRefNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btnCancel.Location = new System.Drawing.Point(213, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 70;
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
            this.btnSave.Location = new System.Drawing.Point(300, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Stock Details";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 76);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(355, 32);
            this.guna2Separator1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Item Name";
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(10, 13);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(205, 39);
            this.labelTransaction.TabIndex = 63;
            this.labelTransaction.Text = "Manage Stock";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbCategory.BorderRadius = 6;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.ItemHeight = 24;
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(213, 138);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(159, 30);
            this.cmbCategory.TabIndex = 103;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            this.cmbCategory.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label101.Location = new System.Drawing.Point(210, 119);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(53, 15);
            this.label101.TabIndex = 102;
            this.label101.Text = "Category";
            // 
            // cmbFType
            // 
            this.cmbFType.BackColor = System.Drawing.Color.Transparent;
            this.cmbFType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbFType.BorderRadius = 6;
            this.cmbFType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFType.FocusedState.Parent = this.cmbFType;
            this.cmbFType.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbFType.HoverState.Parent = this.cmbFType;
            this.cmbFType.ItemHeight = 24;
            this.cmbFType.ItemsAppearance.Parent = this.cmbFType;
            this.cmbFType.Location = new System.Drawing.Point(213, 208);
            this.cmbFType.Name = "cmbFType";
            this.cmbFType.ShadowDecoration.Parent = this.cmbFType;
            this.cmbFType.Size = new System.Drawing.Size(159, 30);
            this.cmbFType.TabIndex = 105;
            this.cmbFType.TextChanged += new System.EventHandler(this.cmbFType_TextChanged);
            // 
            // labelFType
            // 
            this.labelFType.AutoSize = true;
            this.labelFType.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelFType.Location = new System.Drawing.Point(210, 189);
            this.labelFType.Name = "labelFType";
            this.labelFType.Size = new System.Drawing.Size(65, 15);
            this.labelFType.TabIndex = 104;
            this.labelFType.Text = "Feeds Type";
            // 
            // txtQty
            // 
            this.txtQty.BorderRadius = 6;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.Parent = this.txtQty;
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedState.Parent = this.txtQty;
            this.txtQty.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.HoverState.Parent = this.txtQty;
            this.txtQty.Location = new System.Drawing.Point(17, 277);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQty.PlaceholderText = "000.00";
            this.txtQty.SelectedText = "";
            this.txtQty.ShadowDecoration.Parent = this.txtQty;
            this.txtQty.Size = new System.Drawing.Size(268, 30);
            this.txtQty.TabIndex = 107;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(14, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Available Quantity";
            // 
            // errQty
            // 
            this.errQty.AutoSize = true;
            this.errQty.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errQty.ForeColor = System.Drawing.Color.Red;
            this.errQty.Location = new System.Drawing.Point(17, 307);
            this.errQty.Name = "errQty";
            this.errQty.Size = new System.Drawing.Size(34, 13);
            this.errQty.TabIndex = 108;
            this.errQty.Text = "*error";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbUnit.BorderRadius = 6;
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnit.FocusedState.Parent = this.cmbUnit;
            this.cmbUnit.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbUnit.HoverState.Parent = this.cmbUnit;
            this.cmbUnit.ItemHeight = 24;
            this.cmbUnit.ItemsAppearance.Parent = this.cmbUnit;
            this.cmbUnit.Location = new System.Drawing.Point(300, 277);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.ShadowDecoration.Parent = this.cmbUnit;
            this.cmbUnit.Size = new System.Drawing.Size(72, 30);
            this.cmbUnit.TabIndex = 110;
            this.cmbUnit.SelectionChangeCommitted += new System.EventHandler(this.cmbUnit_SelectionChangeCommitted);
            this.cmbUnit.TextChanged += new System.EventHandler(this.cmbUnit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(297, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 109;
            this.label5.Text = "Unit";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
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
            this.cmbSupplier.Location = new System.Drawing.Point(17, 347);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.ShadowDecoration.Parent = this.cmbSupplier;
            this.cmbSupplier.Size = new System.Drawing.Size(180, 30);
            this.cmbSupplier.TabIndex = 112;
            this.cmbSupplier.SelectedValueChanged += new System.EventHandler(this.cmbSupplier_SelectedValueChanged);
            this.cmbSupplier.TextChanged += new System.EventHandler(this.cmbSupplier_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(14, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Supplier";
            // 
            // txtConsume
            // 
            this.txtConsume.BorderRadius = 6;
            this.txtConsume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsume.DefaultText = "";
            this.txtConsume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsume.DisabledState.Parent = this.txtConsume;
            this.txtConsume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsume.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtConsume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsume.FocusedState.Parent = this.txtConsume;
            this.txtConsume.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtConsume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtConsume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsume.HoverState.Parent = this.txtConsume;
            this.txtConsume.Location = new System.Drawing.Point(213, 347);
            this.txtConsume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsume.Name = "txtConsume";
            this.txtConsume.PasswordChar = '\0';
            this.txtConsume.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtConsume.PlaceholderText = "000";
            this.txtConsume.SelectedText = "";
            this.txtConsume.ShadowDecoration.Parent = this.txtConsume;
            this.txtConsume.Size = new System.Drawing.Size(159, 30);
            this.txtConsume.TabIndex = 114;
            this.txtConsume.TextChanged += new System.EventHandler(this.txtConsume_TextChanged);
            this.txtConsume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtConsume.Validated += new System.EventHandler(this.txtConsume_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(213, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 113;
            this.label7.Text = "Average Consumption";
            // 
            // errConsume
            // 
            this.errConsume.AutoSize = true;
            this.errConsume.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errConsume.ForeColor = System.Drawing.Color.Red;
            this.errConsume.Location = new System.Drawing.Point(213, 377);
            this.errConsume.Name = "errConsume";
            this.errConsume.Size = new System.Drawing.Size(34, 13);
            this.errConsume.TabIndex = 115;
            this.errConsume.Text = "*error";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(17, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 116;
            this.label10.Text = "Restock Point";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbItem.BorderRadius = 6;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbItem.FocusedState.Parent = this.cmbItem;
            this.cmbItem.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cmbItem.HoverState.Parent = this.cmbItem;
            this.cmbItem.ItemHeight = 24;
            this.cmbItem.ItemsAppearance.Parent = this.cmbItem;
            this.cmbItem.Location = new System.Drawing.Point(17, 208);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.ShadowDecoration.Parent = this.cmbItem;
            this.cmbItem.Size = new System.Drawing.Size(180, 30);
            this.cmbItem.TabIndex = 119;
            this.cmbItem.TextChanged += new System.EventHandler(this.cmbItem_TextChanged);
            // 
            // txtRestock
            // 
            this.txtRestock.BorderRadius = 6;
            this.txtRestock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestock.DefaultText = "";
            this.txtRestock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRestock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRestock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestock.DisabledState.Parent = this.txtRestock;
            this.txtRestock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestock.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRestock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestock.FocusedState.Parent = this.txtRestock;
            this.txtRestock.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtRestock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtRestock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestock.HoverState.Parent = this.txtRestock;
            this.txtRestock.Location = new System.Drawing.Point(17, 412);
            this.txtRestock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRestock.Name = "txtRestock";
            this.txtRestock.PasswordChar = '\0';
            this.txtRestock.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRestock.PlaceholderText = "0000";
            this.txtRestock.SelectedText = "";
            this.txtRestock.ShadowDecoration.Parent = this.txtRestock;
            this.txtRestock.Size = new System.Drawing.Size(180, 30);
            this.txtRestock.TabIndex = 117;
            this.txtRestock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtRefNum
            // 
            this.txtRefNum.BorderRadius = 6;
            this.txtRefNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefNum.DefaultText = "";
            this.txtRefNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRefNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefNum.DisabledState.Parent = this.txtRefNum;
            this.txtRefNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefNum.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefNum.FocusedState.Parent = this.txtRefNum;
            this.txtRefNum.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtRefNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtRefNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefNum.HoverState.Parent = this.txtRefNum;
            this.txtRefNum.Location = new System.Drawing.Point(17, 138);
            this.txtRefNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRefNum.Name = "txtRefNum";
            this.txtRefNum.PasswordChar = '\0';
            this.txtRefNum.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRefNum.PlaceholderText = "DR000000";
            this.txtRefNum.SelectedText = "";
            this.txtRefNum.ShadowDecoration.Parent = this.txtRefNum;
            this.txtRefNum.Size = new System.Drawing.Size(180, 30);
            this.txtRefNum.TabIndex = 121;
            this.txtRefNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(17, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "Reference Number";
            // 
            // errRefNum
            // 
            this.errRefNum.AutoSize = true;
            this.errRefNum.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errRefNum.ForeColor = System.Drawing.Color.Red;
            this.errRefNum.Location = new System.Drawing.Point(17, 168);
            this.errRefNum.Name = "errRefNum";
            this.errRefNum.Size = new System.Drawing.Size(34, 13);
            this.errRefNum.TabIndex = 122;
            this.errRefNum.Text = "*error";
            // 
            // Stock_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(393, 528);
            this.Controls.Add(this.txtRefNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errRefNum);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtRestock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtConsume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errConsume);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errQty);
            this.Controls.Add(this.cmbFType);
            this.Controls.Add(this.labelFType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTransaction);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errQty;
        private System.Windows.Forms.Label labelFType;
        private System.Windows.Forms.Label label101;
        public Guna.UI2.WinForms.Guna2TextBox txtConsume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errConsume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2ComboBox cmbUnit;
        public Guna.UI2.WinForms.Guna2ComboBox cmbFType;
        public Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        public Guna.UI2.WinForms.Guna2ComboBox cmbSupplier;
        public Guna.UI2.WinForms.Guna2ComboBox cmbItem;
        public Guna.UI2.WinForms.Guna2TextBox txtRestock;
        public Guna.UI2.WinForms.Guna2TextBox txtRefNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errRefNum;
    }
}