using ObjetoDeTransferenciaDto;
using System;
using System.Windows.Forms;
using Negocios;
using System.Data;

namespace Apresentação
{
    public partial class FrmCadBanco : Form
    {
        public FrmCadBanco()
        {
            InitializeComponent();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            BancoDTO bancoDto = new BancoDTO();

            bancoDto.BancoNome = cbxNomeBanco.Text;

            BancoNegocio bancoNegociao = new BancoNegocio();

            bancoNegociao.inserir(bancoDto);

            try
            {
               MessageBox.Show("Ação realizada com Sucesso! ");

                this.DialogResult = DialogResult.Yes;
                cbxCodBanco.Text = "";
                cbxNomeBanco.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel inserir o registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
                cbxCodBanco.Text = "";
                cbxNomeBanco.Text = "";

                throw;
            }
        }

        private void cbxNomeBanco_DropDown(object sender, EventArgs e)
        {
            BancoNegocio bancoNegocio = new BancoNegocio();

            ColecaoBancoDto colecaoBancoDto = new ColecaoBancoDto();
            colecaoBancoDto = bancoNegocio.consultarBancoNome(cbxNomeBanco.Text);

            cbxNomeBanco.DataSource = null;
            cbxCodBanco.DataSource = null;
            cbxCodBanco.DisplayMember = "CodBanco";
            cbxNomeBanco.DisplayMember = "BancoNome";
            cbxNomeBanco.DataSource = colecaoBancoDto;
            cbxCodBanco.DataSource = colecaoBancoDto;
        }
        private void cbxCodBanco_DropDown(object sender, EventArgs e)
        {
            BancoNegocio bancoNegocio = new BancoNegocio();

            BancoDTO bancoDto = new BancoDTO();

            ColecaoBancoDto colecaoBancoDto = new ColecaoBancoDto();
            colecaoBancoDto = bancoNegocio.consultarBancoCodigo(cbxCodBanco.Text);

            cbxNomeBanco.DataSource = null;
            cbxCodBanco.DataSource = null;

            cbxCodBanco.DisplayMember = "CodBanco";
            cbxNomeBanco.DisplayMember = "BancoNome";
            cbxNomeBanco.DataSource = colecaoBancoDto;
            cbxCodBanco.DataSource = colecaoBancoDto;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
