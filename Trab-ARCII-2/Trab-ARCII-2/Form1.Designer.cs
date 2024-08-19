namespace Trab_ARCII_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.labelProcessador = new System.Windows.Forms.Label();
            this.comboBoxProcessador = new System.Windows.Forms.ComboBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.buttonLeitura = new System.Windows.Forms.Button();
            this.buttonEscrita = new System.Windows.Forms.Button();
            this.txtNovoDado = new System.Windows.Forms.TextBox();
            this.labelNovoDado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 

            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 324);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(776, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 480);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(776, 150);
            this.dataGridView4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Batalha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(794, 12);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(590, 150);
            this.dataGridView5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Próximo Confronto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelProcessador
            // 
            this.labelProcessador.AutoSize = true;
            this.labelProcessador.Location = new System.Drawing.Point(794, 180);
            this.labelProcessador.Name = "labelProcessador";
            this.labelProcessador.Size = new System.Drawing.Size(70, 13);
            this.labelProcessador.TabIndex = 7;
            this.labelProcessador.Text = "Processador:";
            // 
            // comboBoxProcessador
            // 
            this.comboBoxProcessador.FormattingEnabled = true;
            this.comboBoxProcessador.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxProcessador.Location = new System.Drawing.Point(870, 177);
            this.comboBoxProcessador.Name = "comboBoxProcessador";
            this.comboBoxProcessador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProcessador.TabIndex = 8;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(794, 220);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 9;
            this.labelEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(870, 217);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(121, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // buttonLeitura
            // 
            this.buttonLeitura.Location = new System.Drawing.Point(997, 175);
            this.buttonLeitura.Name = "buttonLeitura";
            this.buttonLeitura.Size = new System.Drawing.Size(75, 23);
            this.buttonLeitura.TabIndex = 11;
            this.buttonLeitura.Text = "Leitura";
            this.buttonLeitura.UseVisualStyleBackColor = true;
            this.buttonLeitura.Click += new System.EventHandler(this.buttonLeitura_Click);
            // 
            // buttonEscrita
            // 
            this.buttonEscrita.Location = new System.Drawing.Point(997, 214);
            this.buttonEscrita.Name = "buttonEscrita";
            this.buttonEscrita.Size = new System.Drawing.Size(75, 23);
            this.buttonEscrita.TabIndex = 12;
            this.buttonEscrita.Text = "Escrita";
            this.buttonEscrita.UseVisualStyleBackColor = true;
            this.buttonEscrita.Click += new System.EventHandler(this.buttonEscrita_Click);
            // 
            // txtNovoDado
            // 
            this.txtNovoDado.Location = new System.Drawing.Point(870, 258);
            this.txtNovoDado.Name = "txtNovoDado";
            this.txtNovoDado.Size = new System.Drawing.Size(121, 20);
            this.txtNovoDado.TabIndex = 13;
            // 
            // labelNovoDado
            // 
            this.labelNovoDado.AutoSize = true;
            this.labelNovoDado.Location = new System.Drawing.Point(794, 261);
            this.labelNovoDado.Name = "labelNovoDado";
            this.labelNovoDado.Size = new System.Drawing.Size(66, 13);
            this.labelNovoDado.TabIndex = 14;
            this.labelNovoDado.Text = "Novo Dado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 637);
            this.Controls.Add(this.labelNovoDado);
            this.Controls.Add(this.txtNovoDado);
            this.Controls.Add(this.buttonEscrita);
            this.Controls.Add(this.buttonLeitura);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.comboBoxProcessador);
            this.Controls.Add(this.labelProcessador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelProcessador;
        private System.Windows.Forms.ComboBox comboBoxProcessador;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button buttonLeitura;
        private System.Windows.Forms.Button buttonEscrita;
        private System.Windows.Forms.TextBox txtNovoDado;
        private System.Windows.Forms.Label labelNovoDado;
    }
}
