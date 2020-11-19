using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this function is used for taking only numaric value in the bill text box
        private void billbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //this function is used for changing the text in Bill box to empty
        private void billbox_Click(object sender, EventArgs e)
        {
            billbox.Text = "";
        }

        //this function is used to decrease the tip percentage by 10 and checks if the value in the bill text box is not enpty and grater than 0.
        private void Tipdecrbutton(object sender, EventArgs e)
        {
            try
            {
                
                if (int.Parse(tipbox.Text.Trim('%')) > 0)
                {
                    tipbox.Text = (int.Parse(tipbox.Text.Trim('%')) - 10).ToString() + "%";
                }

                if ((string.IsNullOrWhiteSpace(billbox.Text)) || (float.Parse(billbox.Text) <= 0))
                {
                    MessageBox.Show("please enter the amount in the bill box");
                }
            }
            catch
            {

            }
        }
        //this function is used to increase the tip percentage by 10 and checks if the value in the bill text box is not enpty and grater than 0.
        private void Tipincrbutton(object sender, EventArgs e)
        {
            try
            {
                
                if (int.Parse(tipbox.Text.Trim('%')) < 100)
                {
                    tipbox.Text = (int.Parse(tipbox.Text.Trim('%')) + 10).ToString() + "%";
                }

                if ((string.IsNullOrWhiteSpace(billbox.Text)) || (float.Parse(billbox.Text) <= 0))
                {
                    tipbox.Text = "0%";
                    MessageBox.Show("please enter the amount in the bill box");
                }
            }
            catch 
            {

            }

        }
        //this function is used to increase the no of people by 1 and checks if the value in the bill text box is not enpty and grater than 0.
        private void peopleincrbutton_Click(object sender, EventArgs e)
        {
            try
            {
                peoplebox.Text = (int.Parse(peoplebox.Text) + 1).ToString();

                if ((string.IsNullOrWhiteSpace(billbox.Text)) || (float.Parse(billbox.Text) <= 0))
                {
                    peoplebox.Text = "0";
                    MessageBox.Show("please enter the amount in the bill box");
                }
            }
            catch
            {

            }
        }
        //this function is used to decrease the no of people by 1 and checks if the value in the bill text box is not enpty and grater than 0.
        private void peopledecrbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(peoplebox.Text) > 0)
                {
                    peoplebox.Text = (int.Parse(peoplebox.Text) - 1).ToString();
                }

                if ((string.IsNullOrWhiteSpace(billbox.Text)) || (float.Parse(billbox.Text) <= 0))
                {
                    MessageBox.Show("please enter the amount in the bill box");
                }
            }
            catch
            {

            }
        }

        //this function is used to change the value of the tip per person and the total per person as the value is entered in the Bill textBox
        private void billbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                //to claculate the value of tip per person and the total per person every time the new value is entered in the bill text box

                tipperpersonbox.Text = "$" + ((float.Parse(billbox.Text) / float.Parse(peoplebox.Text)) * float.Parse(tipbox.Text.Trim('%')) / 100).ToString("n");
                totalperpersonbox.Text = "$" + ((float.Parse(tipperpersonbox.Text.Trim('$'))) + (float.Parse(billbox.Text) / float.Parse(peoplebox.Text))).ToString("n");
            }
            catch (Exception)
            {

            }
        }

        //this function is used to change the value of the tip per person and the total per person as the value is entered in the tip Box
        private void tipbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //to claculate the value of tip per person and the total per person every time the new value is entered in the tip percentage box

                tipperpersonbox.Text = "$" + ((float.Parse(billbox.Text) / float.Parse(peoplebox.Text)) * float.Parse(tipbox.Text.Trim('%')) / 100).ToString("n");
                totalperpersonbox.Text = "$" + ((float.Parse(tipperpersonbox.Text.Trim('$'))) + (float.Parse(billbox.Text) / float.Parse(peoplebox.Text))).ToString("n");
            }
            catch
            {

            }
        }

        //this function is used to change the value of the tip per person and the total per person as the value is entered in the people per person Box
        private void peoplebox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //to claculate the value of tip per person and the total per person every time the new value is entered in the No of perple box

                tipperpersonbox.Text = "$" + ((float.Parse(billbox.Text) / float.Parse(peoplebox.Text)) * float.Parse(tipbox.Text.Trim('%')) / 100).ToString("n");
                totalperpersonbox.Text = "$" + ((float.Parse(tipperpersonbox.Text.Trim('$'))) + (float.Parse(billbox.Text) / float.Parse(peoplebox.Text))).ToString("n");
            }
            catch
            {
            }

        }

        //this function is used to check if the value in the box is Not a number or a infinite number and change it to the value $0.00 in the tip per person result box
        private void tipperpersonbox_TextChanged(object sender, EventArgs e)
        {
            if (float.IsNaN(float.Parse(tipperpersonbox.Text.Trim('$'))) || float.IsInfinity(float.Parse(tipperpersonbox.Text.Trim('$'))))
            {
                tipperpersonbox.Text = "$0.00";
            }
        }

        //this function is used to check if the value in the box is Not a number or a infinite number and change it to the value $0.00 in the total per person result box
        private void totalperpersonbox_TextChanged(object sender, EventArgs e)
        {
            if (float.IsNaN(float.Parse(totalperpersonbox.Text.Trim('$'))) || float.IsInfinity(float.Parse(totalperpersonbox.Text.Trim('$'))))
            {
                totalperpersonbox.Text = "$0.00";
            }
        }
    }
}
