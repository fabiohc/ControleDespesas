namespace Apresentação
{
    partial class FrmAcpDispesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridViewControle = new System.Windows.Forms.DataGridView();
            this.IdReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBoxPessoaNome = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpBxIndividualColetiva = new System.Windows.Forms.GroupBox();
            this.RBtmColetivo = new System.Windows.Forms.RadioButton();
            this.RBtmIndivdial = new System.Windows.Forms.RadioButton();
            this.dtTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dtTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.grpBxPeríodo = new System.Windows.Forms.GroupBox();
            this.grpBxPessoa = new System.Windows.Forms.GroupBox();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.grpBxFiltroOrigemDescricao = new System.Windows.Forms.GroupBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewControle)).BeginInit();
            this.grpBxIndividualColetiva.SuspendLayout();
            this.grpBxPeríodo.SuspendLayout();
            this.grpBxPessoa.SuspendLayout();
            this.grpBxFiltroOrigemDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewControle
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGridViewControle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReceita,
            this.IdPessoa,
            this.Nome,
            this.Origem,
            this.Valor,
            this.Tipo,
            this.Data});
            this.dtGridViewControle.Location = new System.Drawing.Point(12, 158);
            this.dtGridViewControle.MultiSelect = false;
            this.dtGridViewControle.Name = "dtGridViewControle";
            this.dtGridViewControle.Size = new System.Drawing.Size(743, 280);
            this.dtGridViewControle.TabIndex = 0;
            // 
            // IdReceita
            // 
            this.IdReceita.DataPropertyName = "IdReceita";
            this.IdReceita.HeaderText = "IdReceita";
            this.IdReceita.Name = "IdReceita";
            this.IdReceita.ReadOnly = true;
            // 
            // IdPessoa
            // 
            this.IdPessoa.DataPropertyName = "IdPessoa";
            this.IdPessoa.HeaderText = "IdPessoa";
            this.IdPessoa.Name = "IdPessoa";
            this.IdPessoa.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Origem
            // 
            this.Origem.DataPropertyName = "Origem";
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "#,##";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código";
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
            // grpBxIndividualColetiva
            // 
            this.grpBxIndividualColetiva.Controls.Add(this.RBtmColetivo);
            this.grpBxIndividualColetiva.Controls.Add(this.RBtmIndivdial);
            this.grpBxIndividualColetiva.Location = new System.Drawing.Point(12, 35);
            this.grpBxIndividualColetiva.Name = "grpBxIndividualColetiva";
            this.grpBxIndividualColetiva.Size = new System.Drawing.Size(99, 106);
            this.grpBxIndividualColetiva.TabIndex = 6;
            this.grpBxIndividualColetiva.TabStop = false;
            this.grpBxIndividualColetiva.Text = "Buscar";
            // 
            // RBtmColetivo
            // 
            this.RBtmColetivo.AutoSize = true;
            this.RBtmColetivo.Location = new System.Drawing.Point(6, 68);
            this.RBtmColetivo.Name = "RBtmColetivo";
            this.RBtmColetivo.Size = new System.Drawing.Size(63, 17);
            this.RBtmColetivo.TabIndex = 3;
            this.RBtmColetivo.TabStop = true;
            this.RBtmColetivo.Text = "Coletivo";
            this.RBtmColetivo.UseVisualStyleBackColor = true;
            this.RBtmColetivo.Click += new System.EventHandler(this.RBtmColetivo_Click);
            // 
            // RBtmIndivdial
            // 
            this.RBtmIndivdial.AutoSize = true;
            this.RBtmIndivdial.Location = new System.Drawing.Point(6, 35);
            this.RBtmIndivdial.Name = "RBtmIndivdial";
            this.RBtmIndivdial.Size = new System.Drawing.Size(70, 17);
            this.RBtmIndivdial.TabIndex = 2;
            this.RBtmIndivdial.TabStop = true;
            this.RBtmIndivdial.Text = "Individual";
            this.RBtmIndivdial.UseVisualStyleBackColor = true;
            this.RBtmIndivdial.Click += new System.EventHandler(this.RBtmIndivdial_Click);
            // 
            // dtTimePickerFim
            // 
            this.dtTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimePickerFim.Location = new System.Drawing.Point(6, 81);
            this.dtTimePickerFim.Name = "dtTimePickerFim";
            this.dtTimePickerFim.Size = new System.Drawing.Size(103, 20);
            this.dtTimePickerFim.TabIndex = 7;
            // 
            // dtTimePickerInicio
            // 
            this.dtTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimePickerInicio.Location = new System.Drawing.Point(6, 36);
            this.dtTimePickerInicio.Name = "dtTimePickerInicio";
            this.dtTimePickerInicio.Size = new System.Drawing.Size(103, 20);
            this.dtTimePickerInicio.TabIndex = 6;
            this.dtTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(3, 20);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Início";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(3, 63);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 10;
            this.lblFim.Text = "Fim";
            // 
            // grpBxPeríodo
            // 
            this.grpBxPeríodo.Controls.Add(this.dtTimePickerInicio);
            this.grpBxPeríodo.Controls.Add(this.lblFim);
            this.grpBxPeríodo.Controls.Add(this.dtTimePickerFim);
            this.grpBxPeríodo.Controls.Add(this.lblInicio);
            this.grpBxPeríodo.Location = new System.Drawing.Point(406, 35);
            this.grpBxPeríodo.Name = "grpBxPeríodo";
            this.grpBxPeríodo.Size = new System.Drawing.Size(122, 107);
            this.grpBxPeríodo.TabIndex = 11;
            this.grpBxPeríodo.TabStop = false;
            this.grpBxPeríodo.Text = "Período";
            // 
            // grpBxPessoa
            // 
            this.grpBxPessoa.Controls.Add(this.txtIdPessoa);
            this.grpBxPessoa.Controls.Add(this.cbBoxPessoaNome);
            this.grpBxPessoa.Controls.Add(this.lblNome);
            this.grpBxPessoa.Controls.Add(this.lblCodigo);
            this.grpBxPessoa.Location = new System.Drawing.Point(117, 35);
            this.grpBxPessoa.Name = "grpBxPessoa";
            this.grpBxPessoa.Size = new System.Drawing.Size(283, 107);
            this.grpBxPessoa.TabIndex = 12;
            this.grpBxPessoa.TabStop = false;
            this.grpBxPessoa.Text = "Selecionar Pessoa";
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(10, 46);
            this.txtIdPessoa.MaxLength = 9;
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(67, 20);
            this.txtIdPessoa.TabIndex = 6;
            this.txtIdPessoa.TextChanged += new System.EventHandler(this.txtIdPessoa_TextChanged);
            this.txtIdPessoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPessoa_KeyPress);
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(6, 40);
            this.cbxOrigem.MaxLength = 100;
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(133, 21);
            this.cbxOrigem.TabIndex = 13;
            this.cbxOrigem.DropDown += new System.EventHandler(this.cbxOrigem_DropDown);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(6, 79);
            this.cbxTipo.MaxLength = 100;
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(133, 21);
            this.cbxTipo.TabIndex = 14;
            this.cbxTipo.DropDown += new System.EventHandler(this.cbxTipo_DropDown);
            // 
            // grpBxFiltroOrigemDescricao
            // 
            this.grpBxFiltroOrigemDescricao.Controls.Add(this.lblOrigem);
            this.grpBxFiltroOrigemDescricao.Controls.Add(this.lblTipo);
            this.grpBxFiltroOrigemDescricao.Controls.Add(this.cbxTipo);
            this.grpBxFiltroOrigemDescricao.Controls.Add(this.cbxOrigem);
            this.grpBxFiltroOrigemDescricao.Location = new System.Drawing.Point(534, 35);
            this.grpBxFiltroOrigemDescricao.Name = "grpBxFiltroOrigemDescricao";
            this.grpBxFiltroOrigemDescricao.Size = new System.Drawing.Size(151, 106);
            this.grpBxFiltroOrigemDescricao.TabIndex = 15;
            this.grpBxFiltroOrigemDescricao.TabStop = false;
            this.grpBxFiltroOrigemDescricao.Text = "Filtar Origem/Descrição";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(3, 23);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 15;
            this.lblOrigem.Text = "Origem";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(691, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(691, 70);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(692, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmAcpDispesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 498);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grpBxFiltroOrigemDescricao);
            this.Controls.Add(this.grpBxPeríodo);
            this.Controls.Add(this.grpBxPessoa);
            this.Controls.Add(this.grpBxIndividualColetiva);
            this.Controls.Add(this.dtGridViewControle);
            this.Name = "FrmAcpDispesa";
            this.Text = "FrmAcpDispesa";
            this.Load += new System.EventHandler(this.FrmAcpDispesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewControle)).EndInit();
            this.grpBxIndividualColetiva.ResumeLayout(false);
            this.grpBxIndividualColetiva.PerformLayout();
            this.grpBxPeríodo.ResumeLayout(false);
            this.grpBxPeríodo.PerformLayout();
            this.grpBxPessoa.ResumeLayout(false);
            this.grpBxPessoa.PerformLayout();
            this.grpBxFiltroOrigemDescricao.ResumeLayout(false);
            this.grpBxFiltroOrigemDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewControle;
        private System.Windows.Forms.ComboBox cbBoxPessoaNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpBxIndividualColetiva;
        private System.Windows.Forms.DateTimePicker dtTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dtTimePickerFim;
        private System.Windows.Forms.RadioButton RBtmColetivo;
        private System.Windows.Forms.RadioButton RBtmIndivdial;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.GroupBox grpBxPeríodo;
        private System.Windows.Forms.GroupBox grpBxPessoa;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox grpBxFiltroOrigemDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}