
namespace OperadoresTipos
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPrincipal = new System.Windows.Forms.ListBox();
            this.btnFormatacao = new System.Windows.Forms.Button();
            this.lblFormatacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(331, 61);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 17);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(25, 61);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(46, 17);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "label1";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(28, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(46, 17);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mais Operadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPrincipal
            // 
            this.listBoxPrincipal.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxPrincipal.FormattingEnabled = true;
            this.listBoxPrincipal.ItemHeight = 16;
            this.listBoxPrincipal.Location = new System.Drawing.Point(112, 234);
            this.listBoxPrincipal.Name = "listBoxPrincipal";
            this.listBoxPrincipal.Size = new System.Drawing.Size(513, 68);
            this.listBoxPrincipal.TabIndex = 5;
            // 
            // btnFormatacao
            // 
            this.btnFormatacao.Location = new System.Drawing.Point(112, 308);
            this.btnFormatacao.Name = "btnFormatacao";
            this.btnFormatacao.Size = new System.Drawing.Size(513, 47);
            this.btnFormatacao.TabIndex = 6;
            this.btnFormatacao.Text = "Formatação";
            this.btnFormatacao.UseVisualStyleBackColor = true;
            this.btnFormatacao.Click += new System.EventHandler(this.btnFormatacao_Click);
            // 
            // lblFormatacao
            // 
            this.lblFormatacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFormatacao.Location = new System.Drawing.Point(112, 362);
            this.lblFormatacao.Name = "lblFormatacao";
            this.lblFormatacao.Size = new System.Drawing.Size(513, 72);
            this.lblFormatacao.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.lblFormatacao);
            this.Controls.Add(this.btnFormatacao);
            this.Controls.Add(this.listBoxPrincipal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Operadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPrincipal;
        private System.Windows.Forms.Button btnFormatacao;
        private System.Windows.Forms.Label lblFormatacao;
    }
}

