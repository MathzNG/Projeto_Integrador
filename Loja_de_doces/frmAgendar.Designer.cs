namespace Loja_de_doces
{
    partial class frmAgendar
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.ltbDescricao = new System.Windows.Forms.ListBox();
            this.lblTelcel = new System.Windows.Forms.Label();
            this.mkbTelcel = new System.Windows.Forms.MaskedTextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbAgendamento = new System.Windows.Forms.GroupBox();
            this.gpbAgendamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(16, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Pedido";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(271, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(16, 181);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(16, 105);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(66, 16);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(385, 105);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(91, 16);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(81, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(87, 102);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(267, 22);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(329, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 22);
            this.txtNome.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(482, 104);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(120, 22);
            this.txtComplemento.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(62, 178);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 22);
            this.txtValor.TabIndex = 9;
            // 
            // dtpPrazo
            // 
            this.dtpPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazo.Location = new System.Drawing.Point(283, 178);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(98, 22);
            this.dtpPrazo.TabIndex = 10;
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Location = new System.Drawing.Point(224, 178);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(42, 16);
            this.lblPrazo.TabIndex = 11;
            this.lblPrazo.Text = "Prazo";
            // 
            // ltbDescricao
            // 
            this.ltbDescricao.FormattingEnabled = true;
            this.ltbDescricao.Location = new System.Drawing.Point(12, 270);
            this.ltbDescricao.Name = "ltbDescricao";
            this.ltbDescricao.Size = new System.Drawing.Size(797, 173);
            this.ltbDescricao.TabIndex = 12;
            // 
            // lblTelcel
            // 
            this.lblTelcel.AutoSize = true;
            this.lblTelcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelcel.Location = new System.Drawing.Point(431, 179);
            this.lblTelcel.Name = "lblTelcel";
            this.lblTelcel.Size = new System.Drawing.Size(47, 16);
            this.lblTelcel.TabIndex = 13;
            this.lblTelcel.Text = "TelCel";
            // 
            // mkbTelcel
            // 
            this.mkbTelcel.Location = new System.Drawing.Point(497, 178);
            this.mkbTelcel.Mask = "(99) 99999-9999";
            this.mkbTelcel.Name = "mkbTelcel";
            this.mkbTelcel.Size = new System.Drawing.Size(88, 22);
            this.mkbTelcel.TabIndex = 14;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 3;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(74, 449);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 36);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 3;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(213, 449);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 36);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 3;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(538, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 3;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(671, 449);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 36);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbAgendamento
            // 
            this.gpbAgendamento.Controls.Add(this.mkbTelcel);
            this.gpbAgendamento.Controls.Add(this.lblTelcel);
            this.gpbAgendamento.Controls.Add(this.lblPrazo);
            this.gpbAgendamento.Controls.Add(this.dtpPrazo);
            this.gpbAgendamento.Controls.Add(this.txtValor);
            this.gpbAgendamento.Controls.Add(this.txtComplemento);
            this.gpbAgendamento.Controls.Add(this.txtNome);
            this.gpbAgendamento.Controls.Add(this.txtEndereco);
            this.gpbAgendamento.Controls.Add(this.txtId);
            this.gpbAgendamento.Controls.Add(this.lblComplemento);
            this.gpbAgendamento.Controls.Add(this.lblEndereco);
            this.gpbAgendamento.Controls.Add(this.lblValor);
            this.gpbAgendamento.Controls.Add(this.lblNome);
            this.gpbAgendamento.Controls.Add(this.lblId);
            this.gpbAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAgendamento.Location = new System.Drawing.Point(12, 10);
            this.gpbAgendamento.Name = "gpbAgendamento";
            this.gpbAgendamento.Size = new System.Drawing.Size(796, 245);
            this.gpbAgendamento.TabIndex = 19;
            this.gpbAgendamento.TabStop = false;
            this.gpbAgendamento.Text = "Agendamento";
            // 
            // frmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.gpbAgendamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.ltbDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAgendar";
            this.Text = "Agendamento";
            this.gpbAgendamento.ResumeLayout(false);
            this.gpbAgendamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.ListBox ltbDescricao;
        private System.Windows.Forms.Label lblTelcel;
        private System.Windows.Forms.MaskedTextBox mkbTelcel;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbAgendamento;
    }
}