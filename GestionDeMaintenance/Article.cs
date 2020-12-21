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
    public partial class Article : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\GestionMaintenace.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Article_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public Article()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Article_Load(object sender, EventArgs e)
        {
            this.categorie.SelectedIndex = 4;
            this.majoration.SelectedIndex = 0;
            this.uniteDeMesure.SelectedIndex = 0;
            populate();
        }

        private void BunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Majoration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            try {
                if (this.code.Text == "" || this.designation.Text == "" || this.prixHt.Text == "" || this.tva.Text == "" || this.prixTtc.Text == "" || this.majoration.SelectedItem.ToString() == "" || this.quantite.Text == "" || this.quantiteMin.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les chapms");
                }
                else
                {
                    conn.Open();
                    SqlCommand _cmd = new SqlCommand("insert into Article_table values('" + this.code.Text + "','" + this.designation.Text + "','" + this.prixHt.Text + "','" + this.tva.Text + "','" + this.majoration.SelectedItem.ToString() + "','" + this.prixTtc.Text + "','" + this.quantite.Text + "','" + this.quantiteMin.Text + "','" + this.categorie.SelectedItem.ToString() + "','" + this.uniteDeMesure.SelectedItem.ToString() + "');", conn);
                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Article Ajouté avec Sucée");
                    conn.Close();
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("saissez un code valide");
            }
            
            

        }

        private void Tva_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "update Article_Table set Design='" + this.designation.Text + "',PHT='" + this.prixHt.Text + "',TVA='" + this.tva.Text + "',Majore='" + this.majoration.SelectedItem.ToString() + "',PrixTTC='" + this.prixTtc.Text + "',Qte='" + this.quantite.Text + "',QteMin='" + this.quantiteMin.Text + "',Categ='" + this.categorie.SelectedItem.ToString() + "',Unite='" + this.uniteDeMesure.SelectedItem.ToString() + "'where Code='" + this.code.Text + "';";
            SqlCommand _cmd = new SqlCommand(query, conn);

            _cmd.ExecuteNonQuery();
            MessageBox.Show("Article Modifié Avec Succée");
            conn.Close();
            populate();
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.code.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.designation.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.prixHt.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.tva.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.prixTtc.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            this.quantite.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            this.quantiteMin.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
           
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            if (code.Text == "Code")
            {
                MessageBox.Show("Please click on the article you want to delete", "warning");
            }
            else
            {
                String query = "delete  from Article_Table where Code=@a";
                conn.Open();
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Parameters.AddWithValue("a", code.Text);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Article supprimé");
                conn.Close();
                populate();
            }
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
    }

