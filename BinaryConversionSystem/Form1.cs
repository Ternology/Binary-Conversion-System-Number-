using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BinaryConversionSystem;

namespace BinaryConversionSystem
{
    public partial class Form1 : Form
    {
        ConversionSystem conversion = new ConversionSystem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conversion.NumConverter(textBox1.Text);

            BinaryBox.Text = conversion.BinaryOutput;
            DecimalBox.Text = conversion.DecimalOutput;
            HexBox.Text = conversion.HexOutput;
            OctalBox.Text = conversion.OctalOutput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conversion.ResetNumConvert(textBox1);

            conversion.ResetNumConvert(BinaryBox);
            conversion.ResetNumConvert(DecimalBox);
            conversion.ResetNumConvert(HexBox);
            conversion.ResetNumConvert(OctalBox);
        }

        private void openASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversion.ShowASCII();
        }

        private void resetResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversion.ResetNumConvert(textBox1);

            conversion.ResetNumConvert(BinaryBox);
            conversion.ResetNumConvert(DecimalBox);
            conversion.ResetNumConvert(HexBox);
            conversion.ResetNumConvert(OctalBox);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void binaryConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not yet Added.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void decimalConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not yet Added.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void hexadecimalConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not yet Added.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void octalConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not yet Added.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Lester Leal a Simple Binary Conversion System (Number)", "CREDITS", MessageBoxButtons.OK);
        }
    }
}