using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlishaHuang_InClass1
{
    public partial class Calculator : Form
    {
        //set global variables
        string input = string.Empty;
        double? x = null;
        double? y = null;
        char pendingAction;
        bool newEquation = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "";
        }

        //Display number when the user clicks on the button of numbers.
        private void num1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 1;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 1;
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 2;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 2;
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 3;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 3;
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 4;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 4;
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 5;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 5;
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 6;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 6;
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 7;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 7;
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 8;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 8;
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 9;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 9;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newEquation == true)
            {
                txtDisplayResult.Text = "";
                expression.Text = "";
                newEquation = false;

                txtDisplayResult.Text += btn.Text;
                input += 0;
            }
            else
            {
                txtDisplayResult.Text += btn.Text;
                input += 0;
            }
        }

        //clearn all datas when the user clicks on the C
        private void buttonC_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "";
            expression.Text = "";
            input = "";
            x = null;
            y = null;
            pendingAction = '\0';
            newEquation = true;
        }

        //clearn the data of textBox when the user clicks on the CE
        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "";
            input = "";

            //if equation is ended, and the text of label will be cleared. 
            if (newEquation == true)
            {
                expression.Text = "";
            }
        }

        //the methods for the operators
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            x = double.Parse(input);
            pendingAction = '+';
            Button btn = (Button)sender;
            txtDisplayResult.Text += btn.Text;                
            input = "";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            x = double.Parse(input);
            pendingAction = '-';
            Button btn = (Button)sender;
            txtDisplayResult.Text += btn.Text;
            input = "";
        }

        private void buttonMutiply_Click(object sender, EventArgs e)
        {
            x = double.Parse(input);
            pendingAction = '*';
            Button btn = (Button)sender;
            txtDisplayResult.Text += btn.Text;
            input = "";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            x = double.Parse(input);
            pendingAction = '/';
            Button btn = (Button)sender;
            txtDisplayResult.Text += btn.Text;
            input = "";
        }

        //method for calculating the result
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            newEquation = true;
            Button btn = (Button)sender;
            y = double.Parse(input);
            double result;

            if (pendingAction == '+')
            {
                txtDisplayResult.Text += btn.Text;
                result = (double)(x + y);
                expression.Text = txtDisplayResult.Text;
                txtDisplayResult.Text = result.ToString();
                x = null;
                y = null;
                input = "";
            }
            else if (pendingAction == '-')
            {
                txtDisplayResult.Text += btn.Text;
                result = (double)(x - y);
                expression.Text = txtDisplayResult.Text;
                txtDisplayResult.Text = result.ToString();
                x = null;
                y = null;
                input = "";
            }
            else if (pendingAction == '*')
            {
                txtDisplayResult.Text += btn.Text;
                result = (double)(x * y);
                expression.Text = txtDisplayResult.Text;
                txtDisplayResult.Text = result.ToString();
                x = null;
                y = null;
                input = "";
            }
            else if (pendingAction == '/')
            {
                txtDisplayResult.Text += btn.Text;
                result = (double)(x / y);
                expression.Text = txtDisplayResult.Text;
                txtDisplayResult.Text = result.ToString();
                x = null;
                y = null;
                input = "";
            }

        }
    }
}
