namespace GUI
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelFaixa = new System.Windows.Forms.Label();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.BoxGenero = new System.Windows.Forms.TextBox();
            this.BoxFaixa = new System.Windows.Forms.TextBox();
            this.BoxDuracao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridFilmes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilmes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(12, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(12, 78);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 1;
            this.labelGenero.Text = "Gênero:";
            // 
            // labelFaixa
            // 
            this.labelFaixa.AutoSize = true;
            this.labelFaixa.Location = new System.Drawing.Point(12, 115);
            this.labelFaixa.Name = "labelFaixa";
            this.labelFaixa.Size = new System.Drawing.Size(65, 13);
            this.labelFaixa.TabIndex = 2;
            this.labelFaixa.Text = "Faixa Etária:";
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Location = new System.Drawing.Point(12, 151);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(51, 13);
            this.labelDuracao.TabIndex = 3;
            this.labelDuracao.Text = "Duração:";
            // 
            // BoxNome
            // 
            this.BoxNome.Enabled = false;
            this.BoxNome.Location = new System.Drawing.Point(56, 39);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(126, 20);
            this.BoxNome.TabIndex = 4;
            // 
            // BoxGenero
            // 
            this.BoxGenero.Enabled = false;
            this.BoxGenero.Location = new System.Drawing.Point(63, 75);
            this.BoxGenero.Name = "BoxGenero";
            this.BoxGenero.Size = new System.Drawing.Size(120, 20);
            this.BoxGenero.TabIndex = 5;
            // 
            // BoxFaixa
            // 
            this.BoxFaixa.Enabled = false;
            this.BoxFaixa.Location = new System.Drawing.Point(83, 112);
            this.BoxFaixa.Name = "BoxFaixa";
            this.BoxFaixa.Size = new System.Drawing.Size(100, 20);
            this.BoxFaixa.TabIndex = 6;
            // 
            // BoxDuracao
            // 
            this.BoxDuracao.Enabled = false;
            this.BoxDuracao.Location = new System.Drawing.Point(69, 148);
            this.BoxDuracao.Name = "BoxDuracao";
            this.BoxDuracao.Size = new System.Drawing.Size(114, 20);
            this.BoxDuracao.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(108, 189);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridFilmes
            // 
            this.dataGridFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilmes.Location = new System.Drawing.Point(12, 218);
            this.dataGridFilmes.Name = "dataGridFilmes";
            this.dataGridFilmes.Size = new System.Drawing.Size(399, 138);
            this.dataGridFilmes.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 368);
            this.Controls.Add(this.dataGridFilmes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.BoxDuracao);
            this.Controls.Add(this.BoxFaixa);
            this.Controls.Add(this.BoxGenero);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.labelFaixa);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cadastro de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilmes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelFaixa;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.TextBox BoxGenero;
        private System.Windows.Forms.TextBox BoxFaixa;
        private System.Windows.Forms.TextBox BoxDuracao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridFilmes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

