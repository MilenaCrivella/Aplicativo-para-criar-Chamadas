using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Prompt
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
            TextBox txtDisciplina = new TextBox() { Left = 30, Top = 50, Width = 230 };
            Button confirmation = new Button() { Text = "Salvar", Left = 30, Width = 100, Top = 100 };
            Button cancelar = new Button() { Text = "Cancelar", Left = 160, Width = 100, Top = 100 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancelar.Click += (sender, e) => { prompt.Close();};
            prompt.Controls.Add(txtDisciplina);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelar);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.AcceptButton = cancelar;
            prompt.ShowDialog();
            return txtDisciplina.Text;
        }
    }
}
