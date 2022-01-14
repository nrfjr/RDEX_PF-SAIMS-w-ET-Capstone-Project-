
namespace MainUI.Dialog
{
    partial class Withdrawal_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawal_History));
            this.labelTitle = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dgvWdrawContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRevertWdraw = new FontAwesome.Sharp.IconMenuItem();
            this.datagridWdraw = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wdraw_revert = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel94 = new System.Windows.Forms.Panel();
            this.label119 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.dtpToWdraw = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFromWdraw = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label86 = new System.Windows.Forms.Label();
            this.panel84 = new System.Windows.Forms.Panel();
            this.btnLoadWdraw = new FontAwesome.Sharp.IconButton();
            this.panel80 = new System.Windows.Forms.Panel();
            this.label82 = new System.Windows.Forms.Label();
            this.txtWdrawSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvWdrawContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridWdraw)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(406, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Withdrawal History";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // dgvWdrawContext
            // 
            this.dgvWdrawContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRevertWdraw});
            this.dgvWdrawContext.Name = "dgvUserContext";
            this.dgvWdrawContext.Size = new System.Drawing.Size(112, 26);
            // 
            // btnRevertWdraw
            // 
            this.btnRevertWdraw.BackColor = System.Drawing.Color.White;
            this.btnRevertWdraw.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevertWdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRevertWdraw.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnRevertWdraw.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRevertWdraw.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRevertWdraw.Name = "btnRevertWdraw";
            this.btnRevertWdraw.Size = new System.Drawing.Size(111, 22);
            this.btnRevertWdraw.Text = "Revert";
            this.btnRevertWdraw.Click += new System.EventHandler(this.btnRevertWdraw_Click);
            // 
            // datagridWdraw
            // 
            this.datagridWdraw.AllowUserToAddRows = false;
            this.datagridWdraw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.datagridWdraw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridWdraw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridWdraw.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridWdraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridWdraw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridWdraw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridWdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridWdraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column10,
            this.wdraw_revert});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridWdraw.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridWdraw.EnableHeadersVisualStyles = false;
            this.datagridWdraw.Location = new System.Drawing.Point(6, 106);
            this.datagridWdraw.Name = "datagridWdraw";
            this.datagridWdraw.ReadOnly = true;
            this.datagridWdraw.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.datagridWdraw.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridWdraw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridWdraw.Size = new System.Drawing.Size(934, 434);
            this.datagridWdraw.TabIndex = 6;
            this.datagridWdraw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridWdraw_CellContentClick);
            this.datagridWdraw.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridWdraw_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "WithdrawID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 86;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Category";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 86;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Feeds Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 91;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Withdrawal Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 57;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Withdrawal Date";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // wdraw_revert
            // 
            this.wdraw_revert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wdraw_revert.HeaderText = "Revert";
            this.wdraw_revert.Image = global::MainUI.Properties.Resources.undo;
            this.wdraw_revert.Name = "wdraw_revert";
            this.wdraw_revert.ReadOnly = true;
            this.wdraw_revert.Width = 51;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Revert";
            this.dataGridViewImageColumn1.Image = global::MainUI.Properties.Resources.undo;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(913, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.panel94);
            this.guna2Panel1.Controls.Add(this.label119);
            this.guna2Panel1.Controls.Add(this.label121);
            this.guna2Panel1.Controls.Add(this.dtpToWdraw);
            this.guna2Panel1.Controls.Add(this.dtpFromWdraw);
            this.guna2Panel1.Controls.Add(this.label86);
            this.guna2Panel1.Controls.Add(this.panel84);
            this.guna2Panel1.Controls.Add(this.btnLoadWdraw);
            this.guna2Panel1.Controls.Add(this.panel80);
            this.guna2Panel1.Controls.Add(this.label82);
            this.guna2Panel1.Controls.Add(this.txtWdrawSearch);
            this.guna2Panel1.Location = new System.Drawing.Point(6, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(934, 75);
            this.guna2Panel1.TabIndex = 7;
            // 
            // panel94
            // 
            this.panel94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel94.Location = new System.Drawing.Point(194, 4);
            this.panel94.Name = "panel94";
            this.panel94.Size = new System.Drawing.Size(1, 69);
            this.panel94.TabIndex = 139;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(22, 46);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(20, 15);
            this.label119.TabIndex = 138;
            this.label119.Text = "To";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(7, 12);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(34, 15);
            this.label121.TabIndex = 137;
            this.label121.Text = "From";
            // 
            // dtpToWdraw
            // 
            this.dtpToWdraw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpToWdraw.BorderRadius = 6;
            this.dtpToWdraw.BorderThickness = 1;
            this.dtpToWdraw.CheckedState.Parent = this.dtpToWdraw;
            this.dtpToWdraw.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpToWdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToWdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpToWdraw.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToWdraw.HoverState.Parent = this.dtpToWdraw;
            this.dtpToWdraw.Location = new System.Drawing.Point(49, 40);
            this.dtpToWdraw.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToWdraw.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToWdraw.Name = "dtpToWdraw";
            this.dtpToWdraw.ShadowDecoration.Parent = this.dtpToWdraw;
            this.dtpToWdraw.Size = new System.Drawing.Size(129, 30);
            this.dtpToWdraw.TabIndex = 136;
            this.dtpToWdraw.Value = new System.DateTime(2022, 1, 4, 9, 7, 16, 2);
            // 
            // dtpFromWdraw
            // 
            this.dtpFromWdraw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpFromWdraw.BorderRadius = 6;
            this.dtpFromWdraw.BorderThickness = 1;
            this.dtpFromWdraw.CheckedState.Parent = this.dtpFromWdraw;
            this.dtpFromWdraw.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFromWdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromWdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpFromWdraw.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromWdraw.HoverState.Parent = this.dtpFromWdraw;
            this.dtpFromWdraw.Location = new System.Drawing.Point(49, 5);
            this.dtpFromWdraw.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromWdraw.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromWdraw.Name = "dtpFromWdraw";
            this.dtpFromWdraw.ShadowDecoration.Parent = this.dtpFromWdraw;
            this.dtpFromWdraw.Size = new System.Drawing.Size(129, 30);
            this.dtpFromWdraw.TabIndex = 135;
            this.dtpFromWdraw.Value = new System.DateTime(2022, 1, 4, 9, 7, 16, 2);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(465, 4);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(46, 15);
            this.label86.TabIndex = 134;
            this.label86.Text = "Refresh";
            // 
            // panel84
            // 
            this.panel84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel84.Location = new System.Drawing.Point(537, 4);
            this.panel84.Name = "panel84";
            this.panel84.Size = new System.Drawing.Size(1, 69);
            this.panel84.TabIndex = 133;
            // 
            // btnLoadWdraw
            // 
            this.btnLoadWdraw.BackColor = System.Drawing.Color.White;
            this.btnLoadWdraw.FlatAppearance.BorderSize = 0;
            this.btnLoadWdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadWdraw.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLoadWdraw.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnLoadWdraw.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLoadWdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadWdraw.IconSize = 35;
            this.btnLoadWdraw.Location = new System.Drawing.Point(444, 20);
            this.btnLoadWdraw.Name = "btnLoadWdraw";
            this.btnLoadWdraw.Size = new System.Drawing.Size(87, 54);
            this.btnLoadWdraw.TabIndex = 132;
            this.btnLoadWdraw.Text = "Load Withdrawal";
            this.btnLoadWdraw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadWdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadWdraw.UseVisualStyleBackColor = false;
            this.btnLoadWdraw.Click += new System.EventHandler(this.btnLoadWdraw_Click);
            // 
            // panel80
            // 
            this.panel80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel80.Location = new System.Drawing.Point(437, 4);
            this.panel80.Name = "panel80";
            this.panel80.Size = new System.Drawing.Size(1, 69);
            this.panel80.TabIndex = 126;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(268, 4);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(103, 15);
            this.label82.TabIndex = 128;
            this.label82.Text = "Search Withdrawal";
            // 
            // txtWdrawSearch
            // 
            this.txtWdrawSearch.BackColor = System.Drawing.Color.White;
            this.txtWdrawSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtWdrawSearch.BorderRadius = 10;
            this.txtWdrawSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWdrawSearch.DefaultText = "";
            this.txtWdrawSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWdrawSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWdrawSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWdrawSearch.DisabledState.Parent = this.txtWdrawSearch;
            this.txtWdrawSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWdrawSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWdrawSearch.FocusedState.Parent = this.txtWdrawSearch;
            this.txtWdrawSearch.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWdrawSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtWdrawSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWdrawSearch.HoverState.Parent = this.txtWdrawSearch;
            this.txtWdrawSearch.Location = new System.Drawing.Point(208, 29);
            this.txtWdrawSearch.Name = "txtWdrawSearch";
            this.txtWdrawSearch.PasswordChar = '\0';
            this.txtWdrawSearch.PlaceholderText = "Search here then hit enter key...";
            this.txtWdrawSearch.SelectedText = "";
            this.txtWdrawSearch.ShadowDecoration.Parent = this.txtWdrawSearch;
            this.txtWdrawSearch.Size = new System.Drawing.Size(216, 28);
            this.txtWdrawSearch.TabIndex = 127;
            // 
            // Withdrawal_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.datagridWdraw);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Withdrawal_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal_History";
            this.dgvWdrawContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridWdraw)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.ContextMenuStrip dgvWdrawContext;
        private FontAwesome.Sharp.IconMenuItem btnRevertWdraw;
        private System.Windows.Forms.DataGridView datagridWdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn wdraw_revert;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel94;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label121;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToWdraw;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromWdraw;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Panel panel84;
        private FontAwesome.Sharp.IconButton btnLoadWdraw;
        private System.Windows.Forms.Panel panel80;
        private System.Windows.Forms.Label label82;
        private Guna.UI2.WinForms.Guna2TextBox txtWdrawSearch;
    }
}