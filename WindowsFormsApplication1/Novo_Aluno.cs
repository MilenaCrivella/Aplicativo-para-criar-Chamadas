using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Novo_Aluno
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 220;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.MaximizeBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            OpenFileDialog abrirImagem = new OpenFileDialog();
            OvalPictureBox fotoAluno = new OvalPictureBox() { Left = 300, Top = 20, Width = 80, Height = 80, BackColor = Color.DarkBlue, SizeMode = PictureBoxSizeMode.Zoom };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 230 };
            TextBox txtAluno = new TextBox() { Left = 30, Top = 50, Width = 230 };
            Button confirmation = new Button() { Text = "Salvar", Left = 20, Width = 100, Top = 100 };
            confirmation.Click += (sender, e) =>
            {
                prompt.Close();
                fotoAluno.Image.Save(Application.StartupPath.ToString() + "\\FotosAlunos\\" + txtAluno.Text + ".jpg");
            };

            Button carregarImagem = new Button() { Text = "Carregar Imagem", Left = 140, Width = 100, Top = 100 };
            carregarImagem.Click += (sender, e) =>
            {
                if (abrirImagem.ShowDialog() == DialogResult.OK) fotoAluno.Load(abrirImagem.FileName);
            };
            
            prompt.Controls.Add(fotoAluno);
            prompt.Controls.Add(txtAluno);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(carregarImagem);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.AcceptButton = carregarImagem;
            prompt.ShowDialog();

            return txtAluno.Text;
            
        }
    }
}

