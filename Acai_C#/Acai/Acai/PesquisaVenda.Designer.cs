namespace Acai
{
    partial class PesquisaVenda
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
            this.dtgPesq = new System.Windows.Forms.DataGridView();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.btninclui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPesq
            // 
            this.dtgPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesq.Location = new System.Drawing.Point(24, 56);
            this.dtgPesq.Name = "dtgPesq";
            this.dtgPesq.Size = new System.Drawing.Size(510, 150);
            this.dtgPesq.TabIndex = 0;
            // 
            // dtpPedido
            // 
            this.dtpPedido.Location = new System.Drawing.Point(24, 21);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(296, 20);
            this.dtpPedido.TabIndex = 41;
            // 
            // btninclui
            // 
            this.btninclui.Location = new System.Drawing.Point(372, 21);
            this.btninclui.Name = "btninclui";
            this.btninclui.Size = new System.Drawing.Size(162, 23);
            this.btninclui.TabIndex = 42;
            this.btninclui.Text = "Pesquisar";
            this.btninclui.UseVisualStyleBackColor = true;
            this.btninclui.Click += new System.EventHandler(this.btninclui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Valor total do dia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 44;
            // 
            // PesquisaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 301);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninclui);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.dtgPesq);
            this.Name = "PesquisaVenda";
            this.Text = "PesquisaVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPesq;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.Button btninclui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}