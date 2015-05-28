using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Novo_Aluno
    {
         public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 200;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.MaximizeBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 230 };
            TextBox txtAluno = new TextBox() { Left = 30, Top = 50, Width = 230 };
            Button confirmation = new Button() {Text = "Salvar", Left = 90, Width = 100, Top = 100 };
            confirmation.Click += (sender, e) => { prompt.Close();};
            prompt.Controls.Add(txtAluno);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            
            return txtAluno.Text;
        }
    }
 }
