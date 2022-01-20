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
    public partial class Commande : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data source=localhost;initial catalog=DS1;integrated security=true;");
        SqlCommand cmd;
        public Commande()
        {
            InitializeComponent();
            cmbProducts.ValueMember = "Key";
            cmbProducts.DisplayMember = "Value";
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("", cn);
            cn.Open();

            String chaine = "Select ID, Name from [Products]";
            cmd.CommandText = chaine;
            SqlDataReader rd = cmd.ExecuteReader();
            Dictionary<int, string> products = new Dictionary<int, string>();
            while (rd.Read())
            {
                products.Add(rd.GetInt32(0), rd.GetString(1));
            }
            rd.Close();
            cmbProducts.DataSource = products.ToList();

            chaine = "Select nom,prenom from Client";
            cmd.CommandText = chaine;
            cn.Open();
            rd = cmd.ExecuteReader();
            Dictionary<string, string> clients = new Dictionary<string, string>();
            while (rd.Read())
            {
                clients.Add(rd.GetString(0), rd.GetString(1));
            }
            rd.Close();
            cmbClients.DataSource = clients.ToList();

            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] vals = cmbClients.Text.Split('-');
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            var selectedValue = (KeyValuePair<string, string>)cmbClients.SelectedValue;
            String chaine = "Select solde from client where nom='" + selectedValue.Key + "' and prenom ='" + selectedValue.Value + "'";
            cmd.CommandText = chaine;
            String solde = cmd.ExecuteScalar() == null ? "Not found" : cmd.ExecuteScalar().ToString();
            lb_solde.Text = "Solde : " + solde + " euros";
            cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cn.State == ConnectionState.Closed)
                cn.Open();
            String chaine = $"Select [Amount] from [Products] where ID={cmbProducts.SelectedValue}";
            cmd.CommandText = chaine;
            String pu = cmd.ExecuteScalar().ToString();
            lb_pu.Text = "PU : " + pu + " euros";
            cn.Close();
        }

        private void txt_qt_TextChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            String chaine = $"Select [Amount] from [Products] where ID={cmbProducts.SelectedValue}";
            cmd.CommandText = chaine;
            int pu = int.Parse(cmd.ExecuteScalar().ToString());
            if(int.TryParse(txt_qte.Text, out int val))
            {
                lb_total.Text = "Prix Total : " + (val * pu).ToString() + " euros";
            }

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            String chaine = $"Select [Amount] from [Products] where ID={cmbProducts.SelectedValue}";
            cmd.CommandText = chaine;
            int pu = int.Parse(cmd.ExecuteScalar().ToString());
            int qte = int.Parse(txt_qte.Text);
            string total = (qte * pu).ToString();
            dataGridView1.Rows.Add(cmbProducts.Text, pu.ToString(), qte.ToString(), total);  

            double somme = 0;  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                somme = somme + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }

            double tva = somme * 0.2;
            double ttc = tva + somme;

            lb_ht.Text = somme.ToString() + " euros";
            lb_tva.Text = tva.ToString() + " euros";
            lb_ttc.Text = ttc.ToString() + " euros";
            cn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_solde_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
