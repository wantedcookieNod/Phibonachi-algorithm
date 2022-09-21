using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1=1, p2=1,p3,k;
            k = Convert.ToInt32(textBox1.Text);
            label1.Text += p1 + "   ";
            
           for (int i=1;i<=k;i++)
            {
                p3 = p1 + p2;
                label1.Text += p3 + "   ";
                p1 = p3 + p2;
                label1.Text += p1 + "   ";
                p2 = p3 + p1;
                label1.Text += p2 + "   ";
            }
        }
    }
}
    