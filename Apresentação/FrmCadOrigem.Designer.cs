namespace Apresentação
{
    partial class FrmCadOrigem
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
            this.grpBoxOrigem = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.grpBoxOrigem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxOrigem
            // 
            this.grpBoxOrigem.Controls.Add(this.btnFechar);
            this.grpBoxOrigem.Controls.Add(this.btnSalvar);
            this.grpBoxOrigem.Controls.Add(this.lblOrigem);
            this.grpBoxOrigem.Controls.Add(this.txtOrigem);
            this.grpBoxOrigem.Location = new System.Drawing.Point(16, 23);
            this.grpBoxOrigem.Name = "grpBoxOrigem";
            this.grpBoxOrigem.Size = new System.Drawing.Size(291, 110);
            this.grpBoxOrigem.TabIndex = 0;
            this.grpBoxOrigem.TabStop = false;
            this.grpBoxOrigem.Text = "Origem de Crédito";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(194, 75);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(76, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(194, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(16, 27);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 1;
            this.lblOrigem.Text = "Origem";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(15, 46);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(173, 20);
            this.txtOrigem.TabIndex = 0;
            // 
            // FrmCadOrigem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 148);
            this.Controls.Add(this.grpBoxOrigem);
            this.Name = "FrmCadOrigem";
            this.Text = "Cadastrar Origem";
            this.grpBoxOrigem.ResumeLayout(false);
            this.grpBoxOrigem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxOrigem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.TextBox txtOrigem;
    }
}