using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISU_FINAL
{
    public partial class Brand_form : Form
    {
        public Brand_form()
        {
            InitializeComponent();
        }

        private void buttonback3_Click(object sender, EventArgs e)
        {
            // Start the order
            order_form selectForm = new order_form();
            selectForm.Show();
            this.Hide();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the guiding information for tax calculation
            MessageBox.Show("Here is our brand info.", "Help",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Brand_form_Load(object sender, EventArgs e)
        {
            // Display the user's name
            this.labelwelcome4.Text = "Welcome, " + welcomeform.NameStr;

        }
    }
}
