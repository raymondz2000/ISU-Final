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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void buttonstartorder_Click(object sender, EventArgs e)
        {
            // Start the order
            order_form selectForm = new order_form();
            selectForm.Show();
            this.Hide();
        }

        private void buttonback2_Click(object sender, EventArgs e)
        {
            // Start the order
            welcomeform selectForm = new welcomeform();
            selectForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the programme
            Application.Exit();
        }

        private void buttonwhoisus_Click(object sender, EventArgs e)
        {
            // Display the ownership of this program
            MessageBox.Show("LongMing Tax are formed by: " + "\r\n" + "RAYMOND ZHU" + "\r\n" +
                "BILL KUANG" + "\r\n" + "KEVIN ZHANG" + "\r\n" + "Thank you very much for using our program.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonfinance_Click(object sender, EventArgs e)
        {
            // Display the email address of the developer
            MessageBox.Show("Please send e-mail to 349586933@gapps.yrdsb.ca to report any issue, " +
                "thank you.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttondish_Click(object sender, EventArgs e)
        {
            //show the nutrition information.
            MessageBox.Show("Please see the information below. " +"\r\n"+
                    "Estimates range from 1,600 to 2,400 calories per day for adult women and 2,000 to 3,000 calories per day for adult men."+"\r\n"+ "Estimates range from 800 to 1200 calories per day for childern.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            // Display the user's name
            this.labelwelcome2.Text = "Welcome, " + welcomeform.NameStr;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the guiding information for tax calculation
            MessageBox.Show("Select the menu option.", "Help",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
