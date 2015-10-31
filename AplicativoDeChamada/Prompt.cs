using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoDeChamada
{
    class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            string salvar = "disciplinas.txt";
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 200;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.MaximizeBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 230 };
            TextBox txtDisciplina = new TextBox() { Left = 30, Top = 50, Width = 230 };
            Button confirmation = new Button() { Text = "Salvar", Left = 90, Width = 100, Top = 100 };
            confirmation.Click += (sender, e) =>
            {
                prompt.Close();

                Disciplina nova_disciplina = new Disciplina();
                nova_disciplina.disciplina = txtDisciplina.Text;
                using (StreamWriter file = new StreamWriter(salvar, true))
                {
                    file.WriteLine(nova_disciplina.disciplinaAsString());
                }
            };
            prompt.Controls.Add(txtDisciplina);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();

            return txtDisciplina.Text;
        }
    }
}
