using System;
using System.Windows.Forms;
using Negocios;
using ObjetoDeTransferenciaDto;
using System.Data;
using Utilitarios.cs;
using System.Runtime.InteropServices;

namespace Apresentação
{
    public partial class FrmCustoDespesa : Form
    {
        public FrmCustoDespesa()
        {
            InitializeComponent();
            formataMasacara();
            habilitaDesabilitaCheckParcelado();
            LimpaLinhaVaziaDoGrid();
        }

        private void LimpaLinhaVaziaDoGrid()
        {
            dtGridCustoDespesa.AutoGenerateColumns = false;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            bool val = validaDados("Adicionar");

            if (val == false)
            {

                var pago = false;

                dtGridCustoDespesa.Rows.Add(txtIdPessoa.Text,
                                            cbBoxPessoaNome.Text,
                                            cboTipo.Text,
                                            txtBoxValor.Text,
                                            mskDtVencimento.Text,
                                            pago,
                                            ckParcelado.Checked,
                                            txbQtdParcela.Text,
                                            txtDescricao.Text);

                //Limpa linha vazia do grid.
                dtGridCustoDespesa.AllowUserToAddRows = false;

                limpaCampos();

            }

        }
        private void formataMasacara()
        {
            string valor;
            valor = txtBoxValor.Text;

            Moeda mascaraMoeda = new Moeda();
            mascaraMoeda.adicionaMascaraMoeda(ref valor);

            txtBoxValor.Text = valor;
            txtBoxValor.SelectionStart = txtBoxValor.TextLength;
        }
        private void limpaCampos()
        {
            cboTipo.Text = "";
            txtBoxValor.Clear();
            ckParcelado.Checked = false;
            txbQtdParcela.Clear();
            txtDescricao.Clear();
            txbQtdParcela.Clear();
            this.DTReceita.Value = DateTime.Now.Date;
        }
        private void buscaPessoaPorId()
        {

            PessoaNegocio pessoaNegocio = new PessoaNegocio();

            ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

            if (!string.IsNullOrEmpty(txtIdPessoa.Text))
            {
                colecaoPessoa = pessoaNegocio.ConsultarPessoaPorId(txtIdPessoa.Text);

                cbBoxPessoaNome.DataSource = null;
                cbBoxPessoaNome.DisplayMember = "Nome";
                cbBoxPessoaNome.DataSource = colecaoPessoa;
            }

        }
        private void txtIdPessoa_TextChanged(object sender, EventArgs e)
        {
            buscaPessoaPorId();
        }
        private void cboTipo_DropDown(object sender, EventArgs e)
        {
            TipoNegocio tipoNegocio = new TipoNegocio();

            ColecaoTipoDTO colecaoTipoDTO = new ColecaoTipoDTO();

            limpaComboTipo();
            colecaoTipoDTO = tipoNegocio.consultarTipo(cboTipo.Text);

            cboTipo.DataSource = null;
            cboTipo.DisplayMember = "Tipo";
            cboTipo.DataSource = colecaoTipoDTO;
        }
        private void cbBoxPessoaNome_DropDown(object sender, EventArgs e)
        {

            if (cbBoxPessoaNome.SelectedText != null)
            {
                limpaComboNomeEhIdPessoa();
            }
            preencheComboNome();

        }
        private void limpaComboNomeEhIdPessoa()
        {
            cbBoxPessoaNome.SelectedIndex = -1;
            txtIdPessoa.DataBindings.Clear();
        }
        private void limpaComboTipo()
        {
            cboTipo.SelectedIndex = -1;
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

        private bool compareObjetoParaAlteracao(object objetoAterado)
        {
            return false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvaOuAlteraRegistro();
        }

        private void SalvaOuAlteraRegistro()
        {
            bool val = validaDados("salvar");

            if (val == false)
            {
                DespesaNegocio despesaNegocio = new DespesaNegocio();

                ColecaoDespesaDto colecaoDespesaDto = new ColecaoDespesaDto();

                for (int i = 0; i < dtGridCustoDespesa.Rows.Count; i++)
                {
                    DespesaDto despesaDto = new DespesaDto();
                    DateTime agora = DateTime.Now;

                    despesaDto.IdPessoa = Convert.ToInt32(dtGridCustoDespesa.Rows[i].Cells[0].Value);
                    despesaDto.Nome = dtGridCustoDespesa.Rows[i].Cells[1].Value.ToString();
                    despesaDto.Tipo = dtGridCustoDespesa.Rows[i].Cells[2].Value.ToString();
                    despesaDto.Valor = Convert.ToDecimal(dtGridCustoDespesa.Rows[i].Cells[3].Value);
                    despesaDto.Vencimento = Convert.ToDateTime(dtGridCustoDespesa.Rows[i].Cells[4].Value);
                    despesaDto.Pago = Convert.ToByte(dtGridCustoDespesa.Rows[i].Cells[5].Value);
                    despesaDto.Parcelado = Convert.ToByte(dtGridCustoDespesa.Rows[i].Cells[6].Value);

                    if (dtGridCustoDespesa.Rows[i].Cells[7].Value == "")
                        despesaDto.QuantParcela = Convert.ToByte(dtGridCustoDespesa.Rows[i].Cells[7].Value = 0);
                    else
                        despesaDto.QuantParcela = Convert.ToByte(dtGridCustoDespesa.Rows[i].Cells[7].Value);

                    despesaDto.Descricao = dtGridCustoDespesa.Rows[i].Cells[8].Value.ToString();
                    despesaDto.IdDespesa = Convert.ToInt32(dtGridCustoDespesa.Rows[i].Cells[9].Value);
                    despesaDto.DataHoraCadastro = Convert.ToDateTime((string.Format("{0:dd/MM/yyyy HH:mm:ss}", agora)));

                    colecaoDespesaDto.Add(despesaDto);
                }

                if (btnSalvar.Text == "Salvar")
                    despesaNegocio.Inserir(colecaoDespesaDto);
                else
                    despesaNegocio.Alterar(colecaoDespesaDto);

                try
                {
                    DialogResult resultado = MessageBox.Show("Ação realizada com Sucesso! ", "Imformação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);


                    this.dtGridCustoDespesa.DataSource = null;
                    dtGridCustoDespesa.Update();
                    this.dtGridCustoDespesa.Refresh();
                    HabilitaBotao();


                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel inserir o registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
        private void txtBoxValor_TextChanged(object sender, EventArgs e)
        {
            formataMasacara();
        }
        private bool validaDados(string acao)
        {

            bool validacaoItem = false;
            switch (acao)
            {
                case "Adicionar":
                    {
                        if (string.IsNullOrEmpty(txtIdPessoa.Text) || string.IsNullOrEmpty(cbBoxPessoaNome.Text))
                        {
                            MessageBox.Show("Selecione uma pessoa!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            txtIdPessoa.Focus();
                            return validacaoItem = true;
                        }

                        if (string.IsNullOrEmpty(cboTipo.Text))
                        {
                            MessageBox.Show("Selecione um Tipo!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cboTipo.Focus();
                            return validacaoItem = true;
                        }

                        if (string.IsNullOrEmpty(mskDtVencimento.Text))
                        {
                            MessageBox.Show("Selecione uma data de vencimento!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cboTipo.Focus();
                            return validacaoItem = true;
                        }

                        if (txtBoxValor.Text.Equals("0,00"))
                        {
                            if (MessageBox.Show("O valor é 0,00.\n Tem certeza que deseja adionar esse valor?", "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1) == DialogResult.No)
                            {
                                txtBoxValor.Focus();
                                return validacaoItem = true;
                            }
                            return validacaoItem = false;
                        }
                        break;
                    }

                case "alterar":
                    {
                        if (string.IsNullOrEmpty(txtIdPessoa.Text) || string.IsNullOrEmpty(cbBoxPessoaNome.Text))
                        {
                            MessageBox.Show("Selecione uma pessoa!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            txtIdPessoa.Focus();
                            return validacaoItem = true;
                        }

                        if (string.IsNullOrEmpty(cboTipo.Text))
                        {
                            MessageBox.Show("Selecione um Tipo!", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cboTipo.Focus();
                            return validacaoItem = true;
                        }

                        if (txtBoxValor.Text.Equals("0,00"))
                        {
                            if (MessageBox.Show("O valor é 0,00.\n Tem certeza que deseja adionar esse valor?", "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1) == DialogResult.No)
                            {
                                txtBoxValor.Focus();
                                return validacaoItem = true;
                            }
                            return validacaoItem = false;
                        }

                        if ((ckParcelado.Checked) && (string.IsNullOrEmpty(txbQtdParcela.Text)))
                        {
                            MessageBox.Show("Adicione a quantidade de parcelas.", "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            txbQtdParcela.Focus();
                            return validacaoItem = true;
                        }
                        break;
                    }

                case "salvar":
                    {
                        if (dtGridCustoDespesa.RowCount == 0)
                        {

                            MessageBox.Show("Adicione itens na Grid para salvar", "Atenção",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation,
                           MessageBoxDefaultButton.Button1);
                            txtIdPessoa.Focus();

                            return validacaoItem = true;
                        }
                        break;
                    }

                case "pesquisar":
                    {
                        if (string.IsNullOrEmpty(txtIdPessoa.Text) &&
                            string.IsNullOrEmpty(cboTipo.Text) &&
                            string.IsNullOrEmpty(mskDtVencimento.Text = Utilitarios.Mascara.TextNoFormatting(mskDtVencimento)) &&
                            (ckParcelado.Checked = false))
                        {

                            MessageBox.Show("Selecione uma pessoa ou dados de despesas \n para pesquisar.", "Atenção",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation,
                           MessageBoxDefaultButton.Button1);
                            txtIdPessoa.Focus();

                            return validacaoItem = true;
                        }

                        break;
                    }
            }
            return validacaoItem;
        }
        private void habilitaDesabilitaCheckParcelado()
        {
            if (ckParcelado.Checked == true)
            {
                txbQtdParcela.Enabled = true;
            }
            else txbQtdParcela.Enabled = false;
        }
        private void ckParcelado_CheckedChanged(object sender, EventArgs e)
        {
            habilitaDesabilitaCheckParcelado();
        }
        private void txbQtdParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool val = validaDados("pesquisar");

            if (val == false)
            {
                AtualizeGrid();
            }
        }

        private void AtualizeGrid()
        {

            DespesaNegocio despesaNegocio = new DespesaNegocio();

            ColecaoDespesaDto colecaoDespesaDto = new ColecaoDespesaDto();


            if (!string.IsNullOrEmpty(mskDtVencimento.Text = Utilitarios.Mascara.TextNoFormatting(mskDtVencimento)))
            {
                colecaoDespesaDto = despesaNegocio.ConsultarDespesa(txtIdPessoa.Text,
                                                                cboTipo.Text,
                                                                Convert.ToDateTime(mskDtVencimento.Text).Date,
                                                                Convert.ToByte(verificaCheckPago(ckParcelado.Checked)));

            }
            else
            {
                colecaoDespesaDto = despesaNegocio.ConsultarDespesaV2(txtIdPessoa.Text,
                                                                      cboTipo.Text,
                                                                      Convert.ToByte(verificaCheckPago(ckParcelado.Checked)));
            }

            try
            {

                if (colecaoDespesaDto.Count == 0)
                {

                    MessageBox.Show("Não foram encontrados registros com os parâmetros inseridos.", "Atenção",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.No;

                    return;

                }

                dtGridCustoDespesa.DataSource = null;
                dtGridCustoDespesa.DataSource = colecaoDespesaDto;

                desabilitaBotao();

                btnSalvar.Text = "Alterar";

                dtGridCustoDespesa.Update();
                dtGridCustoDespesa.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel inserir o registro", "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void desabilitaBotao()
        {
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
        }
        private void HabilitaBotao()
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnRemover.Enabled = true;
            btnSalvar.Text = "Salvar";
        }


        private int verificaCheckPago(bool ckTruFalse)
        {
            int pago;

            if (ckTruFalse)
                return pago = 1;
            else
                return pago = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DespesaDto despesaDto = new DespesaDto();

            if (dtGridCustoDespesa.SelectedRows.Count == 0)
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

                txtIdPessoa.Text = dtGridCustoDespesa.SelectedRows[0].Cells[0].Value.ToString();
                cbBoxPessoaNome.Text = dtGridCustoDespesa.SelectedRows[0].Cells[1].Value.ToString();
                cboTipo.Text = dtGridCustoDespesa.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxValor.Text = dtGridCustoDespesa.SelectedRows[0].Cells[3].Value.ToString();
                mskDtVencimento.Text = dtGridCustoDespesa.SelectedRows[0].Cells[4].Value.ToString();
                ckParcelado.Checked = Convert.ToBoolean(dtGridCustoDespesa.SelectedRows[0].Cells[6].Value);
                txbQtdParcela.Text = dtGridCustoDespesa.SelectedRows[0].Cells[7].Value.ToString();
                txtDescricao.Text = dtGridCustoDespesa.SelectedRows[0].Cells[8].Value.ToString();


                //Remove a linha após subir para edição
                dtGridCustoDespesa.Rows.Remove(dtGridCustoDespesa.SelectedRows[0]);

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dtGridCustoDespesa.RowCount > 1)
            {
                if (dtGridCustoDespesa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma linha para remoção.");
                    return;
                }

                DialogResult resultado = MessageBox.Show("Confirmar remoção da linha selecionada?", "Pergunta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                cboTipo.Focus();

                if (resultado == DialogResult.No)
                {
                    return;
                }
                else
                {
                    dtGridCustoDespesa.Rows.Remove(dtGridCustoDespesa.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Não há registros para remoção.");
                return;
            }
        }

        private void limpaCampos([Optional] string acaoEditar)
        {
            if (acaoEditar == "Editar")
            {
                txtIdPessoa.Text = "";
                cbBoxPessoaNome.Text = "";
            }
            cboTipo.Text = "";
            txtBoxValor.Clear();
            this.DTReceita.Value = DateTime.Now.Date;
        }

        private void DTReceita_ValueChanged(object sender, EventArgs e)
        {
            mskDtVencimento.Text = DTReceita.Text;
        }

        private void dtGridCustoDespesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




