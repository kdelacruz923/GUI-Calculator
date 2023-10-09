using System.Data;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
           
        public Form1()
        {
            InitializeComponent();
            
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {

        }
             
        private void btnResult_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dataTable = new DataTable();
                var result = dataTable.Compute(textBox1.Text, "");

                if (double.IsInfinity(Convert.ToDouble(result)))
                {
                    textBox1.Text = "Error: Division by zero or invalid expression.";
                }
                else
                {
                    textBox1.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Error: Invalid expression. Please enter a valid arithmetic expression.";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Button button = (Button)sender;
                textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
              

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        //Addition
        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        //Subtraction
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        //Multiplication
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        //Division
        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
          
        }

        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        // 1/X
        private void button19_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double currentValue))
            {
                if (currentValue != 0)
                {
                    double oneOverX = 1 / currentValue;
                    textBox1.Text = oneOverX.ToString();
                }
                else
                {
                    textBox1.Text = "Error:You cannot have zero denominator. Press Clear!";
                }
            }
        }
        //DarkMode Option
        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                tabPage1.BackColor = Color.DarkGray;
                tabPage1.ForeColor = Color.White;
            }
            else
            {
                tabPage1.BackColor = SystemColors.Control;
                tabPage1.ForeColor = Color.Black;
            }
        }

        private void optStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (optStandard.Checked)
            {
                btnSquared.Visible = false;
                btnFactorial.Visible = false;
                btnSine.Visible = false;
                btnCos.Visible = false;

                this.Size = new Size(594, 533);
            }
        }

                  
        //Scientific Operations

        //Squared
        private void btnSquared_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double currentValue))
            {
                double xSquaredResult = currentValue * currentValue;
                textBox1.Text = xSquaredResult.ToString();
            }

        }

        //Factorial
        private int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void btnFactorial_Click(object sender, EventArgs e)
        {
          if (int.TryParse(textBox1.Text, out int currentValue))
            {
                if (currentValue >= 0)
                {
                    int factorialResult = Factorial(currentValue);
                    textBox1.Text = factorialResult.ToString();
                }
                else
                {
                    textBox1.Text = "Error: Factorial of a negative number is undefined.";
                }
            }
            else
            {
                textBox1.Text = "Error: Invalid Input";
            }
        }

        //Sine 
        private void btnSine_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double currentValue))
            {
                double sineResult = Math.Sin(currentValue);
                textBox1.Text = sineResult.ToString();
            }
        }
        //Cosine
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double currentValue))
            {
                double cosineResult= Math.Cos(currentValue);
                textBox1.Text = cosineResult.ToString();
            }
        }
        private void optScientific_CheckedChanged(object sender, EventArgs e)
        {
            if (optScientific.Checked)
            {
                btnSquared.Visible = true;
                btnFactorial.Visible = true;
                btnSine.Visible = true;
                btnCos.Visible = true;

                this.Size = new Size(678, 533);
            }
        }
    }
}