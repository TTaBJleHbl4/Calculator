using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(300, 400);
            this.Text = "Калькулятор";

            // Создание текстового поля
            TextBox textBox = new TextBox
            {
                Size = new System.Drawing.Size(260, 20),
                Location = new System.Drawing.Point(10, 10),
                TextAlign = HorizontalAlignment.Right
            };
            this.Controls.Add(textBox);

            // Создание кнопок
            Button[] buttons = new Button[16];
            string[] buttonLabels = { "7", "8", "9", "/",
                                      "4", "5", "6", "*",
                                      "1", "2", "3", "-",
                                      "0", ".", "=", "+" };

            int x = 10, y = 40;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button
                {
                    Size = new System.Drawing.Size(60, 60),
                    Location = new System.Drawing.Point(x, y),
                    Text = buttonLabels[i]
                };
                buttons[i].Click += Button_Click;
                this.Controls.Add(buttons[i]);
                x += 65;
                if ((i + 1) % 4 == 0)
                {
                    x = 10;
                    y += 65;
                }
            }

            // Создание кнопки "C"
            Button clearButton = new Button
            {
                Size = new System.Drawing.Size(260, 60),
                Location = new System.Drawing.Point(10, y),
                Text = "C"
            };
            clearButton.Click += (sender, args) =>
            {
                textBox.Text = "0";
            };
            this.Controls.Add(clearButton);
        }

        private double resultValue = 0;
        private string operationPerformed = "";
        private TextBox textBox;

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox == null)
            {
                textBox = (TextBox)this.Controls[0];
            }

            if (button.Text == "=")
            {
                try
                {
                    switch (operationPerformed)
                    {
                        case "+":
                            textBox.Text = (resultValue + double.Parse(textBox.Text)).ToString();
                            break;

                        case "-":
                            textBox.Text = (resultValue - double.Parse(textBox.Text)).ToString();
                            break;
                        case "*":
                            textBox.Text = (resultValue * double.Parse(textBox.Text)).ToString();
                            break;
                        case "/":
                            if (double.Parse(textBox.Text) != 0)
                            {
                                textBox.Text = (resultValue / double.Parse(textBox.Text)).ToString();
                            }
                            else
                            {
                                textBox.Text = "Ошибка";
                            }
                            break;
                    }
                    resultValue = double.Parse(textBox.Text);
                    operationPerformed = "";
                }
                catch (Exception ex)
                {
                    textBox.Text = "Ошибка";
                }
            }
            else if (button.Text == "+" || button.Text == "-" || button.Text == "*" || button.Text == "/")
            {
                operationPerformed = button.Text;
                if (double.TryParse(textBox.Text, out double resultValue))
                {
                    // Код, использующий resultValue
                    textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Некорректный ввод.");
                }
            }
            else
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = button.Text;
                }
                else
                {
                    textBox.Text += button.Text;
                }
            }
        }
    }
}