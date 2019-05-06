using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitner_Box_Flashcards
{
    public partial class Form1 : Form
    {
        short _currentCardNumber = 1;
        private StreamWriter OutputLine;
        string blk1 = @"    <Word ID=""";
        string blk2 = @""" Question=""";
        string blk3 = @""" Answer=""";
        string blk4 = @""" Date=""";
        string blk5 = @""" />";
        DateTime localDate = DateTime.Now;

        private readonly OpenFileDialog _chooseOutputFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            _chooseOutputFileDialog.FileOk += OnOutputFileDialogOk;
        }
        private void OnOutputFileDialogOk(object sender, CancelEventArgs e)
        {
            OutputFileName.Text = _chooseOutputFileDialog.FileName;

            FileStream Writing = new FileStream(OutputFileName.Text, FileMode.Append, FileAccess.Write, FileShare.None);
            OutputLine = new StreamWriter(Writing, UTF8Encoding.UTF8);

            if (OutputLine == null)
            {
                textBox4.Text = @"Output File is Invalid!";
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _chooseOutputFileDialog.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (OutputLine != null)
            {
                OutputLine.Close();
            }
            Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox4.Text = @"Current Card Number is Empty!";
                return;
            }


            _currentCardNumber = Convert.ToInt16(textBox1.Text);
            if (_currentCardNumber < 1)
            {
                textBox1.Text = @"Current Card Number is Invalid";
                return;
            }

            if (textBox2.Text == @"")
            {
                textBox4.Text = @"Question Box is Empty";
                return;
            }

            if (textBox3.Text == @"")
            {
                textBox4.Text = @"Answer Box is Empty";
                return;
            }

            if (textBox2.Text.Contains("\""))
            {
                textBox4.Text = @"Question contains the character """;
                return;
            }

            if (textBox3.Text.Contains("\""))
            {
                textBox4.Text = @"Answer contains the character """;
                return;
            }



            localDate = DateTime.Now;

            textBox2.Text = textBox2.Text.Replace("\n", "&#xD;&#xA;");
            textBox2.Text = textBox2.Text.Replace("\r", "");
            textBox3.Text = textBox3.Text.Replace("\n", "&#xD;&#xA;");
            textBox3.Text = textBox3.Text.Replace("\r", "");

            string outputLine = blk1 + textBox1.Text + blk2 + textBox2.Text + blk3 + textBox3.Text + blk4 + localDate + blk5;

            OutputLine.WriteLine(outputLine);
            _currentCardNumber += 1;
            textBox1.Text = _currentCardNumber.ToString();
            textBox2.Text = @"";
            textBox3.Text = @"";
        }
    }
}
