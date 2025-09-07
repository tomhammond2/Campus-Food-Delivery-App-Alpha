
namespace UniEats_Alpha
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InvaildUnameOrPword = new System.Windows.Forms.Label();
            this.RegisterNowLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.BackButton.TabIndex = 0;
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(122, 390);
            this.UsernameTextBox.MaxLength = 15;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(226, 47);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(122, 524);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(280, 47);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(109, 239);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(195, 76);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Black;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(122, 814);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(380, 126);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "LOG IN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InvaildUnameOrPword
            // 
            this.InvaildUnameOrPword.AutoSize = true;
            this.InvaildUnameOrPword.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvaildUnameOrPword.Location = new System.Drawing.Point(128, 680);
            this.InvaildUnameOrPword.Name = "InvaildUnameOrPword";
            this.InvaildUnameOrPword.Size = new System.Drawing.Size(378, 29);
            this.InvaildUnameOrPword.TabIndex = 8;
            this.InvaildUnameOrPword.Text = "Password or username was invalid";
            this.InvaildUnameOrPword.Visible = false;
            // 
            // RegisterNowLabel
            // 
            this.RegisterNowLabel.AutoSize = true;
            this.RegisterNowLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNowLabel.Location = new System.Drawing.Point(128, 732);
            this.RegisterNowLabel.Name = "RegisterNowLabel";
            this.RegisterNowLabel.Size = new System.Drawing.Size(172, 29);
            this.RegisterNowLabel.TabIndex = 9;
            this.RegisterNowLabel.Text = "Register Now";
            this.RegisterNowLabel.Visible = false;
            this.RegisterNowLabel.Click += new System.EventHandler(this.RegisterNowLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(115, 339);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(264, 39);
            this.UsernameLabel.TabIndex = 15;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::UniEats_Alpha.Properties.Resources.IphoneBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 1029);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RegisterNowLabel);
            this.Controls.Add(this.InvaildUnameOrPword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.BackButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label InvaildUnameOrPword;
        private System.Windows.Forms.Label RegisterNowLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label1;
    }
}