using System;
using System.Data; // For evaluating expressions
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator_Ver_2_Activity_1
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
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

            // Operator buttons 
            btnAdd.Click += new EventHandler(Button_Click);
            btnSubtract.Click += new EventHandler(Button_Click);
            btnMultiply.Click += new EventHandler(Button_Click);
            btnDivide.Click += new EventHandler(Button_Click);

            // Special buttons 
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
            string currentText = txtDisplay.Text.Trim();

            if (txtDisplay.Text == "0" && clicked.Text != "." && clicked.Text != "-" || txtDisplay.Text == "undefined" || txtDisplay.Text == "Error")
            {
                txtDisplay.Text = clicked.Text;
            }
            else if (txtDisplay.Text == "0" && clicked.Text == "-")
            {
                txtDisplay.Text = "-";
            }
            else if ("+-*/".Contains(clicked.Text))
            {
                if (currentText.Length > 0 && "+-*/".Contains(currentText.Last()))
                {
                    txtDisplay.Text = currentText.Remove(currentText.Length - 1) + clicked.Text;
                }
                else
                {
                    txtDisplay.Text += clicked.Text;
                }
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
            if (!string.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != "0")
            {
                string currentText = txtDisplay.Text;
                string[] parts = currentText.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    if (parts.Length == 1)
                    {
                        if (currentText.StartsWith("-"))
                        {
                            currentText = currentText.Substring(1);
                        }
                        else
                        {
                            currentText = "-" + currentText;
                        }
                    }
                    else
                    {
                        string lastPart = parts.Last();
                        if (!string.IsNullOrEmpty(lastPart))
                        {
                            int lastIndex = currentText.LastIndexOf(lastPart);
                            if (lastIndex > 0 && currentText[lastIndex - 1] == '-')
                            {
                                currentText = currentText.Substring(0, lastIndex - 1) + "+" + lastPart;
                            }
                            else if (lastIndex > 0 && currentText[lastIndex - 1] == '+')
                            {
                                currentText = currentText.Substring(0, lastIndex - 1) + "-" + lastPart;
                            }

                            else
                            {
                                currentText = currentText.Substring(0, lastIndex) + "-" + lastPart;
                            }
                        }


                    }
                }
                txtDisplay.Text = currentText;
            }
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