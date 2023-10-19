using System;
using System.Diagnostics.CodeAnalysis;

namespace WinFormsApp3
{
	public partial class Form1 : Form
	{
		private decimal fisrtValue = 0m;
		private decimal secondValue = 0m;
		private string Operator = "";
		private bool stateScreen = true;
		private bool stateEnd = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void NumberClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (stateEnd)
			{
				this.ClearAll();
				stateEnd = false;
			}
			if (Screen.Text == "0")
				Screen.Text = button.Text;
			else
				Screen.Text += button.Text;
		}

		private void OperatorClick(object sender, EventArgs e)
		{
			Button opr = (Button)sender;

			if (!stateScreen)
			{
				Operator = opr.Text;
				char[] charArr = screenLabel.Text.ToCharArray();
				charArr[charArr.Length - 1] = Convert.ToChar(opr.Text); // freely modify the array
				screenLabel.Text = new string(charArr);
			}
			else
			{
				decimal num = Convert.ToDecimal(Screen.Text);
				fisrtValue = (fisrtValue == 0) ? num : this.Calculate(fisrtValue, num, Operator);
				screenLabel.Text = $"{fisrtValue}{opr.Text}";
				Operator = opr.Text;
				Screen.Text = "0";
				stateScreen = false;
				stateEnd = false;

			}
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			if (!Screen.Text.Contains("."))
				Screen.Text += ".";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.ClearAll();
			stateScreen = true;
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (Screen.Text.Length > 0)
				Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
			if (Screen.Text == "")
				Screen.Text = "0";
		}
		private void btnSign_Click(object sender, EventArgs e)
		{
			if (Screen.Text.Contains("-"))
				Screen.Text = Screen.Text.Trim('-');
			else
				Screen.Text = "-" + Screen.Text;
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
            if (screenLabel.Text == "")
            {
                fisrtValue = secondValue = 0m;
                screenLabel.Text = $"{Screen.Text}=";
            }
            else if (!stateEnd)
            {
                secondValue = Convert.ToDecimal(Screen.Text);
                decimal result = this.Calculate(fisrtValue, secondValue, Operator);
                if (result == fisrtValue && Operator == "/")
                {
					MessageBox.Show("Cannot divide 0");                    
                }
                else
                {
                    Screen.Text = $"{result}";
                    screenLabel.Text = $"{fisrtValue}{Operator}{secondValue}=";
                    fisrtValue = 0m;
                }                
            }
            stateEnd = true;

        }

		private void Screen_TextChanged(object sender, EventArgs e)
		{
			stateScreen = true;
		}


		private void btnCE_Click(object sender, EventArgs e)
		{
			Screen.Text = "0";
		}

		private decimal Calculate(decimal num1, decimal num2, string opr)
		{
			switch (opr)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "%":
					if (num2 == 0)
					{
						return num1;
					}
					return num1 % num2;
				case "/":
					if (num2 == 0)
					{						
						num2 = 1;
                    }										
					return num1 / num2;
			}
			return 0;
		}

		private void ClearAll()
		{
			screenLabel.Text = "";
			Screen.Text = "0";
			fisrtValue = 0m;
			secondValue = 0m;
		}

		private void Screen_KeyPress(object sender, KeyPressEventArgs e)
		{

			TextBox txtbox = (sender as TextBox);

			if (txtbox.Text == "0")
			{
				txtbox.Text = "";
			}
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
			(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && txtbox.Text.IndexOf('.') > -1 && txtbox.Text != "")
			{
				e.Handled = true;
			}
			switch (e.KeyChar)
			{
				case '+':
					btnAdd.PerformClick();
					return;
				case '-':
					btnSub.PerformClick();
					return;
				case '*':
					btnMul.PerformClick();
					return;
				case '/':
					btnDiv.PerformClick();
					return;
				case '%':
					btnMod.PerformClick();
					return;
				case '=':
					if (Screen.Text == "")
					{
						Screen.Text = "0";
                    }
					btnEqual.PerformClick();
					return;
			}
		}

		private void btn1PhanX_Click(object sender, EventArgs e)
		{
			decimal num = Convert.ToDecimal(Screen.Text);

			if (num == 0)
			{
				MessageBox.Show("Cannot divide by 0");				
                return;
			}
            screenLabel.Text = $"1 / {num}";
            Screen.Text = $"{1 / num}";
		}

		private void btnBinhPhuong_Click(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(Screen.Text);
            screenLabel.Text = $"sqr( {num} )";
            Screen.Text = $"{Math.Pow(num, 2)}";
		}

		private void btnSquareRoot_Click(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(Screen.Text);
			if (num < 0)
			{
                screenLabel.Text = $"sqrt( {num} )";
                Screen.Text = "Invalid input";
				return;
			}
            screenLabel.Text = $"sqrt( {num} )";
            Screen.Text = $"{Math.Sqrt(num)}";
		}
	}
}