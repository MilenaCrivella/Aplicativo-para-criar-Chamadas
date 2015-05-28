using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AtividadesAluno : GroupBox 
    {
        Label labelPresenca = new Label();
        OvalPictureBox pictureBoxFoto = new OvalPictureBox();

        protected override void InitLayout()
        {
            base.InitLayout();
            labelPresenca.Text = "";
            labelPresenca.AutoSize = true;
            labelPresenca.Size = new Size (40,40);
            this.Controls.Add(labelPresenca);
        }
    }
}
