using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1
{
    public partial class Formcau2 : Form
    {
        public Formcau2()
        {
            InitializeComponent();
        }
        bool NT(long n)
        {
            bool nt = true;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    nt = false;
                    break;
                }
            return nt;
        }
        private void btnSnt_Click(object sender, EventArgs e)
        {
            long n = long.Parse(txtN.Text);
            if (NT(n))
            {
                richTextBox1.Text = n + " là số nguyên tố";
            }
            else
                richTextBox1.Text = n + " không là số nguyên tố";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimSnt_Click(object sender, EventArgs e)
        {
            
            long n = long.Parse(txtN.Text);
            for (int i = 2; i <= n; i++)
            {
                if (NT(i))
                richTextBox2.Text = richTextBox2.Text + i + "; ";
            }
      
        }
    }
}
