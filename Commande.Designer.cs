namespace DS1
{
    partial class Commande
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_solde = new System.Windows.Forms.Label();
            this.lb_pu = new System.Windows.Forms.Label();
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_ttc = new System.Windows.Forms.Label();
            this.lb_tva = new System.Windows.Forms.Label();
            this.lb_ht = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(136, 61);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(121, 21);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(136, 102);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbProducts.TabIndex = 1;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produit :";
            // 
            // lb_solde
            // 
            this.lb_solde.AutoSize = true;
            this.lb_solde.Location = new System.Drawing.Point(307, 64);
            this.lb_solde.Name = "lb_solde";
            this.lb_solde.Size = new System.Drawing.Size(75, 13);
            this.lb_solde.TabIndex = 4;
            this.lb_solde.Text = "Solde :   euros";
            this.lb_solde.Click += new System.EventHandler(this.lb_solde_Click);
            // 
            // lb_pu
            // 
            this.lb_pu.AutoSize = true;
            this.lb_pu.Location = new System.Drawing.Point(307, 105);
            this.lb_pu.Name = "lb_pu";
            this.lb_pu.Size = new System.Drawing.Size(104, 13);
            this.lb_pu.TabIndex = 5;
            this.lb_pu.Text = "Prix Unitaire :   euros";
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(136, 145);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(121, 20);
            this.txt_qte.TabIndex = 6;
            this.txt_qte.TextChanged += new System.EventHandler(this.txt_qt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantité :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(87, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 121);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(307, 148);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(92, 13);
            this.lb_total.TabIndex = 10;
            this.lb_total.Text = "Prix Total :   euros";
            // 
            // lb_ttc
            // 
            this.lb_ttc.AutoSize = true;
            this.lb_ttc.Location = new System.Drawing.Point(711, 279);
            this.lb_ttc.Name = "lb_ttc";
            this.lb_ttc.Size = new System.Drawing.Size(0, 13);
            this.lb_ttc.TabIndex = 14;
            // 
            // lb_tva
            // 
            this.lb_tva.AutoSize = true;
            this.lb_tva.Location = new System.Drawing.Point(711, 236);
            this.lb_tva.Name = "lb_tva";
            this.lb_tva.Size = new System.Drawing.Size(0, 13);
            this.lb_tva.TabIndex = 13;
            // 
            // lb_ht
            // 
            this.lb_ht.AutoSize = true;
            this.lb_ht.Location = new System.Drawing.Point(711, 195);
            this.lb_ht.Name = "lb_ht";
            this.lb_ht.Size = new System.Drawing.Size(0, 13);
            this.lb_ht.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "HT :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "TVA :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "TTC :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Produit";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prix Unitaire";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix Total";
            this.Column4.Name = "Column4";
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_ttc);
            this.Controls.Add(this.lb_tva);
            this.Controls.Add(this.lb_ht);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qte);
            this.Controls.Add(this.lb_pu);
            this.Controls.Add(this.lb_solde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.cmbClients);
            this.Name = "Commande";
            this.Size = new System.Drawing.Size(831, 407);
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_solde;
        private System.Windows.Forms.Label lb_pu;
        private System.Windows.Forms.TextBox txt_qte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_ttc;
        private System.Windows.Forms.Label lb_tva;
        private System.Windows.Forms.Label lb_ht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
