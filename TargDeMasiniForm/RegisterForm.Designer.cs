namespace TargDeMasiniForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.txtNume = new MetroFramework.Controls.MetroTextBox();
            this.txtPrenume = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureShowPassword = new System.Windows.Forms.PictureBox();
            this.pictureShowConfirmPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblRegister);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 63);
            this.panel1.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.LightGray;
            this.lblRegister.Location = new System.Drawing.Point(12, 18);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(139, 20);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "Register Screen";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnX.Location = new System.Drawing.Point(359, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(38, 35);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNume.CustomBackground = true;
            this.txtNume.CustomForeColor = true;
            this.txtNume.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNume.Location = new System.Drawing.Point(88, 77);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(226, 35);
            this.txtNume.TabIndex = 11;
            this.txtNume.Text = "Nume";
            this.txtNume.Enter += new System.EventHandler(this.txtNume_Enter);
            this.txtNume.Leave += new System.EventHandler(this.txtNume_Leave);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrenume.CustomBackground = true;
            this.txtPrenume.CustomForeColor = true;
            this.txtPrenume.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrenume.Location = new System.Drawing.Point(88, 130);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(226, 35);
            this.txtPrenume.TabIndex = 12;
            this.txtPrenume.Text = "Prenume";
            this.txtPrenume.Enter += new System.EventHandler(this.textPrenume_Enter);
            this.txtPrenume.Leave += new System.EventHandler(this.txtPrenume_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.CustomBackground = true;
            this.txtUsername.CustomForeColor = true;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsername.Location = new System.Drawing.Point(88, 185);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 35);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.CustomBackground = true;
            this.txtPassword.CustomForeColor = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Location = new System.Drawing.Point(88, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 35);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(133, 349);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 45);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Register";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtConfirmPassword.CustomBackground = true;
            this.txtConfirmPassword.CustomForeColor = true;
            this.txtConfirmPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtConfirmPassword.Location = new System.Drawing.Point(88, 297);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(226, 35);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.Text = "Password";
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TargDeMasiniForm.Properties.Resources.confirmPassword;
            this.pictureBox5.Location = new System.Drawing.Point(27, 297);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TargDeMasiniForm.Properties.Resources.usernamePng;
            this.pictureBox4.Location = new System.Drawing.Point(27, 185);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TargDeMasiniForm.Properties.Resources.passwordPng1;
            this.pictureBox3.Location = new System.Drawing.Point(27, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TargDeMasiniForm.Properties.Resources.firstLastNamePng;
            this.pictureBox2.Location = new System.Drawing.Point(27, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TargDeMasiniForm.Properties.Resources.firstLastNamePng;
            this.pictureBox1.Location = new System.Drawing.Point(27, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureShowPassword
            // 
            this.pictureShowPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShowPassword.Image = global::TargDeMasiniForm.Properties.Resources.eye;
            this.pictureShowPassword.Location = new System.Drawing.Point(275, 240);
            this.pictureShowPassword.Name = "pictureShowPassword";
            this.pictureShowPassword.Size = new System.Drawing.Size(39, 38);
            this.pictureShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPassword.TabIndex = 18;
            this.pictureShowPassword.TabStop = false;
            this.pictureShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureShowPassword_MouseDown);
            this.pictureShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureShowPassword_MouseUp);
            // 
            // pictureShowConfirmPassword
            // 
            this.pictureShowConfirmPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureShowConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShowConfirmPassword.Image = global::TargDeMasiniForm.Properties.Resources.eye;
            this.pictureShowConfirmPassword.Location = new System.Drawing.Point(275, 297);
            this.pictureShowConfirmPassword.Name = "pictureShowConfirmPassword";
            this.pictureShowConfirmPassword.Size = new System.Drawing.Size(39, 38);
            this.pictureShowConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowConfirmPassword.TabIndex = 19;
            this.pictureShowConfirmPassword.TabStop = false;
            this.pictureShowConfirmPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureShowConfirmPassword_MouseDown);
            this.pictureShowConfirmPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureShowConfirmPassword_MouseUp);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.ControlBox = false;
            this.Controls.Add(this.pictureShowConfirmPassword);
            this.Controls.Add(this.pictureShowPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox txtNume;
        private MetroFramework.Controls.MetroTextBox txtPrenume;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureShowPassword;
        private System.Windows.Forms.PictureBox pictureShowConfirmPassword;
    }
}