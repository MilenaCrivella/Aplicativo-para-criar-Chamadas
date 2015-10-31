using AplicativoDeChamada;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AtividadesAluno : GroupBox
    {
        public string arq = "AlunosFaltosos.txt";
        Label labelPresenca = new Label();
        OvalPictureBox fotoAluno = new OvalPictureBox();
        Button PresencaAluno = new Button() { Text = "Não Registrado", Left = 10, Width = 100, Top = 115 };

        public int presencaAtual = 0;

        public string[] Presenca = { "Não Registrado", "Presente", "Ausente", "Justificado" };
        Color[] PresencaCores = { Color.Gray, Color.LimeGreen, Color.Red, Color.LightBlue };

        public AtividadesAluno()
        {
            ResizeRedraw = true;
        }

        protected override void InitLayout()
        {
            Novo_Aluno prompt = new Novo_Aluno();
            base.InitLayout();

            fotoAluno.Location = new Point(20, 30);
            fotoAluno.Width = 80;
            fotoAluno.Height = 80;
            fotoAluno.BackColor = Color.DarkBlue;
            fotoAluno.Image = Image.FromFile(Application.StartupPath + "\\FotosAlunos\\" + this.Text + ".jpg");
            //else { fotoAluno.Image = WindowsFormsApplication1.Properties.Resources.semFoto; }

            fotoAluno.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(fotoAluno);

            this.Controls.Add(PresencaAluno);
            PresencaAluno.Click += Presenca_Click;
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            fotoAluno.Size = new Size(fotoAluno.Size.Width, fotoAluno.Size.Width);
        }

        public void Presenca_Click(object sender, EventArgs e)
        {
            presencaAtual++;
            if (presencaAtual + 1 > Presenca.Length)
            {
                presencaAtual = 0;
            }

            PresencaAluno.Text = Presenca[presencaAtual];
            PresencaAluno.BackColor = PresencaCores[presencaAtual];

        }
    }
}
