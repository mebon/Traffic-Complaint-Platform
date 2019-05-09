using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafik_şikayet_platformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ihbar_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            pnl_form.Controls.Add(f2);
            f2.Show();
            f2.Dock = DockStyle.Fill;
            f2.BringToFront();

            

        }

        private void btn_hata_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            Form4 f4 = new Form4();
            f4.TopLevel = false;
            pnl_form.Controls.Add(f4);
            f4.Show();
            f4.Dock = DockStyle.Fill;
            f4.BringToFront();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
