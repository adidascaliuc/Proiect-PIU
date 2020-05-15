namespace TargDeMasiniForm
{
    partial class PaginaStartForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLoginSignUp = new MetroFramework.Controls.MetroButton();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblOra = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.Location = new System.Drawing.Point(46, 293);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(224, 94);
            this.btnLoginSignUp.TabIndex = 4;
            this.btnLoginSignUp.Text = "Login and Register";
            this.btnLoginSignUp.Click += new System.EventHandler(this.btnLoginSignUp_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(510, 89);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 19);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(510, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Ora:";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(556, 38);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(0, 0);
            this.lblOra.TabIndex = 7;
            // 
            // PaginaStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::TargDeMasiniForm.Properties.Resources.backgroundPrimaPagina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnLoginSignUp);
            this.Name = "PaginaStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btnLoginSignUp;
        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblOra;
    }
}