namespace ShushaPharmacy.Forms
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.clmn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_listcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_expire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtp_expiration = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_id,
            this.clmn_name,
            this.clmn_price,
            this.clmn_type,
            this.clmn_listcount,
            this.clmn_expire});
            this.dgv_products.Location = new System.Drawing.Point(12, 110);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 29;
            this.dgv_products.Size = new System.Drawing.Size(803, 188);
            this.dgv_products.TabIndex = 0;
            // 
            // clmn_id
            // 
            this.clmn_id.HeaderText = "ID";
            this.clmn_id.MinimumWidth = 6;
            this.clmn_id.Name = "clmn_id";
            this.clmn_id.Width = 125;
            // 
            // clmn_name
            // 
            this.clmn_name.HeaderText = "Name";
            this.clmn_name.MinimumWidth = 6;
            this.clmn_name.Name = "clmn_name";
            this.clmn_name.Width = 125;
            // 
            // clmn_price
            // 
            this.clmn_price.HeaderText = "Price";
            this.clmn_price.MinimumWidth = 6;
            this.clmn_price.Name = "clmn_price";
            this.clmn_price.Width = 125;
            // 
            // clmn_type
            // 
            this.clmn_type.HeaderText = "Type";
            this.clmn_type.MinimumWidth = 6;
            this.clmn_type.Name = "clmn_type";
            this.clmn_type.Width = 125;
            // 
            // clmn_listcount
            // 
            this.clmn_listcount.HeaderText = "List Count";
            this.clmn_listcount.MinimumWidth = 6;
            this.clmn_listcount.Name = "clmn_listcount";
            this.clmn_listcount.Width = 125;
            // 
            // clmn_expire
            // 
            this.clmn_expire.HeaderText = "Expiration Date";
            this.clmn_expire.MinimumWidth = 6;
            this.clmn_expire.Name = "clmn_expire";
            this.clmn_expire.Width = 125;
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(12, 47);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(156, 27);
            this.txbx_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // txbx_price
            // 
            this.txbx_price.Location = new System.Drawing.Point(206, 47);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(156, 27);
            this.txbx_price.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // txbx_id
            // 
            this.txbx_id.Location = new System.Drawing.Point(389, 47);
            this.txbx_id.Name = "txbx_id";
            this.txbx_id.Size = new System.Drawing.Size(156, 27);
            this.txbx_id.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expiration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(846, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // dtp_expiration
            // 
            this.dtp_expiration.Location = new System.Drawing.Point(575, 49);
            this.dtp_expiration.Name = "dtp_expiration";
            this.dtp_expiration.Size = new System.Drawing.Size(250, 27);
            this.dtp_expiration.TabIndex = 12;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.dtp_expiration);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.dgv_products);
            this.Name = "Sale";
            this.Text = "Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sale_FormClosed);
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_products;
        private DataGridViewTextBoxColumn clmn_id;
        private DataGridViewTextBoxColumn clmn_name;
        private DataGridViewTextBoxColumn clmn_price;
        private DataGridViewTextBoxColumn clmn_type;
        private DataGridViewTextBoxColumn clmn_listcount;
        private DataGridViewTextBoxColumn clmn_expire;
        private TextBox txbx_name;
        private Label label1;
        private Label label2;
        private TextBox txbx_price;
        private Label label3;
        private TextBox txbx_id;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dtp_expiration;
    }
}