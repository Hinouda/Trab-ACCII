namespace Trab_ACCII
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxMemoriaPrincipal = new System.Windows.Forms.ListBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLerLivro = new System.Windows.Forms.Button();
            this.btnReservarLivro = new System.Windows.Forms.Button();
            this.btnSelecionarP1 = new System.Windows.Forms.Button();
            this.btnSelecionarP2 = new System.Windows.Forms.Button();
            this.btnSelecionarP3 = new System.Windows.Forms.Button();
            this.labelProcessadorAtual = new System.Windows.Forms.Label();
            this.listBoxCache = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxMemoriaPrincipal
            // 
            this.listBoxMemoriaPrincipal.FormattingEnabled = true;
            this.listBoxMemoriaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.listBoxMemoriaPrincipal.Name = "listBoxMemoriaPrincipal";
            this.listBoxMemoriaPrincipal.Size = new System.Drawing.Size(400, 199);
            this.listBoxMemoriaPrincipal.TabIndex = 0;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(12, 252);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Livro";
            // 
            // btnLerLivro
            // 
            this.btnLerLivro.Location = new System.Drawing.Point(118, 250);
            this.btnLerLivro.Name = "btnLerLivro";
            this.btnLerLivro.Size = new System.Drawing.Size(75, 23);
            this.btnLerLivro.TabIndex = 3;
            this.btnLerLivro.Text = "Ler Livro";
            this.btnLerLivro.UseVisualStyleBackColor = true;
            this.btnLerLivro.Click += new System.EventHandler(this.btnLerLivro_Click);
            // 
            // btnReservarLivro
            // 
            this.btnReservarLivro.Location = new System.Drawing.Point(199, 250);
            this.btnReservarLivro.Name = "btnReservarLivro";
            this.btnReservarLivro.Size = new System.Drawing.Size(90, 23);
            this.btnReservarLivro.TabIndex = 4;
            this.btnReservarLivro.Text = "Reservar Livro";
            this.btnReservarLivro.UseVisualStyleBackColor = true;
            this.btnReservarLivro.Click += new System.EventHandler(this.btnReservarLivro_Click);
            // 
            // btnSelecionarP1
            // 
            this.btnSelecionarP1.Location = new System.Drawing.Point(418, 12);
            this.btnSelecionarP1.Name = "btnSelecionarP1";
            this.btnSelecionarP1.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarP1.TabIndex = 5;
            this.btnSelecionarP1.Text = "Selecionar P1";
            this.btnSelecionarP1.UseVisualStyleBackColor = true;
            this.btnSelecionarP1.Click += new System.EventHandler(this.btnSelecionarP1_Click);
            // 
            // btnSelecionarP2
            // 
            this.btnSelecionarP2.Location = new System.Drawing.Point(418, 41);
            this.btnSelecionarP2.Name = "btnSelecionarP2";
            this.btnSelecionarP2.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarP2.TabIndex = 6;
            this.btnSelecionarP2.Text = "Selecionar P2";
            this.btnSelecionarP2.UseVisualStyleBackColor = true;
            this.btnSelecionarP2.Click += new System.EventHandler(this.btnSelecionarP2_Click);
            // 
            // btnSelecionarP3
            // 
            this.btnSelecionarP3.Location = new System.Drawing.Point(418, 70);
            this.btnSelecionarP3.Name = "btnSelecionarP3";
            this.btnSelecionarP3.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarP3.TabIndex = 7;
            this.btnSelecionarP3.Text = "Selecionar P3";
            this.btnSelecionarP3.UseVisualStyleBackColor = true;
            this.btnSelecionarP3.Click += new System.EventHandler(this.btnSelecionarP3_Click);
            // 
            // labelProcessadorAtual
            // 
            this.labelProcessadorAtual.AutoSize = true;
            this.labelProcessadorAtual.Location = new System.Drawing.Point(418, 110);
            this.labelProcessadorAtual.Name = "labelProcessadorAtual";
            this.labelProcessadorAtual.Size = new System.Drawing.Size(112, 13);
            this.labelProcessadorAtual.TabIndex = 8;
            this.labelProcessadorAtual.Text = "Processador Atual: P1";
            // 
            // listBoxCache
            // 
            this.listBoxCache.FormattingEnabled = true;
            this.listBoxCache.Location = new System.Drawing.Point(422, 150);
            this.listBoxCache.Name = "listBoxCache";
            this.listBoxCache.Size = new System.Drawing.Size(400, 199);
            this.listBoxCache.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.listBoxCache);
            this.Controls.Add(this.labelProcessadorAtual);
            this.Controls.Add(this.btnSelecionarP3);
            this.Controls.Add(this.btnSelecionarP1);
            this.Controls.Add(this.btnReservarLivro);
            this.Controls.Add(this.btnLerLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.listBoxMemoriaPrincipal);
            this.Name = "Form1";
            this.Text = "Sistema de Reserva de Livros com Protocolo MESI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBoxMemoriaPrincipal;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLerLivro;
        private System.Windows.Forms.Button btnReservarLivro;
        private System.Windows.Forms.Button btnSelecionarP1;
        private System.Windows.Forms.Button btnSelecionarP2;
        private System.Windows.Forms.Button btnSelecionarP3;
        private System.Windows.Forms.Label labelProcessadorAtual;
        private System.Windows.Forms.ListBox listBoxCache;
    }

}

