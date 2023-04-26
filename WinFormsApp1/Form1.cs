namespace WinFormsApp1
{
	public partial class Form : System.Windows.Forms.Form
	{
		private float a, b;
		private int count;

		private void Calculate()
		{
			try
			{
				switch (count)
				{
					case 1:
						b = a + float.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 2:
						b = a - float.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 3:
						b = a * float.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 4:
						float divider;
						divider = float.Parse(textBox1.Text);
						if (divider == 0)
							MessageBox.Show("Внимание! Деление на ноль!");
						else
						{
							b = a / divider;
							textBox1.Text = b.ToString();
						}
						break;

					default:
						break;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		public Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				textBox1.Clear();
				count = 1;
			}
			catch (FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				textBox1.Clear();
				count = 2;
			}
			catch (FormatException)
			{
				textBox1.Text = "-";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				textBox1.Clear();
				count = 3;
			}
			catch (FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				textBox1.Clear();
				count = 4;
			}
			catch (FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 1;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 2;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 3;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				if (a < 0)
				{
					MessageBox.Show("Внимание! Аргумент отрицательный!");
				}
				else
				{
					b = (float)Math.Sqrt(a);
					textBox1.Text = b.ToString();
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 4;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 5;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 6;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				b = (float)Math.Pow(a, 2);
				textBox1.Text = b.ToString();
			}
			catch(FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 7;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 8;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 9;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			try
			{
				a = float.Parse(textBox1.Text);
				if (a == 0)
				{
					MessageBox.Show("Внимание! Деление на ноль!");
				}
				else
				{
					b = 1 / a;
					textBox1.Text = b.ToString();
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Внимание! Неправильно набрано число!");
			}
			
		}

		private void button17_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + ",";
		}

		private void button18_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 0;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void button20_Click(object sender, EventArgs e)
		{
			Calculate();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
