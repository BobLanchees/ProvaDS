using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace GUI
{
    public enum Operacao
    {
        NOVO
    }

    public partial class Form1 : Form
    {
        public Operacao tipo;

        public Form1()
        {
            InitializeComponent();
            carregarGrid();
        }

        private void carregarGrid()
        {
            dataGridFilmes.DataSource = null;
            var db = new filmeEntities();

            var lista = (from film in db.filmes select film).ToList();
            dataGridFilmes.DataSource = lista;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liberarObjetos(this);
            this.tipo = Operacao.NOVO;
            BoxNome.Focus();
        }

        private void liberarObjetos(Form1 form1)
        {
            foreach (Control x in form1.Controls)
            {
                if (x is TextBox) {
                    TextBox caixa = (TextBox)x;
                    caixa.Enabled = true;
                }
                if (x is Button) {
                    Button botao = (Button)x;
                    botao.Enabled = true;
                }
            }
        }

        private void travarObjetos(Form1 form1)
        {
            foreach (Control x in form1.Controls)
            {
                if (x is TextBox)
                {
                    TextBox caixa = (TextBox)x;
                    caixa.Enabled = false;
                }
                if (x is Button)
                {
                    Button botao = (Button)x;
                    botao.Enabled = false;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (BoxNome.Text == "") {
                MessageBox.Show("Preencha os campos obrigatórios");
                return;
            }

            var db = new filmeEntities();
            filmes objFilme = new filmes();
            if (this.tipo == Operacao.NOVO)
            {
                objFilme = db.filmes.Create();
            }

            objFilme.Nome = BoxNome.Text;
            objFilme.Genero = BoxGenero.Text;
            objFilme.Faixa_Etaria = BoxFaixa.Text;
            objFilme.Duracao = BoxDuracao.Text;

            if (this.tipo == Operacao.NOVO)
            {
                db.filmes.Add(objFilme);
            }
            db.SaveChanges();
            MessageBox.Show(null, "Filme adicionado com sucesso", "ok", MessageBoxButtons.OK);
            limparCaixasTexto(this);
            carregarGrid();
            travarObjetos(this);
        }

        private void limparCaixasTexto(Form1 form1)
        {
            foreach (Control x in form1.Controls)
            {
                if (x is TextBox)
                {
                    TextBox caixa = (TextBox)x;
                    caixa.Text = "";
                }
            }
        }

        private void dataGridFilmes_DoubleClick(object sender, EventArgs e)
        {
            int linha;
            linha = dataGridFilmes.CurrentRow.Index;
            BoxNome.Text = dataGridFilmes[0, linha].Value.ToString();
            BoxGenero.Text = dataGridFilmes[1, linha].Value.ToString();
            BoxFaixa.Text = dataGridFilmes[2, linha].Value.ToString();
            BoxDuracao.Text = dataGridFilmes[3, linha].Value.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
