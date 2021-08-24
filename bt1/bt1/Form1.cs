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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            int tongchan = 0, tongle = 0, tongdayso = 0;
            int x = Convert.ToInt32(txtnhapso.Text);
            txtdayvuanhap.Text += x.ToString() + " ";
            if (x % 2 == 0)
            {
                tongchan += x;
                txttongchan.Text = tongchan.ToString();
            }
            else
            {
                tongle += x;
                txttongle.Text = tongle.ToString();
            }

            tongdayso += x;
            txttongphantutrongday.Text = tongdayso.ToString();

            txtnhapso.Clear();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            int tongchan = 0, tongle = 0, tongdayso = 0;
            txtdayvuanhap.Text = "";
            txttongphantutrongday.Text = "";
            txttongchan.Text = "";
            txttongle.Text = "";
            tongchan = 0;
            tongle = 0;
            tongdayso = 0;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
