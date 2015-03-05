using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsCSharp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void addButton_Click(object sender, EventArgs e)
        {

            string number1String = this.number1TextBox.Text;
            string number2String = this.number2TextBox.Text;

            int number1 = ConverterUtils.convertStringToInt(number1String);
            int number2 = ConverterUtils.convertStringToInt(number2String);
            int result = number1 + number2;
            
            this.resultTextBox.Text = "" + result;
        }
    }
}
