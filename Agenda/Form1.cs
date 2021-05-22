using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class formAgenda : Form
    {
        private void CarregarLista()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorDeArquivos.LerArquivo().ToArray());
            
        }
        private void LimparCampos()
        {
            tbxNome.Text = "";
            tbxEmal.Text = "";
            tbxTelefone.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBtnsSalvareCancelar(false);
            AlterarBtnsDemaisBtns(true);
            AlterarEstadoCampos(false);

        }
        private void AlterarEstadoCampos(bool estado)
        {
            tbxNome.Enabled = estado;
            tbxEmal.Enabled = estado;
            tbxTelefone.Enabled = estado;
        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContatos.SelectedIndex >= 0)
            {
                Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
                tbxNome.Text = contato.Nome;
                tbxEmal.Text = contato.Email;
                tbxTelefone.Text = contato.Telefone;
            }
        }
        private OperacaoEnum acao;
        public formAgenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formAgenda_Shown(object sender, EventArgs e)
        {
            AlterarBtnsSalvareCancelar(false);
            AlterarBtnsDemaisBtns(true);
            CarregarLista();
            AlterarEstadoCampos(false);
        }

        private void AlterarBtnsSalvareCancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        private void AlterarBtnsDemaisBtns(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBtnsSalvareCancelar(true);
            AlterarBtnsDemaisBtns(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBtnsSalvareCancelar(true);
            AlterarBtnsDemaisBtns(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acao == OperacaoEnum.INCLUIR)
            {
                Contato contato = new Contato
                {
                    Nome = tbxNome.Text,
                    Email = tbxEmal.Text,
                    Telefone = tbxTelefone.Text
                };

                List<Contato> contatosList = new List<Contato>();

                foreach (Contato contatoDaLista in lbxContatos.Items)
                {
                    contatosList.Add(contatoDaLista);
                }
                contatosList.Add(contato);
                ManipuladorDeArquivos.EscreverArquivo(contatosList);
                CarregarLista();
                LimparCampos();
                AlterarEstadoCampos(false);
                AlterarBtnsSalvareCancelar(false);
                AlterarBtnsDemaisBtns(true);

            }
            else
            {
                Contato contato = new Contato
                {
                    Nome = tbxNome.Text,
                    Email = tbxEmal.Text,
                    Telefone = tbxTelefone.Text
                };
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contatoDaLista in lbxContatos.Items)
                {
                    contatosList.Add(contatoDaLista);
                }
                int indice = lbxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice, contato);
                ManipuladorDeArquivos.EscreverArquivo(contatosList);
                CarregarLista();
                LimparCampos();
                AlterarEstadoCampos(false);
                AlterarBtnsSalvareCancelar(false);
                AlterarBtnsDemaisBtns(true);


            }
            
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem Certeza?", "Exlcuir Contato", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                int indiceExcluido = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indiceExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contato in lbxContatos.Items) 
                {
                    contatosList.Add(contato);
                }
                ManipuladorDeArquivos.EscreverArquivo(contatosList);
               
                CarregarLista();
                LimparCampos();
            }
        }
    } 
}


