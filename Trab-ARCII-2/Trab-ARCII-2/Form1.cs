using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Trab_ARCII_2
{
    public partial class Form1 : Form
    {
        TextBox txtDado;

        // Memória principal (RAM)
        private Memory memory;

        // Caches dos processadores
        private CacheController cacheController;

        // Lista para armazenar os slots do RPG
        private List<Slot> slots = new List<Slot>();
        private List<Slot> P1 = new List<Slot>();
        private List<Slot> P2 = new List<Slot>();
        private List<Slot> P3 = new List<Slot>();
        private List<Slot> P4 = new List<Slot>();
        private int duelIndex = 0;

        private Random rnd = new Random();
        private List<string> personagens = new List<string> { "Arqueiro", "Mago", "Guerreiro" };
        private int cacheSize = 5; // Tamanho da cache de cada processador

        public Form1()
        {
            InitializeComponent();
            memory = new Memory(50); // Memória RAM com 50 posições
            cacheController = new CacheController(memory);

            preencheCache();
            distribuirSlotsAleatoriamente();
            exibeSlots();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Classe para representar blocos de memória
        public class MemoryBlock
        {
            public int Address { get; set; }
            public string Data { get; set; }

            public MemoryBlock(int address, string data)
            {
                Address = address;
                Data = data;
            }
        }

        // Classe para representar uma linha de cache
        public class CacheLine
        {
            public int Tag { get; set; }
            public string Data { get; set; }
            public MESIState State { get; set; }

            public CacheLine(int tag, string data, MESIState state)
            {
                Tag = tag;
                Data = data;
                State = state;
            }
        }

        public class Memory
        {


            public int cacheSize = 5;  // Tamanho da cache de cada processador


                private Random rnd; // Instância de Random a nível de classe

                public List<MemoryBlock> RAM { get; private set; }
                public List<CacheLine> CacheP1 { get; private set; }
                public List<CacheLine> CacheP2 { get; private set; }
                public List<CacheLine> CacheP3 { get; private set; }

                public Memory(int ramSize)
                {
                    rnd = new Random(); // Inicializa o Random uma única vez
                    RAM = new List<MemoryBlock>();

                    for (int i = 0; i < ramSize; i++)
                    {
                        RAM.Add(new MemoryBlock(i, GenerateRandomData()));
                    }

                    CacheP1 = new List<CacheLine>();
                    CacheP2 = new List<CacheLine>();
                    CacheP3 = new List<CacheLine>();
                }

                private string GenerateRandomData()
                {
                    return rnd.Next(1000, 9999).ToString(); // Reutiliza a mesma instância de Random
                }
            


        }

        public enum MESIState
        {
            Modified,
            Exclusive,
            Shared,
            Invalid
        }

        public class CacheController
        {
            private Memory memory;

            public CacheController(Memory memory)
            {
                this.memory = memory;
            }

            public string ReadData(int address, List<CacheLine> cache, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                CacheLine line = cache.FirstOrDefault(c => c.Tag == address);
                if (line != null)
                {
                    // Read Hit (RH)
                    HandleMESIReadHit(line);
                    MessageBox.Show($"Read Hit (RH) no processador. Estado da linha: {line.State}", "Operação de Leitura");
                    return line.Data;
                }
                else
                {
                    // Read Miss (RM)
                    string data = HandleMESIReadMiss(address, cache, otherCache1, otherCache2);

                    // Verifique se a cache não está vazia antes de acessar o último elemento
                    if (cache.Any())
                    {
                        MessageBox.Show($"Read Miss (RM) no processador. Estado da linha: {cache.Last().State}", "Operação de Leitura");
                    }
                    else
                    {
                        MessageBox.Show("Erro: Nenhuma linha foi adicionada à cache após o Read Miss.", "Erro de Cache");
                    }

                    return data;
                }
            }


            public void WriteData(int address, string newData, List<CacheLine> cache, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                CacheLine line = cache.FirstOrDefault(c => c.Tag == address);
                if (line != null)
                {
                    // Write Hit (WH)
                    HandleMESIWriteHit(line, newData, otherCache1, otherCache2);
                    MessageBox.Show($"Write Hit (WH) no processador. Estado da linha: {line.State}", "Operação de Escrita");
                }
                else
                {
                    // Write Miss (WM)
                    HandleMESIWriteMiss(address, newData, cache, otherCache1, otherCache2);
                    MessageBox.Show($"Write Miss (WM) no processador. Estado da linha: {cache.Last().State}", "Operação de Escrita");
                }
            }

            private void HandleMESIReadHit(CacheLine line)
            {
                // Nenhuma mudança de estado para Read Hit (RH)
            }

            private string HandleMESIReadMiss(int address, List<CacheLine> cache, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                // Verifica se o endereço está dentro do intervalo válido da RAM
                if (address < 0 || address >= memory.RAM.Count)
                {
                    // Endereço fora do intervalo válido, exibe uma mensagem de erro e retorna
                    MessageBox.Show($"O endereço {address} está fora do intervalo da RAM.", "Erro de Endereço");
                    return null;
                }

                // Se o endereço for válido, continuamos a operação
                CacheLine otherLine1 = otherCache1.FirstOrDefault(c => c.Tag == address);
                CacheLine otherLine2 = otherCache2.FirstOrDefault(c => c.Tag == address);

                string ramData = memory.RAM[address].Data;

                if (otherLine1 != null || otherLine2 != null)
                {
                    // Estado compartilhado
                    var newLine = new CacheLine(address, ramData, MESIState.Shared);
                    AddToCache(cache, newLine);
                }
                else
                {
                    // Estado exclusivo
                    var newLine = new CacheLine(address, ramData, MESIState.Exclusive);
                    AddToCache(cache, newLine);
                }

                // Verifica se a cache contém algum elemento antes de acessar o último
                if (cache.Any())
                {
                    MessageBox.Show($"Read Miss (RM) no processador. Estado da linha: {cache.Last().State}", "Operação de Leitura");
                }
                else
                {
                    // Mensagem de log ou diagnóstico, caso a cache esteja inesperadamente vazia
                    MessageBox.Show("Erro: Nenhuma linha foi adicionada à cache.", "Erro");
                }

                return ramData;
            }


            private void HandleMESIWriteHit(CacheLine line, string newData, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                if (line.State == MESIState.Shared)
                {
                    InvalidateOtherCaches(line.Tag, otherCache1, otherCache2);
                    line.State = MESIState.Modified;
                }
                else if (line.State == MESIState.Exclusive || line.State == MESIState.Modified)
                {
                    // Muda para o estado Modified
                    line.State = MESIState.Modified;
                }

                line.Data = newData;
            }

            private void HandleMESIWriteMiss(int address, string newData, List<CacheLine> cache, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                InvalidateOtherCaches(address, otherCache1, otherCache2);

                var newLine = new CacheLine(address, newData, MESIState.Modified);
                AddToCache(cache, newLine);
            }

            private void InvalidateOtherCaches(int address, List<CacheLine> otherCache1, List<CacheLine> otherCache2)
            {
                CacheLine otherLine1 = otherCache1.FirstOrDefault(c => c.Tag == address);
                CacheLine otherLine2 = otherCache2.FirstOrDefault(c => c.Tag == address);

                if (otherLine1 != null)
                {
                    otherLine1.State = MESIState.Invalid;
                }

                if (otherLine2 != null)
                {
                    otherLine2.State = MESIState.Invalid;
                }
            }

            private void AddToCache(List<CacheLine> cache, CacheLine newLine)
            {
                if (cache.Count >= memory.cacheSize)
                {
                    // Política de Write-Back: Se a linha removida estiver modificada, escrever de volta na RAM
                    CacheLine removedLine = cache[0];
                    if (removedLine.State == MESIState.Modified)
                    {
                        memory.RAM[removedLine.Tag].Data = removedLine.Data;
                        MessageBox.Show($"Escrevendo de volta na RAM o dado modificado na posição {removedLine.Tag}", "Write-Back");
                    }

                    // FIFO Replacement
                    cache.RemoveAt(0);
                }
                cache.Add(newLine);
            }
        }


        // Funções do RPG: preencheCache, distribuirSlotsAleatoriamente, exibeSlots, Batalha, BatalhaProxima, etc.
        public void distribuirSlotsAleatoriamente()
        {
            foreach (var slot in slots)
            {
                int processador = rnd.Next(3); // Gera um número aleatório entre 0 e 2
                slot.Equipe = processador + 1;
                switch (processador)
                {
                    case 0:
                        AddToCache(P1, slot);
                        break;
                    case 1:
                        AddToCache(P2, slot);
                        break;
                    case 2:
                        AddToCache(P3, slot);
                        break;
                }
            }
        }
        private void preencheCache()
        {
            // Certifique-se de que a memória principal (memory.RAM) já esteja inicializada e preenchida com dados
            for (int i = 0; i < memory.RAM.Count; i++)
            {
                var block = memory.RAM[i]; // Acessa o bloco de memória correspondente

                Slot slot = new Slot
                {
                    Id = i,
                    Forca = RolarDado(6, 4),
                    Inteligencia = RolarDado(6, 4),
                    Destreza = RolarDado(6, 4),
                    ClasseDeArmadura = RolarDado(6, 4),
                    Vida = RolarDado(6, 4),
                    Personagem = personagens[rnd.Next(personagens.Count)],

                    Linha = block.Address, // Define a linha como o endereço do bloco de memória
                    Dado = block.Data // Define o dado como o conteúdo do bloco de memória
                };

                slots.Add(slot); // Adiciona o slot à lista de slots
            }
        }




        private void AddToCache(List<Slot> cache, Slot slot)
        {
            if (cache.Count >= cacheSize)
            {
                Slot removedSlot = cache[0];
                cache.RemoveAt(0); // Remove o primeiro elemento (FIFO)
                if (removedSlot.Modified)
                {
                    slots[removedSlot.Id] = removedSlot; // Escreve de volta na memória principal (slots) se foi modificado
                }
            }
            cache.Add(slot); // Adiciona o novo slot ao final da lista
        }




        private void exibeSlots()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            dataGridView1.DataSource = slots;
            dataGridView2.DataSource = P1;
            dataGridView3.DataSource = P2;
            dataGridView4.DataSource = P3;
        }

        private int RolarDado(int faces, int quantidade)
        {
            int total = 0;
            for (int i = 0; i < quantidade; i++)
            {
                total += rnd.Next(1, faces + 1);
            }
            return total;
        }

        private void Batalha()
        {
            duelIndex = 0;
            P4.Clear();
            BatalhaProxima();
        }

        private void BatalhaProxima()
        {
            if (duelIndex >= P1.Count || duelIndex >= P2.Count)
            {
                string vencedor = P1.Count > P2.Count ? "Equipe 1" : "Equipe 2";
                MessageBox.Show($"{vencedor} venceu a batalha!", "Batalha Concluída", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (duelIndex < P1.Count && P1[duelIndex].Vida <= 0)
            {
                duelIndex++;
            }

            while (duelIndex < P2.Count && P2[duelIndex].Vida <= 0)
            {
                duelIndex++;
            }

            if (duelIndex >= P1.Count || duelIndex >= P2.Count)
            {
                BatalhaProxima();
                return;
            }

            Slot p1Slot = P1[duelIndex];
            Slot p2Slot = P2[duelIndex];

            if (p1Slot.Vida > 0 && p2Slot.Vida > 0)
            {
                p2Slot.Vida -= p1Slot.Forca;
                p1Slot.Vida -= p2Slot.Forca;

                P4.Clear();
                P4.Add(p1Slot);
                P4.Add(p2Slot);

                dataGridView5.DataSource = null;
                dataGridView5.DataSource = P4;

                duelIndex++;
            }

            // Remove dead slots from P1 and P2
            P1.RemoveAll(slot => slot.Vida <= 0);
            P2.RemoveAll(slot => slot.Vida <= 0);

            // Refresh DataGridViews to reflect changes in P1 and P2
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = P1;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = P2;
        }
        private void EscritaCache(int processador, int endereco, string novoDado)
        {
            switch (processador)
            {
                case 1:
                    cacheController.WriteData(endereco, novoDado, memory.CacheP1, memory.CacheP2, memory.CacheP3);
                    MessageBox.Show("Escrita realizada na Cache P1", "Escrita Cache");
                    break;
                case 2:
                    cacheController.WriteData(endereco, novoDado, memory.CacheP2, memory.CacheP1, memory.CacheP3);
                    MessageBox.Show("Escrita realizada na Cache P2", "Escrita Cache");
                    break;
                case 3:
                    cacheController.WriteData(endereco, novoDado, memory.CacheP3, memory.CacheP1, memory.CacheP2);
                    MessageBox.Show("Escrita realizada na Cache P3", "Escrita Cache");
                    break;
                default:
                    MessageBox.Show("Processador inválido!", "Erro");
                    break;
            }
        }
        private void LeituraCache(int processador, int endereco)
        {
            string resultado;

            switch (processador)
            {
                case 1:
                    resultado = cacheController.ReadData(endereco, memory.CacheP1, memory.CacheP2, memory.CacheP3);
                    MessageBox.Show($"Resultado da leitura: {resultado}", "Leitura Cache P1");
                    break;
                case 2:
                    resultado = cacheController.ReadData(endereco, memory.CacheP2, memory.CacheP1, memory.CacheP3);
                    MessageBox.Show($"Resultado da leitura: {resultado}", "Leitura Cache P2");
                    break;
                case 3:
                    resultado = cacheController.ReadData(endereco, memory.CacheP3, memory.CacheP1, memory.CacheP2);
                    MessageBox.Show($"Resultado da leitura: {resultado}", "Leitura Cache P3");
                    break;
                default:
                    MessageBox.Show("Processador inválido!", "Erro");
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Batalha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BatalhaProxima();
        }
        private void buttonLeitura_Click(object sender, EventArgs e)
        {
            int processador;
            int endereco;

            // Verifica se o processador foi selecionado corretamente
            if (int.TryParse(comboBoxProcessador.SelectedItem?.ToString(), out processador))
            {
                // Verifica se o endereço é um número válido
                if (int.TryParse(txtEndereco.Text, out endereco))
                {
                    // Chama a função de leitura
                    LeituraCache(processador, endereco);
                }
                else
                {
                    MessageBox.Show("Por favor, insira um endereço válido (número).", "Entrada Inválida");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um processador válido.", "Entrada Inválida");
            }
        }

        private void buttonEscrita_Click(object sender, EventArgs e)
        {
            int processador;
            int endereco;

            // Verifica se o processador foi selecionado corretamente
            if (int.TryParse(comboBoxProcessador.SelectedItem?.ToString(), out processador))
            {
                // Verifica se o endereço é um número válido
                if (int.TryParse(txtEndereco.Text, out endereco))
                {
                    string novoDado = txtNovoDado.Text; // Verifica se o dado a ser escrito está presente
                    if (!string.IsNullOrEmpty(novoDado))
                    {
                        // Chama a função de escrita
                        EscritaCache(processador, endereco, novoDado);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira o novo dado a ser escrito.", "Entrada Inválida");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um endereço válido (número).", "Entrada Inválida");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um processador válido.", "Entrada Inválida");
            }
        }


    }

    public class Slot
    {
        public int Forca { get; set; }
        public int Vida { get; set; }
        public int Inteligencia { get; set; }
        public int Destreza { get; set; }
        public int ClasseDeArmadura { get; set; }
        public int Id { get; set; }
        public string Personagem { get; set; }
        public bool Modified { get; set; } // Indica se o slot foi modificado
        public int Equipe { get; set; }
        public int Linha { get; set; }
        public string Dado { get; set; }

    }
}