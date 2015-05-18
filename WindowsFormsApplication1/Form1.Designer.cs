namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_disciplina = new System.Windows.Forms.Label();
            this.label_nRegistrdo = new System.Windows.Forms.Label();
            this.comboBox_disciplina = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cinderela = new System.Windows.Forms.Label();
            this.Aluno1 = new System.Windows.Forms.GroupBox();
            this.ovalPictureBoxFotoAluno = new WindowsFormsApplication1.OvalPictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.Aluno1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxFotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label_disciplina
            // 
            this.label_disciplina.AutoSize = true;
            this.label_disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disciplina.Location = new System.Drawing.Point(26, 36);
            this.label_disciplina.Name = "label_disciplina";
            this.label_disciplina.Size = new System.Drawing.Size(80, 20);
            this.label_disciplina.TabIndex = 5;
            this.label_disciplina.Text = "Disciplina:";
            // 
            // label_nRegistrdo
            // 
            this.label_nRegistrdo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_nRegistrdo.Location = new System.Drawing.Point(20, 16);
            this.label_nRegistrdo.Name = "label_nRegistrdo";
            this.label_nRegistrdo.Size = new System.Drawing.Size(81, 13);
            this.label_nRegistrdo.TabIndex = 8;
            this.label_nRegistrdo.Text = "Não Registrado";
            this.label_nRegistrdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_disciplina
            // 
            this.comboBox_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_disciplina.FormattingEnabled = true;
            this.comboBox_disciplina.Location = new System.Drawing.Point(119, 36);
            this.comboBox_disciplina.Name = "comboBox_disciplina";
            this.comboBox_disciplina.Size = new System.Drawing.Size(171, 21);
            this.comboBox_disciplina.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarDisciplinaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarDisciplinaToolStripMenuItem
            // 
            this.adicionarDisciplinaToolStripMenuItem.Name = "adicionarDisciplinaToolStripMenuItem";
            this.adicionarDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.adicionarDisciplinaToolStripMenuItem.Text = "Adicionar Disciplina";
            this.adicionarDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.Adicionar_disciplina);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.Fechar);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.Salvar_Faltas);
            // 
            // Cinderela
            // 
            this.Cinderela.AutoSize = true;
            this.Cinderela.Location = new System.Drawing.Point(36, 115);
            this.Cinderela.Name = "Cinderela";
            this.Cinderela.Size = new System.Drawing.Size(51, 13);
            this.Cinderela.TabIndex = 12;
            this.Cinderela.Text = "Cinderela";
            // 
            // Aluno1
            // 
            this.Aluno1.Controls.Add(this.ovalPictureBoxFotoAluno);
            this.Aluno1.Controls.Add(this.Cinderela);
            this.Aluno1.Controls.Add(this.label_nRegistrdo);
            this.Aluno1.Location = new System.Drawing.Point(39, 88);
            this.Aluno1.Name = "Aluno1";
            this.Aluno1.Size = new System.Drawing.Size(118, 140);
            this.Aluno1.TabIndex = 13;
            this.Aluno1.TabStop = false;
            // 
            // ovalPictureBoxFotoAluno
            // 
            this.ovalPictureBoxFotoAluno.BackColor = System.Drawing.Color.DarkBlue;
            this.ovalPictureBoxFotoAluno.Image = global::WindowsFormsApplication1.Properties.Resources.littlecindy;
            this.ovalPictureBoxFotoAluno.Location = new System.Drawing.Point(21, 32);
            this.ovalPictureBoxFotoAluno.Name = "ovalPictureBoxFotoAluno";
            this.ovalPictureBoxFotoAluno.Size = new System.Drawing.Size(80, 80);
            this.ovalPictureBoxFotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ovalPictureBoxFotoAluno.TabIndex = 9;
            this.ovalPictureBoxFotoAluno.TabStop = false;
            this.ovalPictureBoxFotoAluno.Click += new System.EventHandler(this.RegistrarPresenca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 409);
            this.Controls.Add(this.Aluno1);
            this.Controls.Add(this.comboBox_disciplina);
            this.Controls.Add(this.label_disciplina);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trabalhinho legal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Aluno1.ResumeLayout(false);
            this.Aluno1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxFotoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_disciplina;
        private System.Windows.Forms.Label label_nRegistrdo;
        private OvalPictureBox ovalPictureBoxFotoAluno;
        private System.Windows.Forms.ComboBox comboBox_disciplina;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label Cinderela;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.GroupBox Aluno1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

