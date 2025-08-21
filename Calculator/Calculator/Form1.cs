using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void txtExpression1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                if (e.KeyChar < 'A' || e.KeyChar > 'z')
                {
                    e.Handled = false;
                }
            }
            catch
            {

            }

        }

        private void txtExpression2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                if (e.KeyChar < 'A' || e.KeyChar > 'z')
                {
                    e.Handled = false;
                }
            }
            catch
            {

            }
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperator.Text == "+")
            {
                btnMinus.Visible = false;
                btnMultiply.Visible = false;
                btnDevide.Visible = false;
            }
            else if (cmbOperator.Text == "-")
            {
                btnPlus.Visible = false;
                btnMultiply.Visible = false;
                btnDevide.Visible = false;
            }
            else if (cmbOperator.Text == "*")
            {
                btnPlus.Visible = false;
                btnMinus.Visible = false;
                btnDevide.Visible = false;
            }
            else if (cmbOperator.Text == "/")
            {
                btnPlus.Visible = false;
                btnMinus.Visible = false;
                btnMultiply.Visible = false;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double Answer = 0;
            Answer = Convert.ToDouble(txtExpression1.Text) + Convert.ToDouble(txtExpression2.Text);
            txtResult.Text += +Answer;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double Answer = 0;
            Answer = Convert.ToDouble(txtExpression1.Text) - Convert.ToDouble(txtExpression2.Text);
            txtResult.Text += +Answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double Answer;
            Answer = Convert.ToDouble(txtExpression1.Text) * Convert.ToDouble(txtExpression2.Text);
            txtResult.Text = "" + Answer;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            double Answer;
            Answer = Convert.ToDouble(txtExpression1.Text) / Convert.ToDouble(txtExpression2.Text);
            txtResult.Text = "" + Answer;
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' & e.KeyChar > '9' & e.KeyChar < 'A' & e.KeyChar > 'z')
            {
                e.Handled = false;
            }

        }


    }
}
