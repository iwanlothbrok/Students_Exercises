using System;
using System.Windows.Forms;

namespace NumericSystemConverter
{
    public partial class Form1 : Form
    {
        private TextBox lastSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetLastSelected(object sender, KeyEventArgs e)
        {
            if (!(sender is TextBox t))
            {
                return;
            }

            lastSelected = t;
            SetLabel();
        }

        private void SetLabel() 
        {
            const string Message = "От бройна система: ";

            if (lastSelected.Name.Equals(txtDesetichna.Name))
            {
                lblInfo.Text = Message + "Десетична";
            }
            else if (lastSelected.Name.Equals(txtDvoichna.Name))
            {
                lblInfo.Text = Message + "Двоична";
            }
            else if (lastSelected.Name.Equals(txtOsmichna.Name))
            {
                lblInfo.Text = Message + "Осмична";
            }
            else if (lastSelected.Name.Equals(txtShest.Name))
            {
                lblInfo.Text = Message + "Шестнайсетична";
            }

        }

        string decToOther(double number, int system)
        {
            int whole = (int)number;
            if (number == whole)
            {
                return Convert.ToString(whole, system);
            }
            int fractional = int.Parse(Math.Round(number - (double)whole, 3).ToString().Substring(2));
            return Convert.ToString(whole, system) + "." + Convert.ToString(fractional, system);
        }

        double otherToDec(string number, int system)
        {
            number = number.Replace(",", ".");
            if (!number.Contains("."))
            {
                return Convert.ToInt32(number, system);
            }

            string[] digits = number.Split('.');

            return (double)(Convert.ToInt32(digits[0], system)) +
                double.Parse("0." + Convert.ToInt32(digits[1], system));
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double number = GetDecimal();

            string hex = decToOther(number, 16);
            string oct = decToOther(number, 8);
            string bin = decToOther(number, 2);

            txtOsmichna.Text = oct;
            txtDvoichna.Text = bin;
            txtShest.Text = hex;
            txtDesetichna.Text = number.ToString();
        }

        private double GetDecimal() 
        {
            double result = 0;

            if (lastSelected.Name.Equals(txtDesetichna.Name))
            {
                result = double.Parse(txtDesetichna.Text);
            }
            else if (lastSelected.Name.Equals(txtDvoichna.Name))
            {
                result = otherToDec(txtDvoichna.Text, 2);
            }
            else if (lastSelected.Name.Equals(txtOsmichna.Name))
            {
                result = otherToDec(txtOsmichna.Text, 8);
            }
            else if (lastSelected.Name.Equals(txtShest.Name))
            {
                result = otherToDec(txtShest.Text, 16);
            }

            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (!(item is TextBox txt))
                {
                    continue;
                }

                txt.ResetText();
            }
        }
    }
}
