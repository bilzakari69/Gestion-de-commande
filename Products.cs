using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data source=localhost;initial catalog=DS1;integrated security=true;");
        SqlCommand cmd;
        private void Products_Load(object sender, EventArgs e)
        {
            charger();
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
        }
        public void charger()
            {
            cmd = new SqlCommand("", cn);
            cn.Open();
            String chaine = "Select * from [Categories]";
            cmd.CommandText = chaine;
            SqlDataReader rd = cmd.ExecuteReader();
            Dictionary<int, string> categories = new Dictionary<int, string>();
            while (rd.Read())
            {
                categories.Add(rd.GetInt32(0), rd.GetString(1));
            }
            comboBox1.DataSource = categories.ToList();
            rd.Close();
            dataGridView1.Rows.Clear();
            chaine = "Select Products.ID, Products.Name, Categories.Name FROM [Products] LEFT JOIN Categories ON Categories.ID = Products.CategoryID";
            cmd.CommandText = chaine;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dataGridView1.Rows.Add(rd.GetInt32(0), rd.GetString(1), rd.GetString(2));
            }
            rd.Close();
            cn.Close();
            }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            cn.Open();
            var chaine = $@"INSERT INTO [Products] ([Name]
                                                  ,[Amount]
                                                  ,[CategoryID]) 
                                            VALUES('{txt_produit.Text}', {txt_prix.Text}, '{comboBox1.SelectedValue}')";
            cmd.CommandText = chaine;
            cmd.ExecuteNonQuery();
            cn.Close();

            charger();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Please select a row.");

            if (MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cn.Open();
                string chaine = "Delete from [Products] where ID=" + id;
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
                if (row.Cells[0].Value != null)
                {

                    String chaine = $"UPDATE [dbo].[Categories] SET Name = '{row.Cells[1].Value}' WHERE ID = {row.Cells[0].Value}";
                    cmd.CommandText = chaine;
                    cmd.ExecuteNonQuery();
                }
            }
            cn.Close();

            charger();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
