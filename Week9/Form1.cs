using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = System.IO.File.OpenText(@"C:\Users\Gurpreet Singh\Desktop\1874357.txt");
            string line;
            while (reader.EndOfStream == false )
            {
                line = reader.ReadLine();
                listBox1.Items.Add(line);
            }

            reader.Close();

        }
    }
}
