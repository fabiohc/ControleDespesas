using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ObjetoDeTransferenciaDto;
using Negocios;
using Utilitarios;
using Utilitarios.cs;
using System.Runtime.InteropServices;

namespace Apresentação
{
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }
        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            formataMasacara();
        }
        private void formataMasacara()
        {
            string valor;
            valor = textBoxValor.Text;

            Moeda mascaraMoeda = new Moeda();
            mascaraMoeda.adicionaMascaraMoeda(ref valor);

            textBoxValor.Text = valor;
            textBoxValor.SelectionStart = textBoxValor.TextLength;
            textBoxValor.TextAlign = HorizontalAlignment.Right;
        }
        private void cbxPessoa_DropDown(object sender, EventArgs e)
        {
            if (cbxPessoa.SelectedText != null)
            {
                limpaComboNomeEhIdPessoa();
            }
            preencheComboNome();
        }
        private void limpaComboNomeEhIdPessoa()
        {
            cbxPessoa.SelectedIndex = -1;
            txtCodPessoaEntrada.DataBindings.Clear();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bool val = validaDados("Adicionar");

            if (val == false)
            {

                dtGridDadosCredito.Rows.Add(txtCodPessoaEntrada.Text,
                                                cbxPessoa.Text,
                                                cbxOrigem.Text,
                                                textBoxValor.Text,
                                                cbxTipo.Text,
                                                DTReceita.Text);
                limpaCampos();
            }
        }
        private void limpaCampos([Optional] string acaoEditar)
        {
            if (acaoEditar == "Editar")
            {
                txtCodPessoaEntrada.Text = "";
                cbxPessoa.Text = "";
            }
            cbxTipo.Text = "";
            cbxOrigem.Text = "";
            textBoxValor.Clear();
            this.DTReceita.Value = DateTime.Now.Date;
        }
        private void preencheComboNome()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

            colecaoPessoa = pessoaNegocio.consultarPessoaNome(cbxPessoa.Text);

            cbxPessoa.DataSource = null;
            cbxPessoa.DisplayMember = "Nome";
            cbxPessoa.DataSource = colecaoPessoa;

            txtCodPessoaEntrada.DataBindings.Add("text", colecaoPessoa, "IdPessoa");
        }
        private void cbxOrigem_DropDown(object sender, EventArgs e)
        {
            OrigemNegocio origemNegocio = new OrigemNegocio();

            ColecaoOrigemDTO colecaoOrigemDTO = new ColecaoOrigemDTO();

            colecaoOrigemDTO = origemNegocio.consultarOrigem(cbxOrigem.Text);

            cbxOrigem.DataSource = null;
            cbxOrigem.DisplayMember = "Origem";
            cbxOrigem.DataSource = colecaoOrigemDTO;
        }
        private void cbxTipo_DropDown(object sender, EventArgs e)
        {
            TipoNegocio tipoNegocio = new TipoNegocio();

            ColecaoTipoDTO colecaoTipoDTO = new ColecaoTipoDTO();

            colecaoTipoDTO = tipoNegocio.consultarTipo(cbxTipo.Text);

            cbxTipo.DataSource = null;
            cbxTipo.DisplayMember = "Tipo";
            cbxTipo.DataSource = colecaoTipoDTO;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool val = validaDados("salvar");

            if (val == false)
            {
                ReceitaNegocio receitaNegocio = new ReceitaNegocio();

                ColecaoReceita colecaoReceita = new ColecaoReceita();

                for (int i = 0; i < dtGridDadosCredito.Rows.Count - 1; i++)
                {
                    DateTime agora = DateTime.Now;
                    ReceitaDto receitaDto = new ReceitaDto();

                    receitaDto.IdPessoa = Convert.ToInt32(dtGridDadosCredito.Rows[i].Cells[0].Value);
                    receitaDto.Origem = dtGridDadosCredito.Rows[i].Cells[2].Value.ToString();
                    receitaDto.Valor = dtGridDadosCredito.Rows[i].Cells[3].Value.ToString();
                    receitaDto.Tipo = dtGridDadosCredito.Rows[i].Cells[4].Value.ToString();
                    receitaDto.Data = Convert.ToDateTime(dtGridDadosCredito.Rows[i].Cells[5].Value);
                    receitaDto.DataHoraCadastro = Convert.ToDateTime(string.Format("{0:dd/MM/yyyy HH:mm}", agora));

                    colecaoReceita.Add(receitaDto);
                }

                receitaNegocio.Inserir(colecaoReceita);

                try
                {
                   DialogResult resultado = MessageBox.Show("Ação realizada com Sucesso! ", "Imformação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button1);

                    dtGridDadosCredito.Rows.Clear();
                    dtGridDadosCredito.Refresh();

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel inserir o registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
        private void txtCodPessoaEntrada_TextChanged(object sender, EventArgs e)
        {
            buscaPessoaPorId();
        }
        private void buscaPessoaPorId()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

            if (!string.IsNullOrEmpty(txtCodPessoaEntrada.Text))
            {
                colecaoPessoa = pessoaNegocio.ConsultarPessoaPorId(txtCodPessoaEntrada.Text);

                cbxPessoa.DataSource = null;
                cbxPessoa.DisplayMember = "Nome";
                cbxPessoa.DataSource = colecaoPessoa;
            }
        }
        private bool validaDados(string acao)
        {

            bool validacaoItem = false;
            switch (acao)
            {
                case "Adicionar":
                    {
                        if (string.IsNullOrEmpty(txtCodPessoaEntrada.Text) || string.IsNullOrEmpty(cbxPessoa.Text))
                        {
                            MessageBox.Show("Selecione uma pessoa!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            txtCodPessoaEntrada.Focus();
                            return validacaoItem = true;
                        }

                        if (string.IsNullOrEmpty(cbxOrigem.Text))
                        {
                            MessageBox.Show("Selecione uma Origem!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbxTipo.Focus();
                            return validacaoItem = true;
                        }

                        if (string.IsNullOrEmpty(cbxTipo.Text))
                        {
                            MessageBox.Show("Selecione um Tipo!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbxTipo.Focus();
                            return validacaoItem = true;
                        }

                        if (textBoxValor.Text.Equals("0,00"))
                        {
                            if (MessageBox.Show("O valor é 0,00.\n Tem certeza que deseja adionar esse valor?", "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1) == DialogResult.No)
                            {
                                textBoxValor.Focus();
                                return validacaoItem = true;
                            }
                            return validacaoItem = false;
                        }
                        break;
                    }

                case "salvar":
                    {
                        if (dtGridDadosCredito.RowCount == 1)
                        {

                            MessageBox.Show("Adicione itens na Grid para salvar.", "Atenção",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation,
                           MessageBoxDefaultButton.Button1);
                            txtCodPessoaEntrada.Focus();

                            return validacaoItem = true;
                        }
                        break;
                    }
            }
            return validacaoItem;
        }
        private void txtCodPessoaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ReceitaDto receitaDto = new ReceitaDto();

            if (dtGridDadosCredito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para edição.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Confirmar edição da linha selecionada?", "Pergunta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);


            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                limpaCampos("Editar");

                txtCodPessoaEntrada.Text = dtGridDadosCredito.SelectedRows[0].Cells[0].Value.ToString();
                cbxPessoa.Text = dtGridDadosCredito.SelectedRows[0].Cells[1].Value.ToString();
                cbxOrigem.Text = dtGridDadosCredito.SelectedRows[0].Cells[2].Value.ToString();
                textBoxValor.Text = dtGridDadosCredito.SelectedRows[0].Cells[3].Value.ToString();
                cbxTipo.Text = dtGridDadosCredito.SelectedRows[0].Cells[4].Value.ToString();
                DTReceita.Text = dtGridDadosCredito.SelectedRows[0].Cells[5].Value.ToString();

                //Remove a linha após subir para edição
                dtGridDadosCredito.Rows.Remove(dtGridDadosCredito.SelectedRows[0]);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dtGridDadosCredito.RowCount > 1)
            {
                if (dtGridDadosCredito.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para remoção.");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Confirmar remoção da linha selecionada?", "Pergunta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                cbxTipo.Focus();

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    dtGridDadosCredito.Rows.Remove(dtGridDadosCredito.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Não há registros para remoção.");
                return;
            }
        }
    }
}
