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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] Presenca = { "Não Registrado", "Presente", "Ausente", "Justificado" };
        Color[] PresencaCores = { Color.Gray, Color.LimeGreen, Color.Red, Color.LightBlue };
        int presencaAtual = 0;
        string arq_disciplinas = "disciplinas.txt";

        public Form1()
        {
            InitializeComponent();
            comboBox_disciplina.Items.Clear();
            Retornar_Disciplinas();
        }

        private void RegistrarPresenca(object sender, EventArgs e)
        {
            presencaAtual++;
            if (presencaAtual + 1 > Presenca.Length)
            {
                presencaAtual = 0;
            }

            label_nRegistrdo.Text = Presenca[presencaAtual];
            label_nRegistrdo.BackColor = PresencaCores[presencaAtual];
        }

        private void Fechar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adicionar_disciplina(object sender, EventArgs e)
        {
            comboBox_disciplina.Items.Add("");
            string promptValue = Prompt.ShowDialog("Nomeie sua disciplina", "Adicionar Disciplina");
            Console.WriteLine("---");
            Console.WriteLine(promptValue);
            Console.WriteLine("---");
            comboBox_disciplina.Items.Add(promptValue);
        }

        private void Salvar_Faltas(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            string arq = "@Cinderela.txt";

            a.disciplina = comboBox_disciplina.Text;
            a.data = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            a.alunos = label_nRegistrdo.Text;

            using (StreamWriter file = new StreamWriter(arq, true))
            {
                file.WriteLine(a.funcionarioAsString());
            }

            Disciplinas d = new Disciplinas();

            d.disciplina = comboBox_disciplina.Text;

            using (StreamWriter file = new StreamWriter(arq_disciplinas, true))
            {
                file.WriteLine(d.funcionarioAsString());
            }
        }

        private void Retornar_Disciplinas()
        {
            if (!File.Exists(arq_disciplinas))
            {
                return;
            }

            String line;
            using (StreamReader file = new StreamReader(arq_disciplinas))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Disciplinas d = new Disciplinas();
                    //Console.WriteLine(line);
                    comboBox_disciplina.Items.Add(line);
                }
            }
        }

    }
}

