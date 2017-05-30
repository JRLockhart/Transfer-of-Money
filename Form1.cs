using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money2
{
    public partial class Form1 : Form
    {

        //declare global objects and variables
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            //give values to objects
            joe = new Guy() {Cash = 50, Name = "Joe"};
            bob = new Guy() { Cash = 100, Name = "Bob" };

            //update gui with new values
            UpdateForm();

        }//end of form1

        //update the values in the gui
        public void UpdateForm()
        {
            joeCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }//end of updateForm

        //actionlistners for when the buttons are clicked
        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                joe.Cash -= bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe is out of money.");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.Cash -= joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob is out of money.");
            }
        }

        private void JoeDeposit_Click(object sender, EventArgs e)
        {
            joe.GiveCash(10);
            bank += 10;
            UpdateForm();
        }

        private void bobDeposit_Click(object sender, EventArgs e)
        {
            bob.GiveCash(5);
            bank += 5;
            UpdateForm();
        }

    }
}
