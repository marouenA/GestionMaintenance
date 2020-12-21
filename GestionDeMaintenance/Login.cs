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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (this.username.Text == "admin" && this.password.Text == "0000")
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("mot de passe ou nom d'utilisateur invalide");
            }
        }
    }
}
