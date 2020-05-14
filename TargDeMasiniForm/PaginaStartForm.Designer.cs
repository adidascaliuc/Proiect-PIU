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
            this.btnLoginSignUp = new System.Windows.Forms.Button();
            this.lblOra = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginSignUp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSignUp.Location = new System.Drawing.Point(26, 320);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(192, 70);
            this.btnLoginSignUp.TabIndex = 0;
            this.btnLoginSignUp.Text = "Login and Sign Up";
            this.btnLoginSignUp.UseVisualStyleBackColor = true;
            this.btnLoginSignUp.Click += new System.EventHandler(this.btnLoginSignUp_Click);
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.BackColor = System.Drawing.Color.Coral;
            this.lblOra.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.Location = new System.Drawing.Point(574, 9);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(0, 31);
            this.lblOra.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Coral;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(506, 64);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(68, 31);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ora: ";
            // 
            // PaginaStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::TargDeMasiniForm.Properties.Resources.backgroundPrimaPagina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.btnLoginSignUp);
            this.Name = "PaginaStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginSignUp;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}