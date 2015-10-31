namespace AplicativoDeChamada
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabBtt = new System.Windows.Forms.TabControl();
            this.ListaAlunos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_disciplina = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Chamada = new System.Windows.Forms.DataGridView();
            this.NomesAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabBtt.SuspendLayout();
            this.ListaAlunos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chamada)).BeginInit();
            this.SuspendLayout();
            // 
            // TabBtt
            // 
            this.TabBtt.Controls.Add(this.ListaAlunos);
            this.TabBtt.Controls.Add(this.tabPage2);
            this.TabBtt.Location = new System.Drawing.Point(2, 1);
            this.TabBtt.Name = "TabBtt";
            this.TabBtt.SelectedIndex = 0;
            this.TabBtt.Size = new System.Drawing.Size(450, 428);
            this.TabBtt.TabIndex = 0;
            // 
            // ListaAlunos
            // 
            this.ListaAlunos.Controls.Add(this.label1);
            this.ListaAlunos.Controls.Add(this.comboBox_disciplina);
            this.ListaAlunos.Location = new System.Drawing.Point(4, 22);
            this.ListaAlunos.Name = "ListaAlunos";
            this.ListaAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.ListaAlunos.Size = new System.Drawing.Size(442, 402);
            this.ListaAlunos.TabIndex = 0;
            this.ListaAlunos.Text = "Lista de Alunos";
            this.ListaAlunos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplina:";
            // 
            // comboBox_disciplina
            // 
            this.comboBox_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_disciplina.FormattingEnabled = true;
            this.comboBox_disciplina.Location = new System.Drawing.Point(186, 28);
            this.comboBox_disciplina.Name = "comboBox_disciplina";
            this.comboBox_disciplina.Size = new System.Drawing.Size(188, 21);
            this.comboBox_disciplina.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Chamada);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Frequência";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Disciplina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Adicionar_disciplina);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Salvar_Faltas);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Adicionar Aluno";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Adicionar_Aluno);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Fechar);
            // 
            // Chamada
            // 
            this.Chamada.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Chamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Chamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomesAlunos});
            this.Chamada.Location = new System.Drawing.Point(6, 6);
            this.Chamada.Name = "Chamada";
            this.Chamada.RowHeadersVisible = false;
            this.Chamada.Size = new System.Drawing.Size(430, 372);
            this.Chamada.TabIndex = 0;
            // 
            // NomesAlunos
            // 
            this.NomesAlunos.HeaderText = "Alunos";
            this.NomesAlunos.Name = "NomesAlunos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabBtt);
            this.Name = "Form1";
            this.Text = "App q faz chamada";
            this.TabBtt.ResumeLayout(false);
            this.ListaAlunos.ResumeLayout(false);
            this.ListaAlunos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chamada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabBtt;
        private System.Windows.Forms.TabPage ListaAlunos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_disciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Chamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomesAlunos;
    }
}

