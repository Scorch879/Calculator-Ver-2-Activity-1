using System;
using System.Data; // For evaluating expressions
using System.Windows.Forms;

namespace Calculator_Ver_2_Activity_1
{
    public partial class Form1 : Form
    {
        private bool isDotUsed = false;

        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(Button_Click);
            button2.Click += new EventHandler(Button_Click);
            button3.Click += new EventHandler(Button_Click);
            button4.Click += new EventHandler(Button_Click);
            button5.Click += new EventHandler(Button_Click);
            button6.Click += new EventHandler(Button_Click);
            button7.Click += new EventHandler(Button_Click);
            button8.Click += new EventHandler(Button_Click);
            button9.Click += new EventHandler(Button_Click);
            button0.Click += new EventHandler(Button_Click);

            // Operator buttons (+, -, *, /)s
            btnAdd.Click += new EventHandler(Button_Click);
            btnSubtract.Click += new EventHandler(Button_Click);
            btnMultiply.Click += new EventHandler(Button_Click);
            btnDivide.Click += new EventHandler(Button_Click);

            // Special buttons (equals, dot, backspace)
            btnEquals.Click += new EventHandler(EqualsButton_Click);
            btnDot.Click += new EventHandler(DotButton_Click);
            btnBackspace.Click += new EventHandler(Delete_Click);
            btnClear.Click += new EventHandler(ClearButton_Click);
            btnToggleSign.Click += new EventHandler(ToggleSignButton_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (txtDisplay.Text == "0" && clicked.Text != "." && clicked.Text != "-" || txtDisplay.Text == "undefined" || txtDisplay.Text == "Error")
            {
                txtDisplay.Text = clicked.Text;
            }
            else if (txtDisplay.Text == "0" && clicked.Text == "-")
            {
                txtDisplay.Text = "-";
            }
            else
            {
                txtDisplay.Text += clicked.Text;
            }
         }
        
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text.Contains("/0"))
                    throw new DivideByZeroException();

                double result = Eval(txtDisplay.Text);
                txtDisplay.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "undefined";
            }
            catch (Exception)
            {
                txtDisplay.Text = "Error";
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            string currentText = txtDisplay.Text;


            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0.";
            }
            else
            {

                string lastNumber = currentText.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.None).Last();

                if (!lastNumber.Contains("."))
                {
                    txtDisplay.Text += ".";
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {

                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            else
            {

                txtDisplay.Text = "0";
            }
        }

        private void ToggleSignButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private double Eval(string text)
        {
            DataTable dataTable = new DataTable();
            return Convert.ToDouble(dataTable.Compute(text, string.Empty));
        }
    }
}
