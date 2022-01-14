
namespace MainUI.Dialog
{
    partial class Invoice_Printer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Printer));
            this.labelTitle = new System.Windows.Forms.Label();
            this.rptGlobalViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrintInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnYes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(4, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(118, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Sales Invoice";
            // 
            // rptGlobalViewer
            // 
            this.rptGlobalViewer.ActiveViewIndex = -1;
            this.rptGlobalViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptGlobalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptGlobalViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptGlobalViewer.Location = new System.Drawing.Point(5, 90);
            this.rptGlobalViewer.Name = "rptGlobalViewer";
            this.rptGlobalViewer.ShowGroupTreeButton = false;
            this.rptGlobalViewer.ShowLogo = false;
            this.rptGlobalViewer.ShowPrintButton = false;
            this.rptGlobalViewer.Size = new System.Drawing.Size(491, 463);
            this.rptGlobalViewer.TabIndex = 3;
            this.rptGlobalViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.btnClose.Location = new System.Drawing.Point(466, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.Controls.Add(this.btnPrintInvoice);
            this.guna2Panel1.Controls.Add(this.rbtnNo);
            this.guna2Panel1.Controls.Add(this.rbtnYes);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 39);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(491, 45);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.White;
            this.btnPrintInvoice.BorderRadius = 6;
            this.btnPrintInvoice.CheckedState.Parent = this.btnPrintInvoice;
            this.btnPrintInvoice.CustomImages.Parent = this.btnPrintInvoice;
            this.btnPrintInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintInvoice.DisabledState.Parent = this.btnPrintInvoice;
            this.btnPrintInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrintInvoice.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.HoverState.Parent = this.btnPrintInvoice;
            this.btnPrintInvoice.Location = new System.Drawing.Point(413, 9);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.ShadowDecoration.Parent = this.btnPrintInvoice;
            this.btnPrintInvoice.Size = new System.Drawing.Size(72, 28);
            this.btnPrintInvoice.TabIndex = 102;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.BackColor = System.Drawing.Color.White;
            this.rbtnNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNo.CheckedState.BorderThickness = 0;
            this.rbtnNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnNo.CheckedState.InnerOffset = -4;
            this.rbtnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rbtnNo.Location = new System.Drawing.Point(257, 13);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(40, 19);
            this.rbtnNo.TabIndex = 8;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnNo.UncheckedState.BorderThickness = 2;
            this.rbtnNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnNo.UseVisualStyleBackColor = false;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.BackColor = System.Drawing.Color.White;
            this.rbtnYes.Checked = true;
            this.rbtnYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnYes.CheckedState.BorderThickness = 0;
            this.rbtnYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnYes.CheckedState.InnerOffset = -4;
            this.rbtnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rbtnYes.Location = new System.Drawing.Point(183, 13);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(42, 19);
            this.rbtnYes.TabIndex = 7;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnYes.UncheckedState.BorderThickness = 2;
            this.rbtnYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnYes.UseVisualStyleBackColor = false;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mark invoice as Paid ?";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // Invoice_Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(501, 560);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rptGlobalViewer);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice_Printer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice_Printer";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelTitle;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptGlobalViewer;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnPrintInvoice;
        public Guna.UI2.WinForms.Guna2RadioButton rbtnYes;
        public Guna.UI2.WinForms.Guna2RadioButton rbtnNo;
    }
}