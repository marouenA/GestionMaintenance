using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeMaintenance
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.Show();
            this.Hide();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            Machine a = new Machine();
            a.Show();
            this.Hide();
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            Intervention a = new Intervention();
            a.Show();
            this.Hide();
        }

        private void BunifuButton5_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            Edition a = new Edition();
            a.Show();
            this.Hide();
        }
    }
}
