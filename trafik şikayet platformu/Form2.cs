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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            Form2 formkapa = new Form2();
            formkapa.Close();

            Form3 form = new Form3();
            form.Show();
            this.Hide();

        }
    }
}
