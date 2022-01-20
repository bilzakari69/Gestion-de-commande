using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data source=localhost;initial catalog=DS1;integrated security=true;");
        SqlCommand cmd;
        private void Ajouter_Click(object sender, EventArgs e)
        {
            cn.Open();
            String chaine = "INSERT INTO[dbo].[Categories]([Name])VALUES('" + txt_libelle.Text + "')";
            cmd.CommandText = chaine;
            cmd.ExecuteNonQuery();
            cn.Close();

            charger();
        }

        public void charger()
        {
            cmd = new SqlCommand("", cn);
            cn.Open();
            String chaine = "Select ID, Name from Categories";
            cmd.CommandText = chaine;
            SqlDataReader rd = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rd.Read())
            {
                dataGridView1.Rows.Add(rd.GetInt32(0), rd.GetString(1));
            }
            rd.Close();
            cn.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("", cn);
            charger();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                cn.Open();
                string chaine = "Delete from [Category] where libelle=" + txt_libelle.Text;
                cmd.CommandText = chaine;
                cmd.ExecuteNonQuery();
                cn.Close();
                charger();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Please select a row.");

            if (MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cn.Open();
                string chaine = "Delete from [Categories] where ID=" + id;
                cmd.CommandText = chaine;
                cmd.ExecuteNonQuery();
                cn.Close();
                charger();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    
                    String chaine = $"UPDATE [dbo].[Categories] SET Name = '{row.Cells[1].Value}' WHERE ID = {row.Cells[0].Value}";
                    cmd.CommandText = chaine;
                    cmd.ExecuteNonQuery();
                }  
            }
            cn.Close();

            charger();
        }
    }

}
