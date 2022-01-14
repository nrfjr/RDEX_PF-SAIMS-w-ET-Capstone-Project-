
namespace MainUI.Dialog
{
    partial class Pond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pond));
            this.labelTransaction = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtPondCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPondImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPondArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditImage = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errPondCode = new System.Windows.Forms.Label();
            this.errPondArea = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.labelImagePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPondImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(10, 13);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(154, 39);
            this.labelTransaction.TabIndex = 48;
            this.labelTransaction.Text = "New Pond";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Pond Details";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 67);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(355, 32);
            this.guna2Separator1.TabIndex = 53;
            // 
            // txtPondCode
            // 
            this.txtPondCode.BorderRadius = 6;
            this.txtPondCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPondCode.DefaultText = "";
            this.txtPondCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPondCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPondCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPondCode.DisabledState.Parent = this.txtPondCode;
            this.txtPondCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPondCode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPondCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPondCode.FocusedState.Parent = this.txtPondCode;
            this.txtPondCode.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtPondCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPondCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPondCode.HoverState.Parent = this.txtPondCode;
            this.txtPondCode.Location = new System.Drawing.Point(17, 301);
            this.txtPondCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPondCode.Name = "txtPondCode";
            this.txtPondCode.PasswordChar = '\0';
            this.txtPondCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPondCode.PlaceholderText = "Pond00 / P00";
            this.txtPondCode.SelectedText = "";
            this.txtPondCode.ShadowDecoration.Parent = this.txtPondCode;
            this.txtPondCode.Size = new System.Drawing.Size(168, 30);
            this.txtPondCode.TabIndex = 57;
            this.txtPondCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPondCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(14, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Pond Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(147, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Pond Image";
            // 
            // pbxPondImage
            // 
            this.pbxPondImage.BorderRadius = 6;
            this.pbxPondImage.ImageRotate = 0F;
            this.pbxPondImage.Location = new System.Drawing.Point(65, 115);
            this.pbxPondImage.Name = "pbxPondImage";
            this.pbxPondImage.ShadowDecoration.Parent = this.pbxPondImage;
            this.pbxPondImage.Size = new System.Drawing.Size(249, 143);
            this.pbxPondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPondImage.TabIndex = 0;
            this.pbxPondImage.TabStop = false;
            // 
            // txtPondArea
            // 
            this.txtPondArea.BorderRadius = 6;
            this.txtPondArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPondArea.DefaultText = "";
            this.txtPondArea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPondArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPondArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPondArea.DisabledState.Parent = this.txtPondArea;
            this.txtPondArea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPondArea.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPondArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPondArea.FocusedState.Parent = this.txtPondArea;
            this.txtPondArea.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtPondArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPondArea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPondArea.HoverState.Parent = this.txtPondArea;
            this.txtPondArea.Location = new System.Drawing.Point(204, 301);
            this.txtPondArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPondArea.Name = "txtPondArea";
            this.txtPondArea.PasswordChar = '\0';
            this.txtPondArea.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPondArea.PlaceholderText = "0,000";
            this.txtPondArea.SelectedText = "";
            this.txtPondArea.ShadowDecoration.Parent = this.txtPondArea;
            this.txtPondArea.Size = new System.Drawing.Size(168, 30);
            this.txtPondArea.TabIndex = 59;
            this.txtPondArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPondArea_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(201, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Pond Area (Sqm.)";
            // 
            // btnEditImage
            // 
            this.btnEditImage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditImage.FlatAppearance.BorderSize = 0;
            this.btnEditImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditImage.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEditImage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditImage.IconSize = 35;
            this.btnEditImage.Location = new System.Drawing.Point(320, 115);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(28, 31);
            this.btnEditImage.TabIndex = 61;
            this.btnEditImage.UseVisualStyleBackColor = false;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(213, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 63;
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
            this.btnSave.Location = new System.Drawing.Point(300, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errPondCode
            // 
            this.errPondCode.AutoSize = true;
            this.errPondCode.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPondCode.ForeColor = System.Drawing.Color.Red;
            this.errPondCode.Location = new System.Drawing.Point(14, 330);
            this.errPondCode.Name = "errPondCode";
            this.errPondCode.Size = new System.Drawing.Size(34, 13);
            this.errPondCode.TabIndex = 64;
            this.errPondCode.Text = "*error";
            // 
            // errPondArea
            // 
            this.errPondArea.AutoSize = true;
            this.errPondArea.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPondArea.ForeColor = System.Drawing.Color.Red;
            this.errPondArea.Location = new System.Drawing.Point(201, 330);
            this.errPondArea.Name = "errPondArea";
            this.errPondArea.Size = new System.Drawing.Size(34, 13);
            this.errPondArea.TabIndex = 65;
            this.errPondArea.Text = "*error";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Font = new System.Drawing.Font("Open Sans", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelImagePath.Location = new System.Drawing.Point(13, 357);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(0, 10);
            this.labelImagePath.TabIndex = 66;
            this.labelImagePath.Visible = false;
            // 
            // Pond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(393, 414);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPondArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPondCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.pbxPondImage);
            this.Controls.Add(this.errPondCode);
            this.Controls.Add(this.errPondArea);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pond";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPondImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2TextBox txtPondCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtPondArea;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnEditImage;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label errPondCode;
        private System.Windows.Forms.Label errPondArea;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public System.Windows.Forms.Label labelImagePath;
        public Guna.UI2.WinForms.Guna2PictureBox pbxPondImage;
    }
}