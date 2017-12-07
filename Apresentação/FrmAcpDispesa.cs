using System;
using System.Windows.Forms;
using Negocios;
using ObjetoDeTransferenciaDto;

namespace Apresentação
{
    public partial class FrmAcpDispesa : Form
    {
        public FrmAcpDispesa()
        {
            InitializeComponent();
            dtGridViewControle.AutoGenerateColumns = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAcpDispesa_Load(object sender, EventArgs e)
        {
            RBtmColetivo.Checked = true;
            DesabilitaEHabilitaCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizeGrid();
        }

        private void AtualizeGrid()
        {
            ReceitaNegocio receitaNegocio = new ReceitaNegocio();

            ColecaoReceita colecaoReceita = new ColecaoReceita();

            if (RBtmIndivdial.Checked == true)
            {
                colecaoReceita = receitaNegocio.ConsultarPessoaPorId(txtIdPessoa.Text,
                                                                     dtTimePickerInicio.Value,
                                                                     dtTimePickerFim.Value,
                                                                     cbxOrigem.Text,
                                                                     cbxTipo.Text);
            }
            else
            {
                colecaoReceita = receitaNegocio.ConsultarPessoaColetivo(dtTimePickerInicio.Value,
                                                                        dtTimePickerFim.Value,
                                                                        cbxOrigem.Text,
                                                                        cbxTipo.Text);
            }

            dtGridViewControle.DataSource = null;
            dtGridViewControle.DataSource = colecaoReceita;

            dtGridViewControle.Update();
            dtGridViewControle.Refresh();

        }

        private void preencheComboNome()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

            colecaoPessoa = pessoaNegocio.consultarPessoaNome(cbBoxPessoaNome.Text);

            cbBoxPessoaNome.DataSource = null;
            cbBoxPessoaNome.DisplayMember = "Nome";
            cbBoxPessoaNome.DataSource = colecaoPessoa;

            txtIdPessoa.DataBindings.Add("text", colecaoPessoa, "IdPessoa");
        }

        private void limpaComboNomeEhIdPessoa()
        {
            cbBoxPessoaNome.SelectedIndex = -1;
            txtIdPessoa.DataBindings.Clear();
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

        private void txtIdPessoa_TextChanged(object sender, EventArgs e)
        {
            buscaPessoaPorId();
        }
        private void buscaPessoaPorId()
        {
            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

            if (txtIdPessoa.Text != "")
            {
                colecaoPessoa = pessoaNegocio.ConsultarPessoaPorId(txtIdPessoa.Text);

                cbBoxPessoaNome.DataSource = null;
                cbBoxPessoaNome.DisplayMember = "Nome";
                cbBoxPessoaNome.DataSource = colecaoPessoa;
            }

        }

        private void DesabilitaEHabilitaCampos()
        {
            if (RBtmColetivo.Checked == true)
            {
                txtIdPessoa.Enabled = false;
                lblCodigo.Enabled = false;
                lblNome.Enabled = false;
                cbBoxPessoaNome.Enabled = false;
            }
        }

        private void HabilitaCampos()
        {
            if (RBtmIndivdial.Checked == true)
            {
                txtIdPessoa.Enabled = true;
                lblCodigo.Enabled = true;
                lblNome.Enabled = true;
                cbBoxPessoaNome.Enabled = true;
            }
        }

        private void RBtmIndivdial_Click(object sender, EventArgs e)
        {
            HabilitaCampos();

        }

        private void RBtmColetivo_Click(object sender, EventArgs e)
        {
            DesabilitaEHabilitaCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBoxPessoaNome_DropDown(object sender, EventArgs e)
        {
            if (cbBoxPessoaNome.SelectedText != null)
            {
                limpaComboNomeEhIdPessoa();
            }
            preencheComboNome();

        }

        private void txtIdPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtGridViewControle.RowCount > 0)
            {
                if (dtGridViewControle.SelectedRows.Count == 0)
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
                    ReceitaDto receitaDto = (dtGridViewControle.SelectedRows[0].DataBoundItem as ReceitaDto);
                    ReceitaNegocio receitaNegocio = new ReceitaNegocio();

                    string retorno = receitaNegocio.Excluir(receitaDto);

                    try
                    {
                        MessageBox.Show("Ação realizada com Sucesso! ",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        AtualizeGrid();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Não foi possivel excluir o item, Detalhes:" + retorno, "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Não há registros para remoção.");
                return;
            }
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
    }

}
