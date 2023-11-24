using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        
        public FrmBasicCalculator()
        {
            InitializeComponent();

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToInt32(txtInput1.Text);
            float num2 = Convert.ToInt32(txtInput2.Text);
            float total;

            if (cbOperator.SelectedIndex == 0)
            {
                total = BasicComputation.Addition(num1, num2);
                lblTotal.Text = total.ToString();

            }
            else if (cbOperator.SelectedIndex == 1)
            {
                total = BasicComputation.Subtraction(num1, num2);
                lblTotal.Text = total.ToString();
            }
            else if(cbOperator.SelectedIndex == 2)
            {
                total = BasicComputation.Multiplication(num1, num2);
                lblTotal.Text = total.ToString();
            }
            else if( cbOperator.SelectedIndex == 3)
            {
                total = BasicComputation.Division(num1, num2);
                lblTotal.Text = total.ToString();
            }
        }
    }

}
