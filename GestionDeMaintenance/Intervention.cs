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
    public partial class Intervention : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\GestionMaintenace.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Intervention_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void populateCombobox()
        {

            String sql = "select * from Machine_Table;";
            SqlCommand _cmd = new SqlCommand(sql, conn);

            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Code", typeof(String));
                rdr = _cmd.ExecuteReader();
                dt.Load(rdr);
                
                this.comboBox1.ValueMember = "Code";
                this.comboBox1.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }
        public Intervention()
        {
            InitializeComponent();
        }

        private void LocalM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Intervention_Load(object sender, EventArgs e)
        {
            populate();
            populateCombobox();
            this.etape.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
                SqlCommand _cmd = new SqlCommand("insert into Intervention_table values('" + this.nInter.Text + "','" + this.dateIntervention.Value + "','" + this.comboBox1.SelectedItem.ToString() + "','" + this.description.Text + "','" + this.etape.SelectedItem.ToString() + "');", conn);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Votre domande est envoyée");
                conn.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Saisissez un code valide");
            }
            
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.nInter.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //this.codeMachine.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.description.Text = this.bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            String query = "update Intervention_Table set Date_intervention='" + this.dateIntervention.Value + "',Code_Machine='" + this.comboBox1.SelectedItem.ToString() + "',Description='" + this.description.Text + "',Etape='" + this.etape.SelectedItem.ToString() + "'where numero='" + this.nInter.Text + "';";
            SqlCommand _cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                

                _cmd.ExecuteNonQuery();
                MessageBox.Show("Machine Modifié Avec Succée");
                conn.Close();
                populate();
            }
            catch(Exception )
            {
                MessageBox.Show("something went wrong!");
            }
           
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            if (nInter.Text == "N° Intervention"|| nInter.Text == "N° Intervention")
            {
                MessageBox.Show("Veuillez saisir le numero d'intervention", "warning");
            }
            else
            {
                String query = "delete  from Intervention_Table where numero=@a";
                conn.Open();
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Parameters.AddWithValue("a", nInter.Text);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("demande annulée");
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

        private void DateIntervention_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
