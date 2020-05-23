namespace DesafioOscarBTG
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblCaminhoSucesso = new System.Windows.Forms.Label();
            this.lblGravacaoSucesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(160, 25);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(479, 20);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Escrever em um Banco de Dados à partir de um arquivo.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho do Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gravar informações de";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(164, 91);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(251, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(164, 142);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(251, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(421, 89);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(421, 142);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // lblCaminhoSucesso
            // 
            this.lblCaminhoSucesso.AutoSize = true;
            this.lblCaminhoSucesso.Location = new System.Drawing.Point(164, 114);
            this.lblCaminhoSucesso.Name = "lblCaminhoSucesso";
            this.lblCaminhoSucesso.Size = new System.Drawing.Size(0, 13);
            this.lblCaminhoSucesso.TabIndex = 7;
            // 
            // lblGravacaoSucesso
            // 
            this.lblGravacaoSucesso.AutoSize = true;
            this.lblGravacaoSucesso.Location = new System.Drawing.Point(164, 165);
            this.lblGravacaoSucesso.Name = "lblGravacaoSucesso";
            this.lblGravacaoSucesso.Size = new System.Drawing.Size(43, 13);
            this.lblGravacaoSucesso.TabIndex = 8;
            this.lblGravacaoSucesso.Text = "bbbbbb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGravacaoSucesso);
            this.Controls.Add(this.lblCaminhoSucesso);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblCaminhoSucesso;
        private System.Windows.Forms.Label lblGravacaoSucesso;
    }
}

