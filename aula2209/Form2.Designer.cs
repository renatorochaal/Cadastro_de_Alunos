namespace Cadastro
{
    partial class Cadastro
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
            this.dadosAluno = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.idadeAluno = new System.Windows.Forms.TextBox();
            this.matriculaAluno = new System.Windows.Forms.TextBox();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dadosAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadosAluno
            // 
            this.dadosAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosAluno.Controls.Add(this.cancelar);
            this.dadosAluno.Controls.Add(this.Limpar);
            this.dadosAluno.Controls.Add(this.Salvar);
            this.dadosAluno.Controls.Add(this.idadeAluno);
            this.dadosAluno.Controls.Add(this.matriculaAluno);
            this.dadosAluno.Controls.Add(this.nomeAluno);
            this.dadosAluno.Controls.Add(this.label3);
            this.dadosAluno.Controls.Add(this.label2);
            this.dadosAluno.Controls.Add(this.label1);
            this.dadosAluno.Location = new System.Drawing.Point(12, 12);
            this.dadosAluno.Name = "dadosAluno";
            this.dadosAluno.Size = new System.Drawing.Size(776, 426);
            this.dadosAluno.TabIndex = 0;
            this.dadosAluno.TabStop = false;
            this.dadosAluno.Text = "Dados do Aluno";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(544, 289);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 33);
            this.cancelar.TabIndex = 17;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(314, 289);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(128, 33);
            this.Limpar.TabIndex = 16;
            this.Limpar.Text = "Limpar Dados";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Salvar
            // 
            this.Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Salvar.Location = new System.Drawing.Point(83, 289);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(154, 33);
            this.Salvar.TabIndex = 15;
            this.Salvar.Text = "Salvar Dados";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // idadeAluno
            // 
            this.idadeAluno.Location = new System.Drawing.Point(165, 185);
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.Size = new System.Drawing.Size(235, 22);
            this.idadeAluno.TabIndex = 14;
            // 
            // matriculaAluno
            // 
            this.matriculaAluno.Location = new System.Drawing.Point(165, 112);
            this.matriculaAluno.Name = "matriculaAluno";
            this.matriculaAluno.Size = new System.Drawing.Size(235, 22);
            this.matriculaAluno.TabIndex = 13;
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(165, 51);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(454, 22);
            this.nomeAluno.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dadosAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Cadastro de Aluno ";
            this.dadosAluno.ResumeLayout(false);
            this.dadosAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dadosAluno;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox idadeAluno;
        private System.Windows.Forms.TextBox matriculaAluno;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}