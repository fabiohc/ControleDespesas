namespace Apresentação
{
    partial class FrmCadBanco
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
            this.cbxCodBanco = new System.Windows.Forms.ComboBox();
            this.cbxNomeBanco = new System.Windows.Forms.ComboBox();
            this.lblCodBanco = new System.Windows.Forms.Label();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCodBanco
            // 
            this.cbxCodBanco.FormattingEnabled = true;
            this.cbxCodBanco.Location = new System.Drawing.Point(9, 27);
            this.cbxCodBanco.Name = "cbxCodBanco";
            this.cbxCodBanco.Size = new System.Drawing.Size(60, 21);
            this.cbxCodBanco.TabIndex = 0;
            this.cbxCodBanco.DropDown += new System.EventHandler(this.cbxCodBanco_DropDown);
            // 
            // cbxNomeBanco
            // 
            this.cbxNomeBanco.FormattingEnabled = true;
            this.cbxNomeBanco.Location = new System.Drawing.Point(75, 27);
            this.cbxNomeBanco.Name = "cbxNomeBanco";
            this.cbxNomeBanco.Size = new System.Drawing.Size(199, 21);
            this.cbxNomeBanco.TabIndex = 1;
            this.cbxNomeBanco.DropDown += new System.EventHandler(this.cbxNomeBanco_DropDown);
            this.cbxNomeBanco.DisplayMemberChanged += new System.EventHandler(this.cbxNomeBanco_DropDown);
            // 
            // lblCodBanco
            // 
            this.lblCodBanco.AutoSize = true;
            this.lblCodBanco.Location = new System.Drawing.Point(6, 8);
            this.lblCodBanco.Name = "lblCodBanco";
            this.lblCodBanco.Size = new System.Drawing.Size(40, 13);
            this.lblCodBanco.TabIndex = 2;
            this.lblCodBanco.Text = "Código";
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.Location = new System.Drawing.Point(72, 8);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(38, 13);
            this.lblNomeBanco.TabIndex = 3;
            this.lblNomeBanco.Text = "Banco";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(280, 54);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 22);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(280, 26);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 22);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 85);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.lblCodBanco);
            this.Controls.Add(this.cbxNomeBanco);
            this.Controls.Add(this.cbxCodBanco);
            this.MinimizeBox = false;
            this.Name = "FrmCadBanco";
            this.Text = "Cadastrar Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCodBanco;
        private System.Windows.Forms.ComboBox cbxNomeBanco;
        private System.Windows.Forms.Label lblCodBanco;
        private System.Windows.Forms.Label lblNomeBanco;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}