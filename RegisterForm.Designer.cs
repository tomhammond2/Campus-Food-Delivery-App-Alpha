
namespace UniEats_Alpha
{
    partial class RegisterForm
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
            this.SignupBotton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswrodLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTypeDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InvaildUname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignupBotton
            // 
            this.SignupBotton.BackColor = System.Drawing.Color.Black;
            this.SignupBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBotton.ForeColor = System.Drawing.SystemColors.Control;
            this.SignupBotton.Location = new System.Drawing.Point(122, 814);
            this.SignupBotton.Name = "SignupBotton";
            this.SignupBotton.Size = new System.Drawing.Size(380, 126);
            this.SignupBotton.TabIndex = 12;
            this.SignupBotton.Text = "SIGN UP";
            this.SignupBotton.UseVisualStyleBackColor = false;
            this.SignupBotton.Click += new System.EventHandler(this.SignupBotton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(77, 150);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(246, 69);
            this.RegisterLabel.TabIndex = 11;
            this.RegisterLabel.Text = "Sign-Up";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(89, 437);
            this.PasswordTextBox.MaxLength = 16;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 26);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(87, 318);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(250, 23);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.BackgroundImage = global::UniEats_Alpha.Properties.Resources.BackArrow;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.Location = new System.Drawing.Point(48, 76);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(49, 58);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Sih";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(80, 252);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(264, 39);
            this.UsernameLabel.TabIndex = 14;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // PasswrodLabel
            // 
            this.PasswrodLabel.AutoSize = true;
            this.PasswrodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswrodLabel.Location = new System.Drawing.Point(80, 379);
            this.PasswrodLabel.Name = "PasswrodLabel";
            this.PasswrodLabel.Size = new System.Drawing.Size(257, 39);
            this.PasswrodLabel.TabIndex = 15;
            this.PasswrodLabel.Text = "Enter Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(80, 617);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(89, 39);
            this.UserLabel.TabIndex = 16;
            this.UserLabel.Text = "User";
            // 
            // UserTypeDropDown
            // 
            this.UserTypeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeDropDown.FormattingEnabled = true;
            this.UserTypeDropDown.Items.AddRange(new object[] {
            "Student",
            "Driver/Rider",
            "Restaurant"});
            this.UserTypeDropDown.Location = new System.Drawing.Point(87, 670);
            this.UserTypeDropDown.Name = "UserTypeDropDown";
            this.UserTypeDropDown.Size = new System.Drawing.Size(250, 24);
            this.UserTypeDropDown.TabIndex = 17;
            this.UserTypeDropDown.Text = "Select a User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 562);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 21;
            // 
            // InvaildUname
            // 
            this.InvaildUname.AutoSize = true;
            this.InvaildUname.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvaildUname.Location = new System.Drawing.Point(84, 734);
            this.InvaildUname.Name = "InvaildUname";
            this.InvaildUname.Size = new System.Drawing.Size(189, 29);
            this.InvaildUname.TabIndex = 22;
            this.InvaildUname.Text = "Username in use";
            this.InvaildUname.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniEats_Alpha.Properties.Resources.IphoneBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 1029);
            this.Controls.Add(this.InvaildUname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserTypeDropDown);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswrodLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignupBotton);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.BackButton);
            this.DoubleBuffered = true;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignupBotton;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswrodLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ComboBox UserTypeDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InvaildUname;
    }
}