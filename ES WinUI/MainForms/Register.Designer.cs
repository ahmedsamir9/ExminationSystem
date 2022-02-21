namespace Examination_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.tbLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.tbFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.tbUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.rbMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Depth = 0;
            this.tbLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbLastName.Hint = "Last Name";
            this.tbLastName.Location = new System.Drawing.Point(55, 256);
            this.tbLastName.MaxLength = 50;
            this.tbLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLastName.Multiline = false;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(227, 50);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Depth = 0;
            this.btnRegister.DrawShadows = true;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(410, 497);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 36);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "     REGISTER     ";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Depth = 0;
            this.tbFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbFirstName.Hint = "First Name";
            this.tbFirstName.Location = new System.Drawing.Point(55, 114);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(227, 50);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Text = "";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Depth = 0;
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbEmail.Hint = "Email";
            this.tbEmail.Location = new System.Drawing.Point(648, 256);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(227, 50);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Depth = 0;
            this.tbUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbUsername.Hint = "Username";
            this.tbUsername.Location = new System.Drawing.Point(55, 398);
            this.tbUsername.MaxLength = 50;
            this.tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(227, 50);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.Text = "";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbPassword.Hint = "Password";
            this.tbPassword.Location = new System.Drawing.Point(648, 114);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(227, 50);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Depth = 0;
            this.rbMale.Location = new System.Drawing.Point(26, 23);
            this.rbMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMale.Name = "rbMale";
            this.rbMale.Ripple = true;
            this.rbMale.Size = new System.Drawing.Size(70, 37);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(648, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Depth = 0;
            this.rbFemale.Location = new System.Drawing.Point(26, 60);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Ripple = true;
            this.rbFemale.Size = new System.Drawing.Size(87, 37);
            this.rbFemale.TabIndex = 27;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox tbLastName;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialTextBox tbFirstName;
        private MaterialSkin.Controls.MaterialTextBox tbEmail;
        private MaterialSkin.Controls.MaterialTextBox tbUsername;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialRadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rbFemale;
    }
}