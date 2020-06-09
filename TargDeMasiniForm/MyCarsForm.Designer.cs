namespace TargDeMasiniForm
{
    partial class MyCarsForm
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
            this.titleMyCars = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // titleMyCars
            // 
            this.titleMyCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.titleMyCars.CustomBackground = true;
            this.titleMyCars.Location = new System.Drawing.Point(12, 12);
            this.titleMyCars.Name = "titleMyCars";
            this.titleMyCars.Size = new System.Drawing.Size(83, 28);
            this.titleMyCars.TabIndex = 145;
            this.titleMyCars.Text = "My Cars";
            this.titleMyCars.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 324);
            this.flowLayoutPanel1.TabIndex = 147;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(475, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 148;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MyCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 411);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.titleMyCars);
            this.Name = "MyCarsForm";
            this.Text = "MyCarsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile titleMyCars;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}