namespace Cadastro
{
    partial class Listagem
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
            this.listagemAlunos = new System.Windows.Forms.GroupBox();
            this.Matricula = new System.Windows.Forms.ComboBox();
            this.IdadeAluno = new System.Windows.Forms.TextBox();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listagemAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listagemAlunos
            // 
            this.listagemAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listagemAlunos.Controls.Add(this.Matricula);
            this.listagemAlunos.Controls.Add(this.IdadeAluno);
            this.listagemAlunos.Controls.Add(this.nomeAluno);
            this.listagemAlunos.Controls.Add(this.Cancelar);
            this.listagemAlunos.Controls.Add(this.label3);
            this.listagemAlunos.Controls.Add(this.label2);
            this.listagemAlunos.Controls.Add(this.label1);
            this.listagemAlunos.Location = new System.Drawing.Point(12, 12);
            this.listagemAlunos.Name = "listagemAlunos";
            this.listagemAlunos.Size = new System.Drawing.Size(745, 361);
            this.listagemAlunos.TabIndex = 0;
            this.listagemAlunos.TabStop = false;
            this.listagemAlunos.Text = "Alunos Cadastrados";
            this.listagemAlunos.Enter += new System.EventHandler(this.listagemAlunos_Enter);
            // 
            // Matricula
            // 
            this.Matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Matricula.FormattingEnabled = true;
            this.Matricula.Location = new System.Drawing.Point(280, 53);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(202, 24);
            this.Matricula.TabIndex = 6;
            this.Matricula.SelectedIndexChanged += new System.EventHandler(this.Matricula_SelectedIndexChanged);
            // 
            // IdadeAluno
            // 
            this.IdadeAluno.Location = new System.Drawing.Point(290, 181);
            this.IdadeAluno.Name = "IdadeAluno";
            this.IdadeAluno.ReadOnly = true;
            this.IdadeAluno.Size = new System.Drawing.Size(105, 22);
            this.IdadeAluno.TabIndex = 5;
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(280, 118);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Size = new System.Drawing.Size(445, 22);
            this.nomeAluno.TabIndex = 4;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(620, 266);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(83, 32);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma Matricula: ";
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 385);
            this.Controls.Add(this.listagemAlunos);
            this.Name = "Listagem";
            this.Text = "Listagem de Alunos";
            this.listagemAlunos.ResumeLayout(false);
            this.listagemAlunos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listagemAlunos;
        private System.Windows.Forms.ComboBox Matricula;
        private System.Windows.Forms.TextBox IdadeAluno;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}