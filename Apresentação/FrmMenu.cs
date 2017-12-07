using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apresentação
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPessoa_Click(object sender, EventArgs e)
        {
            FrmPessoa frmPessoa = new FrmPessoa();

            frmPessoa.MdiParent = this;

            frmPessoa.Show();


        }

        private void MenuSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MenuBanco_Click(object sender, EventArgs e)
        {

            FrmCadBanco frmcodbanco = new FrmCadBanco();

            frmcodbanco.MdiParent = this;

            frmcodbanco.Show();

        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmEntrada frmEntrada = new FrmEntrada();

            frmEntrada.MdiParent = this;

            frmEntrada.Show();

        
    }

        private void origemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadOrigem frmCadOrigem = new FrmCadOrigem();

            frmCadOrigem.MdiParent = this;

            frmCadOrigem.Show();

        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTipo frmCadTipo = new FrmCadTipo();

            frmCadTipo.MdiParent = this;

            frmCadTipo.Show();


        }

        private void acompanharDispesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAcpDispesa frmAcpDispesa = new FrmAcpDispesa();

            frmAcpDispesa.MdiParent = this;

            frmAcpDispesa.Show();

        }

        private void adicionarDistesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustoDespesa frmCustoDispesa = new FrmCustoDespesa();

            frmCustoDispesa.MdiParent = this;

            frmCustoDispesa.Show();
        }
    }
}
