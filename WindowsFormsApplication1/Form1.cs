using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string disciplina;
        string[] Presenca = { "Não Registrado", "Presente", "Ausente", "Justificado" };
        Color[] PresencaCores = { Color.Gray, Color.LimeGreen, Color.Red, Color.LightBlue };
        int presencaAtual = 0;
        public int linhas = 2;
        public int colunas = 2;

        List<AtividadesAluno> listaAtividadesAlunos = new List<AtividadesAluno>();

        public Form1()
        {
            InitializeComponent();
            Alunos(colunas, linhas);
        }

        private void Alunos(int C, int L)
        {
            for (int i = 0; i < C; i++)
            {
                for (int n = 0; n < L; n++)
                {

                }
            }
        }

        private void RegistrarPresenca(object sender, EventArgs e)
        {
            presencaAtual++;
            if (presencaAtual + 1 > Presenca.Length)
            {
                presencaAtual = 0;
            }

            label_nRegistrado.Text = Presenca[presencaAtual];
            label_nRegistrado.BackColor = PresencaCores[presencaAtual];
        }

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adicionar_disciplina(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            string promptValue = Prompt.ShowDialog("Nomeie sua disciplina", "Adicionar Disciplina");
            comboBox_disciplina.Items.Add(promptValue);
            disciplina = comboBox_disciplina.Text;
        }

        private void Salvar_Faltas(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            string arq = "@Cinderela.txt";

            a.disciplina = comboBox_disciplina.Text;
            a.data = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            a.alunos = label_nRegistrado.Text;

            using (StreamWriter file = new StreamWriter(arq, true))
            {
                file.WriteLine(a.funcionarioAsString());
            }

            Disciplina nova_disciplina = new Disciplina();
            string salvar = "disciplinas.txt";

            nova_disciplina.disciplina = comboBox_disciplina.Text;

            using (StreamWriter file = new StreamWriter(salvar, true))
            {
                file.WriteLine(nova_disciplina.funcionarioAsString());
            }

        }

        private void Adicionar_Aluno(object sender, EventArgs e)
        {
                Novo_Aluno prompt = new Novo_Aluno();
                string promptValue = Novo_Aluno.ShowDialog("Nome do Aluno", "Novo Aluno");
                comboBox_disciplina.Items.Add(promptValue);

                int OffSetLeft = 30;
                int OffSetTop = 70;

              
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        AtividadesAluno a = new AtividadesAluno(){Width = 118, Height = 140,};
                        a.Location = new Point(a.Size.Width * c + OffSetLeft + (c * 10), a.Size.Height * l + OffSetTop + (l * 10));
                        listaAtividadesAlunos.Add(a);
                        this.Controls.Add(a);
                    }
                }
            }
    }
}
