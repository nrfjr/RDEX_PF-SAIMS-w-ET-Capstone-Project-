
namespace MainUI.Dialog
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.labelTransaction = new System.Windows.Forms.Label();
            this.txtCompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompanyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtCustomerFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errCompanyName = new System.Windows.Forms.Label();
            this.errCompanyAddress = new System.Windows.Forms.Label();
            this.errFirstname = new System.Windows.Forms.Label();
            this.errLastname = new System.Windows.Forms.Label();
            this.errPosition = new System.Windows.Forms.Label();
            this.errContact = new System.Windows.Forms.Label();
            this.errAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnBig = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnSmall = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelTransaction.Location = new System.Drawing.Point(10, 13);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(217, 39);
            this.labelTransaction.TabIndex = 4;
            this.labelTransaction.Text = "New Customer";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderRadius = 6;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.DefaultText = "";
            this.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyName.DisabledState.Parent = this.txtCompanyName;
            this.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyName.FocusedState.Parent = this.txtCompanyName;
            this.txtCompanyName.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyName.HoverState.Parent = this.txtCompanyName;
            this.txtCompanyName.Location = new System.Drawing.Point(17, 144);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCompanyName.PlaceholderText = "Enter Company / Store name here";
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.ShadowDecoration.Parent = this.txtCompanyName;
            this.txtCompanyName.Size = new System.Drawing.Size(356, 30);
            this.txtCompanyName.TabIndex = 5;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BorderRadius = 6;
            this.txtCompanyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyAddress.DefaultText = "";
            this.txtCompanyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompanyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompanyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyAddress.DisabledState.Parent = this.txtCompanyAddress;
            this.txtCompanyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyAddress.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCompanyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyAddress.FocusedState.Parent = this.txtCompanyAddress;
            this.txtCompanyAddress.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCompanyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyAddress.HoverState.Parent = this.txtCompanyAddress;
            this.txtCompanyAddress.Location = new System.Drawing.Point(18, 214);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.PasswordChar = '\0';
            this.txtCompanyAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCompanyAddress.PlaceholderText = "Enter Company / Store address here";
            this.txtCompanyAddress.SelectedText = "";
            this.txtCompanyAddress.ShadowDecoration.Parent = this.txtCompanyAddress;
            this.txtCompanyAddress.Size = new System.Drawing.Size(354, 30);
            this.txtCompanyAddress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Company / Store Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company / Store Address";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtCustomerFirstname
            // 
            this.txtCustomerFirstname.BorderRadius = 6;
            this.txtCustomerFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerFirstname.DefaultText = "";
            this.txtCustomerFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerFirstname.DisabledState.Parent = this.txtCustomerFirstname;
            this.txtCustomerFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerFirstname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerFirstname.FocusedState.Parent = this.txtCustomerFirstname;
            this.txtCustomerFirstname.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtCustomerFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCustomerFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerFirstname.HoverState.Parent = this.txtCustomerFirstname;
            this.txtCustomerFirstname.Location = new System.Drawing.Point(19, 423);
            this.txtCustomerFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerFirstname.Name = "txtCustomerFirstname";
            this.txtCustomerFirstname.PasswordChar = '\0';
            this.txtCustomerFirstname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCustomerFirstname.PlaceholderText = "Firstname";
            this.txtCustomerFirstname.SelectedText = "";
            this.txtCustomerFirstname.ShadowDecoration.Parent = this.txtCustomerFirstname;
            this.txtCustomerFirstname.Size = new System.Drawing.Size(163, 30);
            this.txtCustomerFirstname.TabIndex = 10;
            this.txtCustomerFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customers_KeyPress);
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.BorderRadius = 6;
            this.txtCustomerLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerLastname.DefaultText = "";
            this.txtCustomerLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerLastname.DisabledState.Parent = this.txtCustomerLastname;
            this.txtCustomerLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerLastname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerLastname.FocusedState.Parent = this.txtCustomerLastname;
            this.txtCustomerLastname.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtCustomerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCustomerLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerLastname.HoverState.Parent = this.txtCustomerLastname;
            this.txtCustomerLastname.Location = new System.Drawing.Point(203, 423);
            this.txtCustomerLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.PasswordChar = '\0';
            this.txtCustomerLastname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCustomerLastname.PlaceholderText = "Lastname";
            this.txtCustomerLastname.SelectedText = "";
            this.txtCustomerLastname.ShadowDecoration.Parent = this.txtCustomerLastname;
            this.txtCustomerLastname.Size = new System.Drawing.Size(170, 30);
            this.txtCustomerLastname.TabIndex = 11;
            this.txtCustomerLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customers_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(18, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(200, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lastname";
            // 
            // txtPosition
            // 
            this.txtPosition.BorderRadius = 6;
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.DefaultText = "";
            this.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.DisabledState.Parent = this.txtPosition;
            this.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition.FocusedState.Parent = this.txtPosition;
            this.txtPosition.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPosition.HoverState.Parent = this.txtPosition;
            this.txtPosition.Location = new System.Drawing.Point(19, 495);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = '\0';
            this.txtPosition.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPosition.PlaceholderText = "Designation / Position";
            this.txtPosition.SelectedText = "";
            this.txtPosition.ShadowDecoration.Parent = this.txtPosition;
            this.txtPosition.Size = new System.Drawing.Size(353, 30);
            this.txtPosition.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(16, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Designation / Position (Optional)";
            // 
            // txtContact
            // 
            this.txtContact.BorderRadius = 6;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(19, 564);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtContact.PlaceholderText = "Contact Number";
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.Size = new System.Drawing.Size(353, 30);
            this.txtContact.TabIndex = 16;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(18, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact Number";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(355, 32);
            this.guna2Separator1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Location = new System.Drawing.Point(13, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Company / Store Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(13, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contact Person Details";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.Black;
            this.guna2Separator2.Location = new System.Drawing.Point(17, 362);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(355, 32);
            this.guna2Separator2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(18, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 6;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(19, 630);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(354, 30);
            this.txtAddress.TabIndex = 22;
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
            this.btnCancel.Location = new System.Drawing.Point(213, 693);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 25;
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
            this.btnSave.Location = new System.Drawing.Point(301, 693);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 28);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errCompanyName
            // 
            this.errCompanyName.AutoSize = true;
            this.errCompanyName.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCompanyName.ForeColor = System.Drawing.Color.Red;
            this.errCompanyName.Location = new System.Drawing.Point(17, 174);
            this.errCompanyName.Name = "errCompanyName";
            this.errCompanyName.Size = new System.Drawing.Size(34, 13);
            this.errCompanyName.TabIndex = 26;
            this.errCompanyName.Text = "*error";
            // 
            // errCompanyAddress
            // 
            this.errCompanyAddress.AutoSize = true;
            this.errCompanyAddress.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCompanyAddress.ForeColor = System.Drawing.Color.Red;
            this.errCompanyAddress.Location = new System.Drawing.Point(18, 243);
            this.errCompanyAddress.Name = "errCompanyAddress";
            this.errCompanyAddress.Size = new System.Drawing.Size(34, 13);
            this.errCompanyAddress.TabIndex = 27;
            this.errCompanyAddress.Text = "*error";
            // 
            // errFirstname
            // 
            this.errFirstname.AutoSize = true;
            this.errFirstname.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFirstname.ForeColor = System.Drawing.Color.Red;
            this.errFirstname.Location = new System.Drawing.Point(17, 453);
            this.errFirstname.Name = "errFirstname";
            this.errFirstname.Size = new System.Drawing.Size(34, 13);
            this.errFirstname.TabIndex = 28;
            this.errFirstname.Text = "*error";
            // 
            // errLastname
            // 
            this.errLastname.AutoSize = true;
            this.errLastname.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLastname.ForeColor = System.Drawing.Color.Red;
            this.errLastname.Location = new System.Drawing.Point(200, 453);
            this.errLastname.Name = "errLastname";
            this.errLastname.Size = new System.Drawing.Size(34, 13);
            this.errLastname.TabIndex = 29;
            this.errLastname.Text = "*error";
            // 
            // errPosition
            // 
            this.errPosition.AutoSize = true;
            this.errPosition.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPosition.ForeColor = System.Drawing.Color.Red;
            this.errPosition.Location = new System.Drawing.Point(18, 527);
            this.errPosition.Name = "errPosition";
            this.errPosition.Size = new System.Drawing.Size(34, 13);
            this.errPosition.TabIndex = 30;
            this.errPosition.Text = "*error";
            // 
            // errContact
            // 
            this.errContact.AutoSize = true;
            this.errContact.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContact.ForeColor = System.Drawing.Color.Red;
            this.errContact.Location = new System.Drawing.Point(18, 595);
            this.errContact.Name = "errContact";
            this.errContact.Size = new System.Drawing.Size(34, 13);
            this.errContact.TabIndex = 31;
            this.errContact.Text = "*error";
            // 
            // errAddress
            // 
            this.errAddress.AutoSize = true;
            this.errAddress.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddress.ForeColor = System.Drawing.Color.Red;
            this.errAddress.Location = new System.Drawing.Point(18, 662);
            this.errAddress.Name = "errAddress";
            this.errAddress.Size = new System.Drawing.Size(34, 13);
            this.errAddress.TabIndex = 32;
            this.errAddress.Text = "*error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(18, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Set customer as:";
            // 
            // rbtnBig
            // 
            this.rbtnBig.AutoSize = true;
            this.rbtnBig.Checked = true;
            this.rbtnBig.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnBig.CheckedState.BorderThickness = 0;
            this.rbtnBig.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rbtnBig.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnBig.CheckedState.InnerOffset = -4;
            this.rbtnBig.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBig.Location = new System.Drawing.Point(88, 311);
            this.rbtnBig.Name = "rbtnBig";
            this.rbtnBig.Size = new System.Drawing.Size(74, 19);
            this.rbtnBig.TabIndex = 34;
            this.rbtnBig.TabStop = true;
            this.rbtnBig.Text = "Big Buyer";
            this.rbtnBig.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnBig.UncheckedState.BorderThickness = 2;
            this.rbtnBig.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnBig.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnSmall.CheckedState.BorderThickness = 0;
            this.rbtnSmall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.rbtnSmall.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnSmall.CheckedState.InnerOffset = -4;
            this.rbtnSmall.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSmall.Location = new System.Drawing.Point(209, 311);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(86, 19);
            this.rbtnSmall.TabIndex = 35;
            this.rbtnSmall.Text = "Small Buyer";
            this.rbtnSmall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnSmall.UncheckedState.BorderThickness = 2;
            this.rbtnSmall.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnSmall.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(393, 740);
            this.Controls.Add(this.rbtnSmall);
            this.Controls.Add(this.rbtnBig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errAddress);
            this.Controls.Add(this.errContact);
            this.Controls.Add(this.errPosition);
            this.Controls.Add(this.errLastname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerLastname);
            this.Controls.Add(this.txtCustomerFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.errCompanyName);
            this.Controls.Add(this.errCompanyAddress);
            this.Controls.Add(this.errFirstname);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customers_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label errAddress;
        private System.Windows.Forms.Label errContact;
        private System.Windows.Forms.Label errPosition;
        private System.Windows.Forms.Label errLastname;
        private System.Windows.Forms.Label errCompanyName;
        private System.Windows.Forms.Label errCompanyAddress;
        private System.Windows.Forms.Label errFirstname;
        public Guna.UI2.WinForms.Guna2TextBox txtCompanyName;
        public Guna.UI2.WinForms.Guna2TextBox txtCompanyAddress;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        public Guna.UI2.WinForms.Guna2TextBox txtContact;
        public Guna.UI2.WinForms.Guna2TextBox txtPosition;
        public Guna.UI2.WinForms.Guna2TextBox txtCustomerLastname;
        public Guna.UI2.WinForms.Guna2TextBox txtCustomerFirstname;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2RadioButton rbtnSmall;
        public Guna.UI2.WinForms.Guna2RadioButton rbtnBig;
    }
}