using System;
using System.Windows.Forms;
using ObjetoDeTransferenciaDto;
using Negocios;
using Utilitarios;

namespace Apresentação
{
    public partial class FrmCadTipo : Form
    {
        public FrmCadTipo()
        {
            InitializeComponent();
        }

        private void btnSalvarTipo_Click(object sender, EventArgs e)
        {
            ValidaDados validaDados = new ValidaDados();

            var PossueInconsistencia = validaDados.ExisteTextBoxVazio(txbTipo,
                                                                      "Preencha o campo Tipo!");

            if (!PossueInconsistencia)
            {

                TipoDTO tipoDTO = new TipoDTO();

                tipoDTO.Tipo = txbTipo.Text;


                TipoNegocio tipoNegocio = new TipoNegocio();
                string retorno = tipoNegocio.inserirTipo(tipoDTO);

                try
                {
                    int Tipo = Convert.ToInt32(retorno);

                    MessageBox.Show("Ação realizada com Sucesso! " + Tipo.ToString());

                    this.DialogResult = DialogResult.Yes;
                    txbTipo.Clear();

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
