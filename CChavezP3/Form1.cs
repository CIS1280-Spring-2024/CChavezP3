
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CChavezP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSumbit_Click(object sender, EventArgs e)
        {
            //•	Error Handling: Wrap the submit button code in a try/catch block.
            //  At least catch the generic exception class and display the
            //  exception’s error message to the results text box if the user
            //  fails to input correct values.
            try
            {
                //  1.Instantiate a LogoOrderItem using the two parameter constructor.
                //  Uset the Text TextBox’s Text property and the Checkbox’s Checked property
                //  for the two arguments needed for the constructor.
                bool hasLogo = false;
                string customText = txtCustom.Text;
                if (chbLogo.Checked) hasLogo = true;
                LogoOrderItem orderItem = new LogoOrderItem(hasLogo, customText);
                //  2.Read the values of the remaining items on the form and set the appropriate
                //  properties in your LogoOrderItem
                orderItem.OrderNum = int.Parse(txtOrderNum.Text);
                orderItem.NumItems = int.Parse(txtOrderNum.Text);
                orderItem.NumColors = int.Parse(txtOrderNum.Text);
                
                //  3.You will need to use if statements for your radio buttons. Make sure to code
                //  this efficiently
                if (rbUsb.Checked) orderItem.ItemType = rbUsb.Text;
                else if (rbMug.Checked) orderItem.ItemType = rbMug.Text;
                else if (rbPen.Checked) orderItem.ItemType = rbUsb.Text;

                //  5.Once all properties in the LogoOrderItem are set, just set the LogoOrderItems
                //  GetOrderSummary method to set the results into a text box at the bottom of the
                //  form so that the user can see the result.
                string output = orderItem.GetOrderSummery();
                txtOutput.Text = output;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error in btnSumbit_Click! " + exc.Message + "\nException type: " + exc.GetType());
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderNum.Text = null;
            txtNumItems.Text = null;
            if (rbUsb.Checked) rbUsb.Checked = false;
            if (rbMug.Checked) rbMug.Checked = false;
            if (rbPen.Checked) rbPen.Checked = false;
            txtCustom.Text = null;
            ((CheckBox)chbLogo).Checked = false;
            txtOutput.Text = null;
        }
    }
}
