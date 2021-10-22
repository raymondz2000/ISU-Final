namespace ISU_FINAL
{
    partial class Brand_form
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
            this.labelwelcome4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxbrand = new System.Windows.Forms.PictureBox();
            this.buttonback3 = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbrand)).BeginInit();
            this.SuspendLayout();
            // 
            // labelwelcome4
            // 
            this.labelwelcome4.AutoSize = true;
            this.labelwelcome4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwelcome4.Location = new System.Drawing.Point(45, 45);
            this.labelwelcome4.Name = "labelwelcome4";
            this.labelwelcome4.Size = new System.Drawing.Size(92, 20);
            this.labelwelcome4.TabIndex = 0;
            this.labelwelcome4.Text = "Welcome:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(480, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBoxbrand
            // 
            this.pictureBoxbrand.Image = global::ISU_FINAL.Properties.Resources.longming;
            this.pictureBoxbrand.Location = new System.Drawing.Point(148, 84);
            this.pictureBoxbrand.Name = "pictureBoxbrand";
            this.pictureBoxbrand.Size = new System.Drawing.Size(159, 129);
            this.pictureBoxbrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbrand.TabIndex = 2;
            this.pictureBoxbrand.TabStop = false;
            // 
            // buttonback3
            // 
            this.buttonback3.Location = new System.Drawing.Point(51, 261);
            this.buttonback3.Name = "buttonback3";
            this.buttonback3.Size = new System.Drawing.Size(88, 37);
            this.buttonback3.TabIndex = 3;
            this.buttonback3.Text = "Back";
            this.buttonback3.UseVisualStyleBackColor = true;
            this.buttonback3.Click += new System.EventHandler(this.buttonback3_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(319, 261);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(88, 37);
            this.buttonexit.TabIndex = 4;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Brand_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonback3);
            this.Controls.Add(this.pictureBoxbrand);
            this.Controls.Add(this.labelwelcome4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Brand_form";
            this.Text = "Brand_form";
            this.Load += new System.EventHandler(this.Brand_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelwelcome4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxbrand;
        private System.Windows.Forms.Button buttonback3;
        private System.Windows.Forms.Button buttonexit;
    }
}