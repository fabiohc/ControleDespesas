namespace Apresentação
{
    partial class FrmCustoDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustoDespesa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBxPessoa = new System.Windows.Forms.GroupBox();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.cbBoxPessoaNome = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskDtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNumParcela = new System.Windows.Forms.Label();
            this.ckParcelado = new System.Windows.Forms.CheckBox();
            this.txbQtdParcela = new System.Windows.Forms.TextBox();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.DTReceita = new System.Windows.Forms.DateTimePicker();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtGridCustoDespesa = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClnIdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClnParcela = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClnQtdParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxPessoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustoDespesa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxPessoa
            // 
            this.grpBxPessoa.Controls.Add(this.txtIdPessoa);
            this.grpBxPessoa.Controls.Add(this.cbBoxPessoaNome);
            this.grpBxPessoa.Controls.Add(this.lblNome);
            this.grpBxPessoa.Controls.Add(this.lblCodigo);
            this.grpBxPessoa.Location = new System.Drawing.Point(29, 24);
            this.grpBxPessoa.Name = "grpBxPessoa";
            this.grpBxPessoa.Size = new System.Drawing.Size(283, 120);
            this.grpBxPessoa.TabIndex = 13;
            this.grpBxPessoa.TabStop = false;
            this.grpBxPessoa.Text = "Selecionar Pessoa";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(10, 46);
            this.txtIdPessoa.MaxLength = 9;
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(67, 20);
            this.txtIdPessoa.TabIndex = 1;
            this.txtIdPessoa.TextChanged += new System.EventHandler(this.txtIdPessoa_TextChanged);
            // 
            // cbBoxPessoaNome
            // 
            this.cbBoxPessoaNome.FormattingEnabled = true;
            this.cbBoxPessoaNome.Location = new System.Drawing.Point(83, 45);
            this.cbBoxPessoaNome.MaxLength = 100;
            this.cbBoxPessoaNome.Name = "cbBoxPessoaNome";
            this.cbBoxPessoaNome.Size = new System.Drawing.Size(190, 21);
            this.cbBoxPessoaNome.TabIndex = 2;
            this.cbBoxPessoaNome.DropDown += new System.EventHandler(this.cbBoxPessoaNome_DropDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskDtVencimento);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.lblNumParcela);
            this.groupBox1.Controls.Add(this.ckParcelado);
            this.groupBox1.Controls.Add(this.txbQtdParcela);
            this.groupBox1.Controls.Add(this.txtBoxValor);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.DTReceita);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(318, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Despesa";
            // 
            // mskDtVencimento
            // 
            this.mskDtVencimento.Location = new System.Drawing.Point(261, 42);
            this.mskDtVencimento.Mask = "00/00/0000";
            this.mskDtVencimento.Name = "mskDtVencimento";
            this.mskDtVencimento.Size = new System.Drawing.Size(66, 20);
            this.mskDtVencimento.TabIndex = 30;
            this.mskDtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(712, 74);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 33);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(712, 28);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(78, 33);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNumParcela
            // 
            this.lblNumParcela.AutoSize = true;
            this.lblNumParcela.Location = new System.Drawing.Point(461, 26);
            this.lblNumParcela.Name = "lblNumParcela";
            this.lblNumParcela.Size = new System.Drawing.Size(86, 13);
            this.lblNumParcela.TabIndex = 9;
            this.lblNumParcela.Text = "Qtd. de Parcelas";
            // 
            // ckParcelado
            // 
            this.ckParcelado.AutoSize = true;
            this.ckParcelado.Location = new System.Drawing.Point(378, 44);
            this.ckParcelado.Name = "ckParcelado";
            this.ckParcelado.Size = new System.Drawing.Size(74, 17);
            this.ckParcelado.TabIndex = 29;
            this.ckParcelado.Text = "Parcelado";
            this.ckParcelado.UseVisualStyleBackColor = true;
            this.ckParcelado.CheckedChanged += new System.EventHandler(this.ckParcelado_CheckedChanged);
            // 
            // txbQtdParcela
            // 
            this.txbQtdParcela.Location = new System.Drawing.Point(464, 44);
            this.txbQtdParcela.MaxLength = 3;
            this.txbQtdParcela.Name = "txbQtdParcela";
            this.txbQtdParcela.Size = new System.Drawing.Size(80, 20);
            this.txbQtdParcela.TabIndex = 6;
            this.txbQtdParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbQtdParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQtdParcela_KeyPress);
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(160, 41);
            this.txtBoxValor.MaxLength = 11;
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(95, 20);
            this.txtBoxValor.TabIndex = 4;
            this.txtBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxValor.TextChanged += new System.EventHandler(this.txtBoxValor_TextChanged);
            this.txtBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(157, 25);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Valor";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(10, 40);
            this.cboTipo.MaxLength = 100;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(144, 21);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.DropDown += new System.EventHandler(this.cboTipo_DropDown);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(258, 24);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 13);
            this.lblData.TabIndex = 22;
            this.lblData.Text = "Vencimento";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Tipo";
            // 
            // DTReceita
            // 
            this.DTReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTReceita.Location = new System.Drawing.Point(261, 42);
            this.DTReceita.Name = "DTReceita";
            this.DTReceita.Size = new System.Drawing.Size(95, 20);
            this.DTReceita.TabIndex = 5;
            this.DTReceita.ValueChanged += new System.EventHandler(this.DTReceita_ValueChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(7, 65);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 25;
            this.lblDescricao.Text = "Descriçao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 81);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(534, 25);
            this.txtDescricao.TabIndex = 7;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(1001, 85);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(78, 33);
            this.btnRemover.TabIndex = 31;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1001, 46);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 33);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtGridCustoDespesa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGridCustoDespesa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridCustoDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCustoDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdPessoa,
            this.ClnNome,
            this.ClnTipo,
            this.ClnValor,
            this.ClnVencimento,
            this.Pago,
            this.ClnParcela,
            this.ClnQtdParcela,
            this.ClnDescrição,
            this.IdDespesa});
            this.dtGridCustoDespesa.Location = new System.Drawing.Point(10, 23);
            this.dtGridCustoDespesa.MultiSelect = false;
            this.dtGridCustoDespesa.Name = "dtGridCustoDespesa";
            this.dtGridCustoDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCustoDespesa.Size = new System.Drawing.Size(985, 331);
            this.dtGridCustoDespesa.TabIndex = 16;
            this.dtGridCustoDespesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCustoDespesa_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(1123, 29);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 35);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridCustoDespesa);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Location = new System.Drawing.Point(29, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1088, 373);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ClnIdPessoa
            // 
            this.ClnIdPessoa.DataPropertyName = "IdPessoa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnIdPessoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClnIdPessoa.HeaderText = "IdPessoa";
            this.ClnIdPessoa.Name = "ClnIdPessoa";
            this.ClnIdPessoa.Width = 60;
            // 
            // ClnNome
            // 
            this.ClnNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClnNome.HeaderText = "Nome";
            this.ClnNome.Name = "ClnNome";
            this.ClnNome.Width = 200;
            // 
            // ClnTipo
            // 
            this.ClnTipo.DataPropertyName = "Tipo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnTipo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClnTipo.HeaderText = "Tipo";
            this.ClnTipo.Name = "ClnTipo";
            this.ClnTipo.Width = 60;
            // 
            // ClnValor
            // 
            this.ClnValor.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClnValor.HeaderText = "Valor";
            this.ClnValor.Name = "ClnValor";
            this.ClnValor.Width = 60;
            // 
            // ClnVencimento
            // 
            this.ClnVencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.ClnVencimento.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClnVencimento.HeaderText = "Vencimento";
            this.ClnVencimento.Name = "ClnVencimento";
            this.ClnVencimento.Width = 80;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.FalseValue = "0";
            this.Pago.HeaderText = "Pago?";
            this.Pago.Name = "Pago";
            this.Pago.TrueValue = "1";
            // 
            // ClnParcela
            // 
            this.ClnParcela.DataPropertyName = "Parcelado";
            this.ClnParcela.HeaderText = "Parcelado?";
            this.ClnParcela.Name = "ClnParcela";
            this.ClnParcela.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClnParcela.Width = 70;
            // 
            // ClnQtdParcela
            // 
            this.ClnQtdParcela.DataPropertyName = "QuantParcela";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClnQtdParcela.DefaultCellStyle = dataGridViewCellStyle7;
            this.ClnQtdParcela.HeaderText = "Qtd. Parcelas";
            this.ClnQtdParcela.Name = "ClnQtdParcela";
            // 
            // ClnDescrição
            // 
            this.ClnDescrição.DataPropertyName = "Descricao";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClnDescrição.DefaultCellStyle = dataGridViewCellStyle8;
            this.ClnDescrição.HeaderText = "Descrição";
            this.ClnDescrição.Name = "ClnDescrição";
            this.ClnDescrição.Width = 260;
            // 
            // IdDespesa
            // 
            this.IdDespesa.DataPropertyName = "IdDespesa";
            this.IdDespesa.HeaderText = "IdDespesa";
            this.IdDespesa.Name = "IdDespesa";
            this.IdDespesa.Visible = false;
            // 
            // FrmCustoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1210, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxPessoa);
            this.Name = "FrmCustoDespesa";
            this.Text = "Lançamento  de Custo/Despesa";
            this.grpBxPessoa.ResumeLayout(false);
            this.grpBxPessoa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustoDespesa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxPessoa;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.ComboBox cbBoxPessoaNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.DateTimePicker DTReceita;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridView dtGridCustoDespesa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNumParcela;
        private System.Windows.Forms.CheckBox ckParcelado;
        private System.Windows.Forms.TextBox txbQtdParcela;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskDtVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnVencimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClnParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnQtdParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDescrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDespesa;
    }
}