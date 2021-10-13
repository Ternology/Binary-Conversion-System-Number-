
namespace BinaryConversionSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DecimalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HexBox = new System.Windows.Forms.TextBox();
            this.OctalBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BinaryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Number:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 22);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BinaryBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.OctalBox);
            this.groupBox2.Controls.Add(this.HexBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DecimalBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT (RESULT)";
            // 
            // DecimalBox
            // 
            this.DecimalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecimalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBox.Location = new System.Drawing.Point(162, 77);
            this.DecimalBox.Name = "DecimalBox";
            this.DecimalBox.ReadOnly = true;
            this.DecimalBox.Size = new System.Drawing.Size(283, 22);
            this.DecimalBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hexadecimal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Octal:";
            // 
            // HexBox
            // 
            this.HexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexBox.Location = new System.Drawing.Point(162, 118);
            this.HexBox.Name = "HexBox";
            this.HexBox.ReadOnly = true;
            this.HexBox.Size = new System.Drawing.Size(283, 22);
            this.HexBox.TabIndex = 6;
            // 
            // OctalBox
            // 
            this.OctalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OctalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OctalBox.Location = new System.Drawing.Point(162, 159);
            this.OctalBox.Name = "OctalBox";
            this.OctalBox.ReadOnly = true;
            this.OctalBox.Size = new System.Drawing.Size(283, 22);
            this.OctalBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(236, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(449, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "2";
            // 
            // BinaryBox
            // 
            this.BinaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BinaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryBox.Location = new System.Drawing.Point(162, 39);
            this.BinaryBox.Name = "BinaryBox";
            this.BinaryBox.ReadOnly = true;
            this.BinaryBox.Size = new System.Drawing.Size(283, 22);
            this.BinaryBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Binary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(449, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(449, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "16";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(451, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openASCIIToolStripMenuItem,
            this.stringToBinaryToolStripMenuItem,
            this.resetResultsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // openASCIIToolStripMenuItem
            // 
            this.openASCIIToolStripMenuItem.Name = "openASCIIToolStripMenuItem";
            this.openASCIIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openASCIIToolStripMenuItem.Text = "Open ASCII";
            this.openASCIIToolStripMenuItem.Click += new System.EventHandler(this.openASCIIToolStripMenuItem_Click);
            // 
            // stringToBinaryToolStripMenuItem
            // 
            this.stringToBinaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryConverterToolStripMenuItem,
            this.decimalConverterToolStripMenuItem,
            this.hexadecimalConverterToolStripMenuItem,
            this.octalConverterToolStripMenuItem});
            this.stringToBinaryToolStripMenuItem.Name = "stringToBinaryToolStripMenuItem";
            this.stringToBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringToBinaryToolStripMenuItem.Text = "Other Conversion";
            // 
            // resetResultsToolStripMenuItem
            // 
            this.resetResultsToolStripMenuItem.Name = "resetResultsToolStripMenuItem";
            this.resetResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetResultsToolStripMenuItem.Text = "Reset Results";
            this.resetResultsToolStripMenuItem.Click += new System.EventHandler(this.resetResultsToolStripMenuItem_Click);
            // 
            // binaryConverterToolStripMenuItem
            // 
            this.binaryConverterToolStripMenuItem.Name = "binaryConverterToolStripMenuItem";
            this.binaryConverterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.binaryConverterToolStripMenuItem.Text = "Binary Converter";
            this.binaryConverterToolStripMenuItem.Click += new System.EventHandler(this.binaryConverterToolStripMenuItem_Click);
            // 
            // decimalConverterToolStripMenuItem
            // 
            this.decimalConverterToolStripMenuItem.Name = "decimalConverterToolStripMenuItem";
            this.decimalConverterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.decimalConverterToolStripMenuItem.Text = "Decimal Converter";
            this.decimalConverterToolStripMenuItem.Click += new System.EventHandler(this.decimalConverterToolStripMenuItem_Click);
            // 
            // hexadecimalConverterToolStripMenuItem
            // 
            this.hexadecimalConverterToolStripMenuItem.Name = "hexadecimalConverterToolStripMenuItem";
            this.hexadecimalConverterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.hexadecimalConverterToolStripMenuItem.Text = "Hexadecimal Converter";
            this.hexadecimalConverterToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalConverterToolStripMenuItem_Click);
            // 
            // octalConverterToolStripMenuItem
            // 
            this.octalConverterToolStripMenuItem.Name = "octalConverterToolStripMenuItem";
            this.octalConverterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.octalConverterToolStripMenuItem.Text = "Octal Converter";
            this.octalConverterToolStripMenuItem.Click += new System.EventHandler(this.octalConverterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINARY CONVERSION SYSTEM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DecimalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OctalBox;
        private System.Windows.Forms.TextBox HexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BinaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octalConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

