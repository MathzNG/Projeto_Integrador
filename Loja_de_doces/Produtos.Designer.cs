namespace Loja_de_doces
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.dgvProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduto,
            this.dgvCategoria,
            this.dgvPreço,
            this.dgvEditar,
            this.dgvExcluir});
            this.dgvCadastro.GridColor = System.Drawing.Color.Azure;
            this.dgvCadastro.Location = new System.Drawing.Point(2, 208);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(843, 241);
            this.dgvCadastro.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.Location = new System.Drawing.Point(713, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 42);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.Location = new System.Drawing.Point(571, 12);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(121, 42);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.Location = new System.Drawing.Point(428, 12);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(121, 42);
            this.btnAgendamento.TabIndex = 5;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(1, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(843, 447);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // dgvProduto
            // 
            this.dgvProduto.HeaderText = "                                              Produtos";
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvProduto.Width = 350;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.HeaderText = "Categoria";
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Width = 150;
            // 
            // dgvPreço
            // 
            this.dgvPreço.HeaderText = "Preço";
            this.dgvPreço.Name = "dgvPreço";
            // 
            // dgvEditar
            // 
            this.dgvEditar.HeaderText = "Editar";
            this.dgvEditar.Name = "dgvEditar";
            // 
            // dgvExcluir
            // 
            this.dgvExcluir.HeaderText = "Excluir";
            this.dgvExcluir.Name = "dgvExcluir";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.ptbLogo);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPreço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExcluir;
    }
}