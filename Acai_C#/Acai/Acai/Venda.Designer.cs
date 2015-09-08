namespace Acai
{
    partial class Venda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btninclui = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btnconf = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btninclui);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(58, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 167);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Produto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 40;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(85, 20);
            this.txtId.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID Produto:";
            // 
            // btninclui
            // 
            this.btninclui.Location = new System.Drawing.Point(9, 118);
            this.btninclui.Name = "btninclui";
            this.btninclui.Size = new System.Drawing.Size(562, 23);
            this.btninclui.TabIndex = 37;
            this.btninclui.Text = "Incluir";
            this.btninclui.UseVisualStyleBackColor = true;
            this.btninclui.Click += new System.EventHandler(this.btninclui_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(486, 74);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.ReadOnly = true;
            this.txtvalor.Size = new System.Drawing.Size(85, 20);
            this.txtvalor.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Valor do Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Incluir no Pedido";
            // 
            // dtgVenda
            // 
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduto,
            this.nomeproduto,
            this.preco_custo});
            this.dtgVenda.Location = new System.Drawing.Point(58, 410);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.Size = new System.Drawing.Size(582, 113);
            this.dtgVenda.TabIndex = 34;
            this.dtgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVenda_CellContentClick);
            // 
            // idproduto
            // 
            this.idproduto.FillWeight = 500F;
            this.idproduto.HeaderText = "idproduto";
            this.idproduto.Name = "idproduto";
            // 
            // nomeproduto
            // 
            this.nomeproduto.HeaderText = "nomeproduto";
            this.nomeproduto.Name = "nomeproduto";
            // 
            // preco_custo
            // 
            this.preco_custo.HeaderText = "preco_custo";
            this.preco_custo.Name = "preco_custo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(293, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Itens do Pedido";
            // 
            // btnconf
            // 
            this.btnconf.Location = new System.Drawing.Point(296, 536);
            this.btnconf.Name = "btnconf";
            this.btnconf.Size = new System.Drawing.Size(110, 23);
            this.btnconf.TabIndex = 38;
            this.btnconf.Text = "Finalizar Pedido";
            this.btnconf.UseVisualStyleBackColor = true;
            this.btnconf.Click += new System.EventHandler(this.btnconf_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 541);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "R$";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(548, 538);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(81, 20);
            this.txttotal.TabIndex = 36;
            this.txttotal.Text = "0";
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(455, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Total Geral:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Location = new System.Drawing.Point(15, 52);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.Size = new System.Drawing.Size(669, 149);
            this.dtgProdutos.TabIndex = 39;
            this.dtgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellContentClick);
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(15, 12);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(296, 20);
            this.dtpPedido.TabIndex = 40;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.btnconf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btninclui;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_custo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.DateTimePicker dtpPedido;
    }
}