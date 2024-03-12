namespace prjct_winforms
{
    partial class frmCalculadora
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
            this.components = new System.ComponentModel.Container();
            this.btnsoma = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbNumeroUm = new System.Windows.Forms.TextBox();
            this.txbNumeroDois = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.btnCompara = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(130, 177);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(129, 57);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "Somar";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbNumeroUm
            // 
            this.txbNumeroUm.Location = new System.Drawing.Point(282, 56);
            this.txbNumeroUm.Name = "txbNumeroUm";
            this.txbNumeroUm.Size = new System.Drawing.Size(236, 20);
            this.txbNumeroUm.TabIndex = 2;
            this.txbNumeroUm.Text = "Ponha aqui o primeiro número";
            this.txbNumeroUm.TextChanged += new System.EventHandler(this.txbNumeroUm_TextChanged);
            // 
            // txbNumeroDois
            // 
            this.txbNumeroDois.Location = new System.Drawing.Point(282, 82);
            this.txbNumeroDois.Name = "txbNumeroDois";
            this.txbNumeroDois.Size = new System.Drawing.Size(236, 20);
            this.txbNumeroDois.TabIndex = 3;
            this.txbNumeroDois.Text = "Ponha aqui o segundo número";
            this.txbNumeroDois.TextChanged += new System.EventHandler(this.txbNumeroDois_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "?";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(265, 177);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(129, 57);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "Subtrair";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(400, 177);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(129, 57);
            this.btnVezes.TabIndex = 7;
            this.btnVezes.Text = "Multiplicar";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(535, 177);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(129, 57);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Dividir";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(266, 303);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(129, 57);
            this.btnLimpa.TabIndex = 12;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(400, 303);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(129, 57);
            this.btnFecha.TabIndex = 13;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnImparPar
            // 
            this.btnImparPar.Location = new System.Drawing.Point(400, 240);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(129, 57);
            this.btnImparPar.TabIndex = 15;
            this.btnImparPar.Text = "Impar/par";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.btnImparPar_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(266, 240);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(129, 57);
            this.btnCompara.TabIndex = 14;
            this.btnCompara.Text = "Comparar";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(382, 122);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "?";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnImparPar);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumeroDois);
            this.Controls.Add(this.txbNumeroUm);
            this.Controls.Add(this.btnsoma);
            this.Name = "frmCalculadora";
            this.Text = "Cálculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbNumeroUm;
        private System.Windows.Forms.TextBox txbNumeroDois;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnImparPar;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label lblResultado;
    }
}

