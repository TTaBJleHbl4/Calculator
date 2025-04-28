using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace калькулятор
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 52);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(70, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(128, 220);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 52);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(186, 104);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(52, 52);
            this.buttonMultiply.TabIndex = 9;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(186, 162);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(52, 52);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(70, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(52, 52);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(186, 276);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(52, 52);
            this.buttonDivision.TabIndex = 12;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(226, 20);
            this.textBoxResult.TabIndex = 14;
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(186, 218);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(52, 52);
            this.buttonSubstract.TabIndex = 15;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 278);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(52, 52);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 35);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentOperation.TabIndex = 17;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(128, 276);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(52, 52);
            this.buttonEqual.TabIndex = 18;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.buttonEqual);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button buttonEqual;
    }
}
FORM1
using System;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        private double _result = 0;
        private string _operation = "";
        private bool _isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            buttonAdd.Click += OperationButton_Click;
            buttonSubstract.Click += OperationButton_Click;
            buttonMultiply.Click += OperationButton_Click;
            buttonDivision.Click += OperationButton_Click;
            buttonEqual.Click += ButtonEqual_Click;
            buttonClear.Click += ButtonClear_Click;

            foreach (var button in new[] { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9 })
            {
                button.Click += NumberButton_Click;
            }
        }

        private void InitializeButtons()
        {
            // Номера кнопок
            button1.Click += NumberButton_Click;
            button2.Click += NumberButton_Click;
            button3.Click += NumberButton_Click;
            button4.Click += NumberButton_Click;
            button5.Click += NumberButton_Click;
            button6.Click += NumberButton_Click;
            button7.Click += NumberButton_Click;
            button8.Click += NumberButton_Click;
            button9.Click += NumberButton_Click;
            button0.Click += NumberButton_Click;

            // Операции
            buttonAdd.Click += OperationButton_Click;
            buttonSubstract.Click += OperationButton_Click;
            buttonMultiply.Click += OperationButton_Click;
            buttonDivision.Click += OperationButton_Click;

            // Кнопки действий
            buttonEqual.Click += ButtonEqual_Click;
            buttonClear.Click += ButtonClear_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || _isOperationPerformed)
                textBoxResult.Clear();

            _isOperationPerformed = false;
            Button button = (Button)sender;
            textBoxResult.Text += button.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (_isOperationPerformed)
            {
                _operation = ((Button)sender).Text;
                return;
            }

            Button operationButton = (Button)sender;

            if (_result != 0)
            {
                ButtonEqual_Click(sender, e);
            }
            else
            {
                _result = double.Parse(textBoxResult.Text);
            }

            _operation = operationButton.Text;
            labelCurrentOperation.Text = $"{_result} {_operation}";
            _isOperationPerformed = true;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case "+":
                    textBoxResult.Text = (_result + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (_result - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (_result * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBoxResult.Text) != 0)
                        textBoxResult.Text = (_result / double.Parse(textBoxResult.Text)).ToString();
                    else
                        MessageBox.Show("Деление на ноль невозможно.");
                    break;
                default:
                    break;
            }
            _result = double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
            _operation = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            _result = 0;
            _operation = "";
            labelCurrentOperation.Text = "";
        }

        private void labelCurrentOperation_Click(object sender, EventArgs e)
        {

        }
    }
}
Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
