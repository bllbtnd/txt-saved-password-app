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

namespace PW_app_with_saved_pw
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "Text File Only|*.txt";
            String Fname = "";

            if (fd1.ShowDialog().Equals(DialogResult.OK))
            {
                Fname = fd1.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            this.Close();
            
        }
    }
}
