using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Input_TextBox.Text = "";
            Output_TextBox.Text = "";
        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            string inputDir = Input_TextBox.Text;
            string outputDir = Output_TextBox.Text;

            string inputContent;

            //using (var input = new FileStream(inputDir, FileMode.Open))
            //{
            //    // read input content
            //}

            // Convert

            // output content

            //If success 
            Clear_Button_Click(this, null);
            //Not success
                // System dialog ismetam

        }
    }
}
