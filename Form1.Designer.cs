namespace UrnaEletronica
{
    partial class Urna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tela = new System.Windows.Forms.Panel();
            this.informacoes = new System.Windows.Forms.Panel();
            this.nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.canditato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotocandidato = new System.Windows.Forms.PictureBox();
            this.Botoes = new System.Windows.Forms.Panel();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFim = new System.Windows.Forms.Button();
            this.tela.SuspendLayout();
            this.informacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotocandidato)).BeginInit();
            this.Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tela.Controls.Add(this.informacoes);
            this.tela.Controls.Add(this.fotocandidato);
            this.tela.Location = new System.Drawing.Point(59, 119);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(346, 234);
            this.tela.TabIndex = 0;
            // 
            // informacoes
            // 
            this.informacoes.Controls.Add(this.nome);
            this.informacoes.Controls.Add(this.label2);
            this.informacoes.Controls.Add(this.canditato);
            this.informacoes.Controls.Add(this.label1);
            this.informacoes.Location = new System.Drawing.Point(162, 39);
            this.informacoes.Name = "informacoes";
            this.informacoes.Size = new System.Drawing.Size(157, 136);
            this.informacoes.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(74, 85);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 15);
            this.nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // canditato
            // 
            this.canditato.AutoSize = true;
            this.canditato.Location = new System.Drawing.Point(87, 31);
            this.canditato.Name = "canditato";
            this.canditato.Size = new System.Drawing.Size(25, 15);
            this.canditato.TabIndex = 1;
            this.canditato.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // fotocandidato
            // 
            this.fotocandidato.BackColor = System.Drawing.Color.Transparent;
            this.fotocandidato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotocandidato.Location = new System.Drawing.Point(26, 39);
            this.fotocandidato.Name = "fotocandidato";
            this.fotocandidato.Size = new System.Drawing.Size(111, 146);
            this.fotocandidato.TabIndex = 0;
            this.fotocandidato.TabStop = false;
            // 
            // Botoes
            // 
            this.Botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.Botoes.Controls.Add(this.btnConfirma);
            this.Botoes.Controls.Add(this.btnCorrige);
            this.Botoes.Controls.Add(this.btnBranco);
            this.Botoes.Controls.Add(this.button0);
            this.Botoes.Controls.Add(this.button9);
            this.Botoes.Controls.Add(this.button8);
            this.Botoes.Controls.Add(this.button7);
            this.Botoes.Controls.Add(this.button6);
            this.Botoes.Controls.Add(this.button5);
            this.Botoes.Controls.Add(this.button4);
            this.Botoes.Controls.Add(this.button3);
            this.Botoes.Controls.Add(this.button2);
            this.Botoes.Controls.Add(this.button1);
            this.Botoes.Location = new System.Drawing.Point(456, 62);
            this.Botoes.Name = "Botoes";
            this.Botoes.Size = new System.Drawing.Size(375, 417);
            this.Botoes.TabIndex = 1;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirma.Location = new System.Drawing.Point(248, 342);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(103, 61);
            this.btnConfirma.TabIndex = 14;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCorrige.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCorrige.Location = new System.Drawing.Point(136, 342);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(92, 61);
            this.btnCorrige.TabIndex = 13;
            this.btnCorrige.Text = "CORRIGE";
            this.btnCorrige.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.White;
            this.btnBranco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBranco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBranco.Location = new System.Drawing.Point(23, 342);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(92, 61);
            this.btnBranco.TabIndex = 10;
            this.btnBranco.Text = "BRANCO";
            this.btnBranco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Transparent;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.Location = new System.Drawing.Point(136, 263);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(92, 61);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(248, 181);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 61);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(136, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 61);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(23, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 61);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(248, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(136, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(23, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(248, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(136, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(23, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFim
            // 
            this.btnFim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFim.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFim.Location = new System.Drawing.Point(64, 399);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(345, 72);
            this.btnFim.TabIndex = 2;
            this.btnFim.Text = "Finalizar Votação";
            this.btnFim.UseVisualStyleBackColor = false;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 508);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.Botoes);
            this.Controls.Add(this.tela);
            this.Name = "Urna";
            this.Text = "Urna";
            this.tela.ResumeLayout(false);
            this.informacoes.ResumeLayout(false);
            this.informacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotocandidato)).EndInit();
            this.Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel tela;
        private Panel informacoes;
        private PictureBox fotocandidato;
        private Panel Botoes;
        private Button btnBranco;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnCorrige;
        private Button btnConfirma;
        private Button btnFim;
        private Label label1;
        private Label label2;
        private Label canditato;
        private Label nome;
    }
}