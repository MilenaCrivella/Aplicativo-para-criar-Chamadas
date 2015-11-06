using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace AplicativoDeChamada
{
    public partial class Form1 : Form
    {
        string salvar = "disciplinas.txt";
        string nomes = "NomesEstudante.txt";
        string arq = "ChamadaAlunos.txt";
        string disciplina;


        List<AtividadesAluno> listaAtividadesAlunos = new List<AtividadesAluno>();

        public Form1()
        {
            InitializeComponent();
            Lendo_Arquivos_Salvos(); 

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
            int OffSetTop = 40;

            for (int i = 0; i < listaAtividadesAlunos.Count; i++)
            {
                int c = (i % 3);
                int l = (int)Math.Floor(i / 3.0);
                AtividadesAluno a = listaAtividadesAlunos.ElementAt(i);
                a.Location = new Point(a.Size.Width * c + OffSetLeft + (c * 10), a.Size.Height * l + OffSetTop + (l * 10));
                ListaAlunos.Controls.Add(listaAtividadesAlunos.ElementAt(i));
                novoEstudante.posicaoX = Convert.ToString(a.Location.X);
                novoEstudante.posicaoY = Convert.ToString(a.Location.Y);
            }

            novoEstudante.estudante = promptValue;
            using (StreamWriter file = new StreamWriter(nomes, true))
            {
                file.WriteLine(novoEstudante.estudantesAsString());
            }
        }

        private void Salvar_Faltas(object sender, EventArgs e)
        {
            foreach (AtividadesAluno a in listaAtividadesAlunos)
            {
                Aluno aluno = new Aluno();

                aluno.disciplina = comboBox_disciplina.Text;
                aluno.data = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                aluno.alunos = a.Text;

                switch (a.presencaAtual)
                {
                    case 0:
                        aluno.presenca = "Não Registrado";
                        break;

                    case 1:
                        aluno.presenca = "Presente";
                        break;

                    case 2:
                        aluno.presenca = "Ausente";
                        break;

                    case 3:
                        aluno.presenca = "Justificado";
                        break;
                }
                using (StreamWriter file = new StreamWriter(arq, true))
                {
                    file.WriteLine(aluno.alunoAsString());
                }

            }

            //Chamada.AutoGenerateColumns = false;
            //DataGridViewColumn coluna = new DataGridViewColumn();
            //coluna.HeaderText = "Codigo";
            //coluna.Name = "Codigo";
            //coluna.Visible = true;
            //coluna.Width = 40;
            //Chamada.Columns.Add(coluna);
     
     }

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
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
                    AtividadesAluno a = new AtividadesAluno() { Width = 118, Height = 140 };
                    a.Text = novoEstudante.estudante;
                    a.Location = new Point(Convert.ToInt32(novoEstudante.posicaoX), Convert.ToInt32(novoEstudante.posicaoY));
                    listaAtividadesAlunos.Add(a);
                    ListaAlunos.Controls.Add(a);
                    //OrderBy
                }

            }

            
        }
    }
}
