
namespace MainUI.Dialog
{
    partial class Result_Parameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_Parameters));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelSampRemarks = new System.Windows.Forms.Label();
            this.txtUtility = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFarmName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Print Pond Result";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(158, 110);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(20, 15);
            this.label103.TabIndex = 115;
            this.label103.Text = "To";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(9, 110);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(34, 15);
            this.label99.TabIndex = 114;
            this.label99.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpTo.BorderRadius = 6;
            this.dtpTo.BorderThickness = 1;
            this.dtpTo.CheckedState.Parent = this.dtpTo;
            this.dtpTo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.HoverState.Parent = this.dtpTo;
            this.dtpTo.Location = new System.Drawing.Point(161, 128);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShadowDecoration.Parent = this.dtpTo;
            this.dtpTo.Size = new System.Drawing.Size(129, 30);
            this.dtpTo.TabIndex = 113;
            this.dtpTo.Value = new System.DateTime(2022, 1, 4, 9, 7, 16, 2);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpFrom.BorderRadius = 6;
            this.dtpFrom.BorderThickness = 1;
            this.dtpFrom.CheckedState.Parent = this.dtpFrom;
            this.dtpFrom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.HoverState.Parent = this.dtpFrom;
            this.dtpFrom.Location = new System.Drawing.Point(12, 128);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShadowDecoration.Parent = this.dtpFrom;
            this.dtpFrom.Size = new System.Drawing.Size(129, 30);
            this.dtpFrom.TabIndex = 112;
            this.dtpFrom.Value = new System.DateTime(2022, 1, 4, 9, 7, 16, 2);
            // 
            // labelSampRemarks
            // 
            this.labelSampRemarks.AutoSize = true;
            this.labelSampRemarks.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelSampRemarks.Location = new System.Drawing.Point(9, 260);
            this.labelSampRemarks.Name = "labelSampRemarks";
            this.labelSampRemarks.Size = new System.Drawing.Size(157, 15);
            this.labelSampRemarks.TabIndex = 117;
            this.labelSampRemarks.Text = "Pond Aide / Utility (Optional)";
            // 
            // txtUtility
            // 
            this.txtUtility.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUtility.BorderRadius = 6;
            this.txtUtility.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUtility.DefaultText = "";
            this.txtUtility.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUtility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUtility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUtility.DisabledState.Parent = this.txtUtility;
            this.txtUtility.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUtility.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUtility.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUtility.FocusedState.Parent = this.txtUtility;
            this.txtUtility.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtUtility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtUtility.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUtility.HoverState.Parent = this.txtUtility;
            this.txtUtility.Location = new System.Drawing.Point(12, 277);
            this.txtUtility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUtility.Multiline = true;
            this.txtUtility.Name = "txtUtility";
            this.txtUtility.PasswordChar = '\0';
            this.txtUtility.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUtility.PlaceholderText = "Enter Pond Aide / Utility";
            this.txtUtility.SelectedText = "";
            this.txtUtility.ShadowDecoration.Parent = this.txtUtility;
            this.txtUtility.Size = new System.Drawing.Size(278, 37);
            this.txtUtility.TabIndex = 116;
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
            this.btnCancel.Location = new System.Drawing.Point(131, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 6;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnConfirm.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(218, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(72, 28);
            this.btnConfirm.TabIndex = 118;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(9, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 121;
            this.label1.Text = "Farm Branch";
            // 
            // txtFarmName
            // 
            this.txtFarmName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFarmName.BorderRadius = 6;
            this.txtFarmName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFarmName.DefaultText = "";
            this.txtFarmName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFarmName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFarmName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFarmName.DisabledState.Parent = this.txtFarmName;
            this.txtFarmName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFarmName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFarmName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFarmName.FocusedState.Parent = this.txtFarmName;
            this.txtFarmName.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtFarmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtFarmName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFarmName.HoverState.Parent = this.txtFarmName;
            this.txtFarmName.Location = new System.Drawing.Point(12, 200);
            this.txtFarmName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFarmName.Multiline = true;
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.PasswordChar = '\0';
            this.txtFarmName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFarmName.PlaceholderText = "Enter Farm Name";
            this.txtFarmName.SelectedText = "";
            this.txtFarmName.ShadowDecoration.Parent = this.txtFarmName;
            this.txtFarmName.Size = new System.Drawing.Size(278, 37);
            this.txtFarmName.TabIndex = 120;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2Separator1.Location = new System.Drawing.Point(12, 77);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(278, 10);
            this.guna2Separator1.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Print Result Details";
            // 
            // Result_Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(307, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFarmName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelSampRemarks);
            this.Controls.Add(this.txtUtility);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result_Parameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result_Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label99;
        public System.Windows.Forms.Label labelSampRemarks;
        public Guna.UI2.WinForms.Guna2TextBox txtUtility;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtFarmName;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        public System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
    }
}