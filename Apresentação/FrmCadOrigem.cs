using System;
using System.Windows.Forms;
using Utilitarios;
using ObjetoDeTransferenciaDto;
using Negocios;

namespace Apresentação
{
    public partial class FrmCadOrigem : Form
    {
        public FrmCadOrigem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {

            ValidaDados validaDados = new ValidaDados();

            var PossueInconsistencia = validaDados.ExisteTextBoxVazio(txtOrigem,
                                                                     "Preencha o campo Origem!");

            if (!PossueInconsistencia)
            {
                OrigemDTO origemDto = new OrigemDTO();

                origemDto.Origem = txtOrigem.Text;

                OrigemNegocio origemNegocio = new OrigemNegocio();
                string retorno = origemNegocio.inserir(origemDto);

                try
                {
                    int IOrigem = Convert.ToInt32(retorno);

                    MessageBox.Show("Ação realizada com Sucesso! " + IOrigem.ToString());

                    this.DialogResult = DialogResult.Yes;
                    this.txtOrigem.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel inserir o registro" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
