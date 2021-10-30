using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int firstNumber = (int)numericUpDownFirstNumber.Value;
            int secondNumber = (int)numericUpDownSecondNumber.Value;

            textBoxResult.Text = (firstNumber + secondNumber).ToString();
        }
    }
}
