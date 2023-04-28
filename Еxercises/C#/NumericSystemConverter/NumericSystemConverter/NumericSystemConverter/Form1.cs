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

            if (lastSelected.Name.Equals(txtDecimal.Name))
            {
                lblInfo.Text = Message + "Десетична";
            }
            else if (lastSelected.Name.Equals(txtBinary.Name))
            {
                lblInfo.Text = Message + "Двоична";
            }
            else if (lastSelected.Name.Equals(txtOctal.Name))
            {
                lblInfo.Text = Message + "Осмична";
            }
            else if (lastSelected.Name.Equals(txtHex.Name))
            {
                lblInfo.Text = Message + "Шестнайсетична";
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //int number = GetDecimal();

            //string hex = Convert.ToString(number, 16);
            //string oct = Convert.ToString(number, 8);
            //string bin = Convert.ToString(number, 2);

            //txtOctal.Text = oct;
            //txtBinary.Text = bin;
            //txtHex.Text = hex;
            //txtDecimal.Text = number.ToString();


            // Check which input field has a value
            if (!string.IsNullOrEmpty(txtDecimal.Text))
            {
                // Convert decimal to other formats
                double decimalValue = double.Parse(txtDecimal.Text);

                string binaryValue = Convert.ToString(BitConverter.DoubleToInt64Bits(decimalValue), 2);
                txtBinary.Text = binaryValue;

                string octalValue = Convert.ToString((long)decimalValue, 8);
                txtOctal.Text = octalValue;

                string hexValue = BitConverter.ToString(BitConverter.GetBytes(decimalValue)).Replace("-", string.Empty);
                txtHex.Text = hexValue;
            }
            else if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                // Convert binary to other formats
                string binaryValue = txtBinary.Text;

                double decimalValue = Convert.ToInt64(binaryValue, 2);
                txtDecimal.Text = decimalValue.ToString();

                string octalValue = Convert.ToString(Convert.ToInt64(binaryValue, 2), 8);
                txtOctal.Text = octalValue;

                string hexValue = Convert.ToString(Convert.ToInt64(binaryValue, 2), 16).ToUpper();
                txtHex.Text = hexValue;
            }
            else if (!string.IsNullOrEmpty(txtOctal.Text))
            {
                // Convert octal to other formats
                string octalValue = txtOctal.Text;

                double decimalValue = Convert.ToInt64(octalValue, 8);
                txtDecimal.Text = decimalValue.ToString();

                string binaryValue = Convert.ToString(Convert.ToInt64(octalValue, 8), 2);
                txtBinary.Text = binaryValue;

                string hexValue = Convert.ToString(Convert.ToInt64(octalValue, 8), 16).ToUpper();
                txtHex.Text = hexValue;
            }
            else if (!string.IsNullOrEmpty(txtHex.Text))
            {
                // Convert hexadecimal to other formats
                string hexValue = txtHex.Text;

                double decimalValue = BitConverter.ToDouble(BitConverter.GetBytes(Convert.ToUInt64(hexValue, 16)), 0);
                txtDecimal.Text = decimalValue.ToString();

                string binaryValue = Convert.ToString(BitConverter.DoubleToInt64Bits(decimalValue), 2);
                txtBinary.Text = binaryValue;

                string octalValue = Convert.ToString(Convert.ToInt64(hexValue, 16), 8);
                txtOctal.Text = octalValue;
            }
            else
            {
                MessageBox.Show("Please enter a number to convert.");
            }
        }


        //private int GetDecimal() 
        //{
        //    int result = 0;

        //    if (lastSelected.Name.Equals(txtDesetichna.Name))
        //    {
        //        result = int.Parse(txtDesetichna.Text);
        //    }
        //    else if (lastSelected.Name.Equals(txtDvoichna.Name))
        //    {
        //        result = Convert.ToInt32(txtDvoichna.Text, 2);
        //    }
        //    else if (lastSelected.Name.Equals(txtOsmichna.Name))
        //    {
        //        result = Convert.ToInt32(txtOsmichna.Text, 8);
        //    }
        //    else if (lastSelected.Name.Equals(txtShest.Name))
        //    {
        //        result = Convert.ToInt32(txtShest.Text, 16);
        //    }

        //    return result;
        //}

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
