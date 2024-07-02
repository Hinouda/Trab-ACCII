using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trab_ACCII
{
    public partial class Form1 : Form
    {
        private List<Livro> memoriaPrincipal;
        private List<LinhaCache> cacheP1;
        private List<LinhaCache> cacheP2;
        private List<LinhaCache> cacheP3;
        private int processadorAtual;

        public Form1()
        {
            InitializeComponent();
            InicializarMemoriaPrincipal();
            InicializarCache();
            processadorAtual = 1; // Inicializa com o processador 1 selecionado
        }

        private void InicializarMemoriaPrincipal()
        {
            memoriaPrincipal = new List<Livro>();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                memoriaPrincipal.Add(new Livro { Id = i, Titulo = $"Livro {i + 1}", Reservado = rand.Next(2) == 0 });
            }
            AtualizarListaMemoriaPrincipal();
        }

        private void InicializarCache()
        {
            cacheP1 = new List<LinhaCache>();
            cacheP2 = new List<LinhaCache>();
            cacheP3 = new List<LinhaCache>();
        }

        private void AtualizarListaMemoriaPrincipal()
        {
            listBoxMemoriaPrincipal.Items.Clear();
            foreach (var livro in memoriaPrincipal)
            {
                listBoxMemoriaPrincipal.Items.Add($"ID: {livro.Id} - Título: {livro.Titulo} - Reservado: {livro.Reservado}");
            }
        }

        private void btnSelecionarP1_Click(object sender, EventArgs e)
        {
            processadorAtual = 1;
            labelProcessadorAtual.Text = "Processador Atual: P1";
        }

        private void btnSelecionarP2_Click(object sender, EventArgs e)
        {
            processadorAtual = 2;
            labelProcessadorAtual.Text = "Processador Atual: P2";
        }

        private void btnSelecionarP3_Click(object sender, EventArgs e)
        {
            processadorAtual = 3;
            labelProcessadorAtual.Text = "Processador Atual: P3";
        }

        //Ver qq faz
        //
        //
        //
        private void btnLerLivro_Click(object sender, EventArgs e)
        {
            int idLivro;
            if (int.TryParse(txtIdLivro.Text, out idLivro))
            {
                var linhaCache = Leitura(processadorAtual, idLivro);
                AtualizarInterfaceCache(linhaCache);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de livro válido.");
            }
        }

        private void btnReservarLivro_Click(object sender, EventArgs e)
        {
            int idLivro;
            if (int.TryParse(txtIdLivro.Text, out idLivro))
            {
                var linhaCache = Escrita(processadorAtual, idLivro);
                AtualizarInterfaceCache(linhaCache);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de livro válido.");
            }
        }

        private LinhaCache Leitura(int processador, int idLivro)
        {
            // Simulação da leitura com estado MESI
            // Implementar lógica para procurar o livro na cache do processador
            // Se não estiver na cache, carregar da memória principal e definir estado MESI
            // Para fins de simplicidade, retornamos uma linha de cache fictícia
            return new LinhaCache { Bloco = idLivro, Livro = memoriaPrincipal[idLivro], EstadoMESI = "E" };
        }

        private LinhaCache Escrita(int processador, int idLivro)
        {
            // Simulação da escrita com estado MESI
            // Implementar lógica para modificar o estado de reserva do livro na cache do processador
            // Atualizar estados MESI conforme necessário
            // Para fins de simplicidade, marcamos o livro como reservado
            memoriaPrincipal[idLivro].Reservado = true;
            return new LinhaCache { Bloco = idLivro, Livro = memoriaPrincipal[idLivro], EstadoMESI = "M" };
        }

        private void AtualizarInterfaceCache(LinhaCache linhaCache)
        {
            listBoxCache.Items.Clear();
            listBoxCache.Items.Add($"Bloco: {linhaCache.Bloco} - Título: {linhaCache.Livro.Titulo} - Reservado: {linhaCache.Livro.Reservado} - Estado MESI: {linhaCache.EstadoMESI}");
        }
    }

    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Reservado { get; set; }
    }

    public class LinhaCache
    {
        public int Bloco { get; set; }
        public Livro Livro { get; set; }
        public string EstadoMESI { get; set; }
    }
}
