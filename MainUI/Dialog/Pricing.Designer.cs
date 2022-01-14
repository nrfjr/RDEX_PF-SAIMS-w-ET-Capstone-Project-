
namespace MainUI.Dialog
{
    partial class Pricing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pricing));
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPriceCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.errPriceCode = new System.Windows.Forms.Label();
            this.txtPriceValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errPriceValue = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(213, 206);
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
            this.btnSave.Location = new System.Drawing.Point(300, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPriceCode
            // 
            this.txtPriceCode.BorderRadius = 6;
            this.txtPriceCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceCode.DefaultText = "";
            this.txtPriceCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceCode.DisabledState.Parent = this.txtPriceCode;
            this.txtPriceCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceCode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriceCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceCode.FocusedState.Parent = this.txtPriceCode;
            this.txtPriceCode.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtPriceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPriceCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceCode.HoverState.Parent = this.txtPriceCode;
            this.txtPriceCode.Location = new System.Drawing.Point(18, 138);
            this.txtPriceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceCode.Name = "txtPriceCode";
            this.txtPriceCode.PasswordChar = '\0';
            this.txtPriceCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPriceCode.PlaceholderText = "PRC00000";
            this.txtPriceCode.SelectedText = "";
            this.txtPriceCode.ShadowDecoration.Parent = this.txtPriceCode;
            this.txtPriceCode.Size = new System.Drawing.Size(168, 30);
            this.txtPriceCode.TabIndex = 67;
            this.txtPriceCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceCode_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Price Details";
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
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Price Code";
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(10, 13);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(152, 39);
            this.labelTransaction.TabIndex = 63;
            this.labelTransaction.Text = "New Price";
            // 
            // errPriceCode
            // 
            this.errPriceCode.AutoSize = true;
            this.errPriceCode.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPriceCode.ForeColor = System.Drawing.Color.Red;
            this.errPriceCode.Location = new System.Drawing.Point(15, 168);
            this.errPriceCode.Name = "errPriceCode";
            this.errPriceCode.Size = new System.Drawing.Size(34, 13);
            this.errPriceCode.TabIndex = 68;
            this.errPriceCode.Text = "*error";
            // 
            // txtPriceValue
            // 
            this.txtPriceValue.BorderRadius = 6;
            this.txtPriceValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceValue.DefaultText = "";
            this.txtPriceValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceValue.DisabledState.Parent = this.txtPriceValue;
            this.txtPriceValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceValue.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriceValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceValue.FocusedState.Parent = this.txtPriceValue;
            this.txtPriceValue.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPriceValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceValue.HoverState.Parent = this.txtPriceValue;
            this.txtPriceValue.Location = new System.Drawing.Point(204, 138);
            this.txtPriceValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceValue.Name = "txtPriceValue";
            this.txtPriceValue.PasswordChar = '\0';
            this.txtPriceValue.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPriceValue.PlaceholderText = "₱ 0.00";
            this.txtPriceValue.SelectedText = "";
            this.txtPriceValue.ShadowDecoration.Parent = this.txtPriceValue;
            this.txtPriceValue.Size = new System.Drawing.Size(168, 30);
            this.txtPriceValue.TabIndex = 74;
            this.txtPriceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(201, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "Price Value (₱)";
            // 
            // errPriceValue
            // 
            this.errPriceValue.AutoSize = true;
            this.errPriceValue.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPriceValue.ForeColor = System.Drawing.Color.Red;
            this.errPriceValue.Location = new System.Drawing.Point(201, 168);
            this.errPriceValue.Name = "errPriceValue";
            this.errPriceValue.Size = new System.Drawing.Size(34, 13);
            this.errPriceValue.TabIndex = 76;
            this.errPriceValue.Text = "*error";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Pricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(393, 251);
            this.Controls.Add(this.errPriceValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPriceCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.errPriceCode);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pricing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pricing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2TextBox txtPriceCode;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label errPriceCode;
        public Guna.UI2.WinForms.Guna2TextBox txtPriceValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errPriceValue;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}