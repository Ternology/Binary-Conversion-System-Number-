using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace BinaryConversionSystem
{
    public class Conversion
    {
        public int _binary = 2;
        public int _decimal = 10;
        public int _hexadecimal = 16;
        public int _octal = 8;
    }
    public class ConversionSystem
    {
        public string BinaryOutput;
        public string DecimalOutput;
        public string HexOutput;
        public string OctalOutput;

        bool NumConver = false;
        public void NumConverter(string _input)
        {
            Conversion conversion = new Conversion();

            NumConver = true;

            if (NumConver)
            {
                if (string.IsNullOrEmpty(_input))
                {
                    MessageBox.Show("Error you must enter a number First!", "Error Conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int NumConvert = int.Parse(_input);

                    BinaryOutput = Convert.ToString(NumConvert, conversion._binary);

                    DecimalOutput = Convert.ToString(NumConvert, conversion._decimal);

                    HexOutput = Convert.ToString(NumConvert, conversion._hexadecimal);

                    OctalOutput = Convert.ToString(NumConvert, conversion._octal);
                }
            }
        }

        public void ResetNumConvert(TextBox _input)
        {
            BinaryOutput = "";
            DecimalOutput = "";
            HexOutput = "";
            OctalOutput = "";

            _input.Text = "";
        }

        public void ShowASCII()
        {
            MessageBox.Show("This is not the Perfect ASCII Table LOL");
            Process.Start(@"ASCIIConsole\ASCIITable.exe");
        }
    }
}
