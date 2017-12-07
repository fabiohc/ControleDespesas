namespace Apresentação
{
    partial class FrmCadTipo
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
            this.btnSalvarTipo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.grpBoxTipo = new System.Windows.Forms.GroupBox();
            this.grpBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarTipo
            // 
            this.btnSalvarTipo.Location = new System.Drawing.Point(221, 45);
            this.btnSalvarTipo.Name = "btnSalvarTipo";
            this.btnSalvarTipo.Size = new System.Drawing.Size(75, 24);
            this.btnSalvarTipo.TabIndex = 0;
            this.btnSalvarTipo.Text = "Salvar";
            this.btnSalvarTipo.UseVisualStyleBackColor = true;
            this.btnSalvarTipo.Click += new System.EventHandler(this.btnSalvarTipo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(221, 74);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 29);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(9, 45);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(206, 20);
            this.txbTipo.TabIndex = 3;
            // 
            // grpBoxTipo
            // 
            this.grpBoxTipo.Controls.Add(this.txbTipo);
            this.grpBoxTipo.Controls.Add(this.btnFechar);
            this.grpBoxTipo.Controls.Add(this.lblTipo);
            this.grpBoxTipo.Controls.Add(this.btnSalvarTipo);
            this.grpBoxTipo.Location = new System.Drawing.Point(9, 9);
            this.grpBoxTipo.Name = "grpBoxTipo";
            this.grpBoxTipo.Size = new System.Drawing.Size(305, 109);
            this.grpBoxTipo.TabIndex = 4;
            this.grpBoxTipo.TabStop = false;
            this.grpBoxTipo.Text = "Cadastro de Tipo";
            // 
            // FrmCadTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 143);
            this.Controls.Add(this.grpBoxTipo);
            this.Name = "FrmCadTipo";
            this.Text = "Cadastrar Tipo";
            this.grpBoxTipo.ResumeLayout(false);
            this.grpBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarTipo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.GroupBox grpBoxTipo;
    }
}