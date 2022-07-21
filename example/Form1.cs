using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rBoxConvertAscii_CheckedChanged(object sender, EventArgs e)
        {
            string hex = tBoxDataIn.Text;
           
            if (rBoxConvertAscii.Checked) {
                hex = hex.Replace("-", "");
                String ascii = "";
                for (int i = 0; i < hex.Length; i += 2)
                {

                    // extract two characters from hex string
                    String part = hex.Substring(i, 2);

                    // change it into base 16 and
                    // typecast as the character
                    char ch = (char)Convert.ToInt32(part, 16); ;

                    // add this char to final ASCII string
                    ascii = ascii + ch;
                }
                tBoxDataIn.Text = ascii;
            }
            
            

        }
        
        private void rButtonConvertHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonConvertHex.Checked)
            {
             byte[] ba = Encoding.Default.GetBytes(tBoxDataIn.Text);
                var hexString = BitConverter.ToString(ba);
                //hexString = hexString.Replace("-", "");
                tBoxDataIn.Text = hexString;
            }
           
               
           
        }
    }
}
