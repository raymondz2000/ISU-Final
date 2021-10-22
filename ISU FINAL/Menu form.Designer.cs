namespace ISU_FINAL
{
    partial class Menu_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelwelcome2 = new System.Windows.Forms.Label();
            this.buttonstartorder = new System.Windows.Forms.Button();
            this.buttonwhoisus = new System.Windows.Forms.Button();
            this.buttondish = new System.Windows.Forms.Button();
            this.buttonfinance = new System.Windows.Forms.Button();
            this.buttonback2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(480, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelwelcome2
            // 
            this.labelwelcome2.AutoSize = true;
            this.labelwelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwelcome2.Location = new System.Drawing.Point(25, 41);
            this.labelwelcome2.Name = "labelwelcome2";
            this.labelwelcome2.Size = new System.Drawing.Size(115, 25);
            this.labelwelcome2.TabIndex = 1;
            this.labelwelcome2.Text = "Welcome: ";
            // 
            // buttonstartorder
            // 
            this.buttonstartorder.Location = new System.Drawing.Point(75, 80);
            this.buttonstartorder.Name = "buttonstartorder";
            this.buttonstartorder.Size = new System.Drawing.Size(119, 53);
            this.buttonstartorder.TabIndex = 2;
            this.buttonstartorder.Text = "Start an order";
            this.buttonstartorder.UseVisualStyleBackColor = true;
            this.buttonstartorder.Click += new System.EventHandler(this.buttonstartorder_Click);
            // 
            // buttonwhoisus
            // 
            this.buttonwhoisus.Location = new System.Drawing.Point(237, 80);
            this.buttonwhoisus.Name = "buttonwhoisus";
            this.buttonwhoisus.Size = new System.Drawing.Size(119, 53);
            this.buttonwhoisus.TabIndex = 3;
            this.buttonwhoisus.Text = "Ownership";
            this.buttonwhoisus.UseVisualStyleBackColor = true;
            this.buttonwhoisus.Click += new System.EventHandler(this.buttonwhoisus_Click);
            // 
            // buttondish
            // 
            this.buttondish.Location = new System.Drawing.Point(237, 157);
            this.buttondish.Name = "buttondish";
            this.buttondish.Size = new System.Drawing.Size(119, 53);
            this.buttondish.TabIndex = 5;
            this.buttondish.Text = "Nutrition Information";
            this.buttondish.UseVisualStyleBackColor = true;
            this.buttondish.Click += new System.EventHandler(this.buttondish_Click);
            // 
            // buttonfinance
            // 
            this.buttonfinance.Location = new System.Drawing.Point(75, 158);
            this.buttonfinance.Name = "buttonfinance";
            this.buttonfinance.Size = new System.Drawing.Size(119, 52);
            this.buttonfinance.TabIndex = 6;
            this.buttonfinance.Text = "Report Issues";
            this.buttonfinance.UseVisualStyleBackColor = true;
            this.buttonfinance.Click += new System.EventHandler(this.buttonfinance_Click);
            // 
            // buttonback2
            // 
            this.buttonback2.Location = new System.Drawing.Point(349, 291);
            this.buttonback2.Name = "buttonback2";
            this.buttonback2.Size = new System.Drawing.Size(119, 40);
            this.buttonback2.TabIndex = 8;
            this.buttonback2.Text = "Back";
            this.buttonback2.UseVisualStyleBackColor = true;
            this.buttonback2.Click += new System.EventHandler(this.buttonback2_Click);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.buttonback2);
            this.Controls.Add(this.buttonfinance);
            this.Controls.Add(this.buttondish);
            this.Controls.Add(this.buttonwhoisus);
            this.Controls.Add(this.buttonstartorder);
            this.Controls.Add(this.labelwelcome2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_form";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelwelcome2;
        private System.Windows.Forms.Button buttonstartorder;
        private System.Windows.Forms.Button buttonwhoisus;
        private System.Windows.Forms.Button buttondish;
        private System.Windows.Forms.Button buttonfinance;
        private System.Windows.Forms.Button buttonback2;
    }
}