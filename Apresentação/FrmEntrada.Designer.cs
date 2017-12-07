namespace Apresentação
{
    partial class FrmEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.DTReceita = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpboxEntrada = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpBoxCadValor = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodPessoaEntrada = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cbxPessoa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtGridDadosCredito = new System.Windows.Forms.DataGridView();
            this.IdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpboxEntrada.SuspendLayout();
            this.grpBoxCadValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDadosCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(14, 75);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Origem";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(233, 75);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(233, 115);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(14, 115);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(17, 91);
            this.cbxOrigem.MaxLength = 100;
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(198, 21);
            this.cbxOrigem.TabIndex = 5;
            this.cbxOrigem.DropDown += new System.EventHandler(this.cbxOrigem_DropDown);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(17, 131);
            this.cbxTipo.MaxLength = 100;
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(196, 21);
            this.cbxTipo.TabIndex = 6;
            this.cbxTipo.DropDown += new System.EventHandler(this.cbxTipo_DropDown);
            // 
            // DTReceita
            // 
            this.DTReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTReceita.Location = new System.Drawing.Point(236, 132);
            this.DTReceita.Name = "DTReceita";
            this.DTReceita.Size = new System.Drawing.Size(95, 20);
            this.DTReceita.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(675, 34);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpboxEntrada
            // 
            this.grpboxEntrada.Controls.Add(this.btnExcluir);
            this.grpboxEntrada.Controls.Add(this.grpBoxCadValor);
            this.grpboxEntrada.Controls.Add(this.btnPesquisar);
            this.grpboxEntrada.Controls.Add(this.dtGridDadosCredito);
            this.grpboxEntrada.Controls.Add(this.btnSalvar);
            this.grpboxEntrada.Location = new System.Drawing.Point(10, 9);
            this.grpboxEntrada.Name = "grpboxEntrada";
            this.grpboxEntrada.Size = new System.Drawing.Size(761, 464);
            this.grpboxEntrada.TabIndex = 10;
            this.grpboxEntrada.TabStop = false;
            this.grpboxEntrada.Text = "Entrada";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(675, 92);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // grpBoxCadValor
            // 
            this.grpBoxCadValor.Controls.Add(this.btnRemover);
            this.grpBoxCadValor.Controls.Add(this.btnEditar);
            this.grpBoxCadValor.Controls.Add(this.lblNome);
            this.grpBoxCadValor.Controls.Add(this.txtCodPessoaEntrada);
            this.grpBoxCadValor.Controls.Add(this.textBoxValor);
            this.grpBoxCadValor.Controls.Add(this.btnAdicionar);
            this.grpBoxCadValor.Controls.Add(this.lblCodigo);
            this.grpBoxCadValor.Controls.Add(this.cbxPessoa);
            this.grpBoxCadValor.Controls.Add(this.DTReceita);
            this.grpBoxCadValor.Controls.Add(this.cbxTipo);
            this.grpBoxCadValor.Controls.Add(this.cbxOrigem);
            this.grpBoxCadValor.Controls.Add(this.lblTipo);
            this.grpBoxCadValor.Controls.Add(this.lblData);
            this.grpBoxCadValor.Controls.Add(this.lblValor);
            this.grpBoxCadValor.Controls.Add(this.lblOrigem);
            this.grpBoxCadValor.Location = new System.Drawing.Point(18, 19);
            this.grpBoxCadValor.Name = "grpBoxCadValor";
            this.grpBoxCadValor.Size = new System.Drawing.Size(651, 170);
            this.grpBoxCadValor.TabIndex = 15;
            this.grpBoxCadValor.TabStop = false;
            this.grpBoxCadValor.Text = "Cadastro de Valor";
            // 
            // btnRemover
            // 
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(526, 132);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(445, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(82, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // txtCodPessoaEntrada
            // 
            this.txtCodPessoaEntrada.Location = new System.Drawing.Point(17, 42);
            this.txtCodPessoaEntrada.MaxLength = 9;
            this.txtCodPessoaEntrada.Name = "txtCodPessoaEntrada";
            this.txtCodPessoaEntrada.Size = new System.Drawing.Size(59, 20);
            this.txtCodPessoaEntrada.TabIndex = 21;
            this.txtCodPessoaEntrada.TextChanged += new System.EventHandler(this.txtCodPessoaEntrada_TextChanged);
            this.txtCodPessoaEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPessoaEntrada_KeyPress);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(236, 92);
            this.textBoxValor.MaxLength = 12;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(95, 20);
            this.textBoxValor.TabIndex = 20;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(364, 132);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // cbxPessoa
            // 
            this.cbxPessoa.FormattingEnabled = true;
            this.cbxPessoa.Location = new System.Drawing.Point(82, 41);
            this.cbxPessoa.MaxLength = 100;
            this.cbxPessoa.Name = "cbxPessoa";
            this.cbxPessoa.Size = new System.Drawing.Size(249, 21);
            this.cbxPessoa.TabIndex = 9;
            this.cbxPessoa.DropDown += new System.EventHandler(this.cbxPessoa_DropDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(675, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dtGridDadosCredito
            // 
            this.dtGridDadosCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDadosCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPessoa,
            this.ClnPessoa,
            this.ClnOrigem,
            this.ClnValor,
            this.ClnTipo,
            this.ClnData});
            this.dtGridDadosCredito.Location = new System.Drawing.Point(21, 195);
            this.dtGridDadosCredito.Name = "dtGridDadosCredito";
            this.dtGridDadosCredito.ReadOnly = true;
            this.dtGridDadosCredito.Size = new System.Drawing.Size(648, 248);
            this.dtGridDadosCredito.TabIndex = 11;
            // 
            // IdPessoa
            // 
            this.IdPessoa.HeaderText = "IdPessoa";
            this.IdPessoa.Name = "IdPessoa";
            this.IdPessoa.ReadOnly = true;
            // 
            // ClnPessoa
            // 
            this.ClnPessoa.HeaderText = "Pessoa";
            this.ClnPessoa.Name = "ClnPessoa";
            this.ClnPessoa.ReadOnly = true;
            // 
            // ClnOrigem
            // 
            this.ClnOrigem.HeaderText = "Origem";
            this.ClnOrigem.Name = "ClnOrigem";
            this.ClnOrigem.ReadOnly = true;
            // 
            // ClnValor
            // 
            this.ClnValor.HeaderText = "Valor";
            this.ClnValor.Name = "ClnValor";
            this.ClnValor.ReadOnly = true;
            // 
            // ClnTipo
            // 
            this.ClnTipo.HeaderText = "Tipo";
            this.ClnTipo.Name = "ClnTipo";
            this.ClnTipo.ReadOnly = true;
            // 
            // ClnData
            // 
            this.ClnData.HeaderText = "Data de Entrada";
            this.ClnData.Name = "ClnData";
            this.ClnData.ReadOnly = true;
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 485);
            this.Controls.Add(this.grpboxEntrada);
            this.Name = "FrmEntrada";
            this.Text = "FrmEntrada";
            this.grpboxEntrada.ResumeLayout(false);
            this.grpBoxCadValor.ResumeLayout(false);
            this.grpBoxCadValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDadosCredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.DateTimePicker DTReceita;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpboxEntrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbxPessoa;
        private System.Windows.Forms.DataGridView dtGridDadosCredito;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpBoxCadValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnData;
        private System.Windows.Forms.TextBox txtCodPessoaEntrada;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
    }
}