using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeMaintenance
{
    public partial class Machine : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\GestionMaintenace.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Machine_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public Machine()
        {
            InitializeComponent();
        }

        private void Code_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Machine_Load(object sender, EventArgs e)
        {
            populate();
            this.localM.SelectedIndex = 0;
            this.etatM.SelectedIndex = 0;
            
        }

        private void Label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            if (this.codeM.Text=="" || this.designationM.Text=="" || this.localM.SelectedItem.ToString()=="Localisation" || this.numSerieM.Text=="" || this.marqueM.Text=="" || this.etatM.SelectedItem.ToString()=="Etat")
            {
                MessageBox.Show("Veuillez remplire tout les champs");
            }
            else {
                try {
                    conn.Open();
                    SqlCommand _cmd = new SqlCommand("insert into Machine_table values('" + this.codeM.Text + "','" + this.designationM.Text + "','" + this.localM.SelectedItem.ToString() + "','" + this.numSerieM.Text + "','" + this.etatM.SelectedItem.ToString() + "','" + this.marqueM.Text + "','" + this.AcquisitionM.Value + "','" + this.miseEnServiceM.Value + "');", conn);
                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Machine Ajouté avec Sucée");
                    conn.Close();
                    populate();
                }
                catch(Exception)
                {
                    MessageBox.Show("saisissez un code valide");
                }
                
            }
            
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "update Machine_Table set Design='" + this.designationM.Text + "',Localisation='" + this.localM.SelectedItem.ToString() + "',N_Serie='" + this.numSerieM.Text + "',Etat='" + this.etatM.SelectedItem.ToString() + "',Marque='" + this.marqueM.Text + "',Acquisition='" + this.AcquisitionM.Value + "',Mise_En_Service='" + this.miseEnServiceM.Value + "'where Code='" + this.codeM.Text + "';";
            SqlCommand _cmd = new SqlCommand(query, conn);

            _cmd.ExecuteNonQuery();
            MessageBox.Show("Machine Modifié Avec Succée");
            conn.Close();
            populate();
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            if (codeM.Text == "Code")
            {
                MessageBox.Show("Veuillez choisir une machine", "warning");
            }
            else
            {
                String query = "delete  from Machine_Table where Code=@a";
                conn.Open();
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Parameters.AddWithValue("a", codeM.Text);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Machine supprimé");
                conn.Close();
                populate();
            }
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codeM.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.designationM.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.numSerieM.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.marqueM.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
       
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void CodeM_Enter(object sender, EventArgs e)
        {
            if (this.codeM.Text == "Code")
            {
                this.codeM.Text = "";
            }
        }

        private void CodeM_Leave(object sender, EventArgs e)
        {
            if (this.codeM.Text == "")
            {
                this.codeM.Text = "Code";
            }
        }

        private void DesignationM_Enter(object sender, EventArgs e)
        {
            if (this.designationM.Text == "Designation")
            {
                this.codeM.Text = "";
            }
        }

        private void DesignationM_Leave(object sender, EventArgs e)
        {
            if (this.designationM.Text == "")
            {
                this.designationM.Text = "Designation"; 
            }
        }

        private void NumSerieM_Enter(object sender, EventArgs e)
        {
            if (this.numSerieM.Text == "N° Serie")
            {
                this.numSerieM.Text = "";
            }
        }

        private void NumSerieM_Leave(object sender, EventArgs e)
        {
            if (this.numSerieM.Text == "")
            {
                this.numSerieM.Text = "N° Serie";
            }
        }

        private void MarqueM_Enter(object sender, EventArgs e)
        {
            if (this.marqueM.Text == "Marque")
            {
                this.marqueM.Text = "";
            }
        }

        private void MarqueM_Leave(object sender, EventArgs e)
        {
            if (this.marqueM.Text == "")
            {
                this.marqueM.Text = "Marque";
            }
        }
    }
}
