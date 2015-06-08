using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                                                                                                                                                   //Eu estive AQUI
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
        string salvar = "disciplinas.txt";
        string nomes = "NomesEstudante.txt";
        string arq = "AlunosFaltosos.txt";
        string disciplina;
        

        List<AtividadesAluno> listaAtividadesAlunos = new List<AtividadesAluno>();
        

        public Form1()
        {
            InitializeComponent();
            Lendo_Arquivos_Salvos();   
        }

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adicionar_disciplina(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            string promptValue = Prompt.ShowDialog("Nomeie sua disciplina", "Adicionar Disciplina");
            if (promptValue != "")
            {
                comboBox_disciplina.Items.Add(promptValue);
                disciplina = comboBox_disciplina.Text;
                
            }

        }
        
        public void Salvar_Faltas(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            AtividadesAluno a = new AtividadesAluno();

            aluno.disciplina = comboBox_disciplina.Text;
            aluno.data = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

            using (StreamWriter file = new StreamWriter(arq, true))
            {
                file.WriteLine(aluno.alunoAsString());
            }
        }

        private void Lendo_Arquivos_Salvos()
        {
            if (!File.Exists(salvar))
            {
                return;
            }

            String line;
            using (StreamReader file = new StreamReader(salvar))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Disciplina nova_disciplina = new Disciplina();
                    nova_disciplina.disciplinaFromString(line);
                    comboBox_disciplina.Items.Add(line);
                }
            }


            if (!File.Exists(nomes))
            {
                return;
            }

            String lines;
            using (StreamReader file = new StreamReader(nomes))
            {
                while ((lines = file.ReadLine()) != null)
                {
                    Estudantes novoEstudante = new Estudantes();
                    novoEstudante.estudantesFromString(lines);
                    Console.WriteLine(lines);
                    AtividadesAluno a = new AtividadesAluno() { Width = 118, Height = 140 };
                    a.Text = novoEstudante.estudante;
                    a.Location = new Point(Convert.ToInt32(novoEstudante.posicaoX), Convert.ToInt32(novoEstudante.posicaoY));
                    listaAtividadesAlunos.Add(a);
                    this.Controls.Add(a);
                }

            }
        }

        private void Adicionar_Aluno(object sender, EventArgs e)
        {
            Novo_Aluno prompt = new Novo_Aluno();
            string promptValue = Novo_Aluno.ShowDialog("Nome do Aluno", "Novo Aluno");
            Estudantes novoEstudante = new Estudantes();

            if (promptValue != "")
            {
                AtividadesAluno a = new AtividadesAluno() { Width = 118, Height = 140 };
                a.Text = promptValue;
                listaAtividadesAlunos.Add(a);
            }

            int OffSetLeft = 30;
            int OffSetTop = 70;

            for (int i = 0; i < listaAtividadesAlunos.Count; i++)
            {
                int c = (i % 3);
                int l = (int)Math.Floor(i / 3.0);
                Console.WriteLine("coluna: " + c + " linha: " + l);
                AtividadesAluno a = listaAtividadesAlunos.ElementAt(i);
                a.Location = new Point(a.Size.Width * c + OffSetLeft + (c * 10), a.Size.Height * l + OffSetTop + (l * 10));

                this.Controls.Add(listaAtividadesAlunos.ElementAt(i));

                novoEstudante.posicaoX = Convert.ToString(a.Location.X);
                novoEstudante.posicaoY = Convert.ToString(a.Location.Y);
            }

            novoEstudante.estudante = promptValue;
            using (StreamWriter file = new StreamWriter(nomes, true))
            {
                file.WriteLine(novoEstudante.estudantesAsString());
            }

        }

    }
}