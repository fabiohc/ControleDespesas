using Negocios;
using ObjetodetransferenciaDto;
using System;
using System.Windows.Forms;
using Utilitarios;
using Enumeradores.EnumMensagem;

namespace Apresentação
{
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

       private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            ValidaDados validaDados = new ValidaDados();

            var PossueInconsistencia = validaDados.ExisteTextBoxVazio(txtNome,
                                                                    "Preencha o campo Nome!");

            if (!PossueInconsistencia)
            {
                PessoaDTO pessoaDto = new PessoaDTO();

                pessoaDto.Nome = txtNome.Text;

                PessoaNegocio pessoaNegocio = new PessoaNegocio();
                string retorno = pessoaNegocio.inserir(pessoaDto);

                try
                {
                    int Idcliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Ação realizada com Sucesso! " + Idcliente.ToString());

                    this.DialogResult = DialogResult.Yes;
                    txtNome.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possivel inserir o registro" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    txtNome.Clear();
                }
            }
        }
    }
}
