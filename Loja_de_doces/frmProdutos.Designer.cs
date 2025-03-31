namespace Loja_de_doces
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.BackgroundColor = System.Drawing.Color.White;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduto,
            this.dgvCategoria,
            this.dgvPreço,
            this.dgvEditar,
            this.dgvExcluir});
            this.dgvCadastro.GridColor = System.Drawing.Color.Azure;
            this.dgvCadastro.Location = new System.Drawing.Point(0, 212);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(843, 241);
            this.dgvCadastro.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(165, 11);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(123, 40);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Status Pedidos";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(303, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 40);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.Location = new System.Drawing.Point(26, 11);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(123, 40);
            this.btnAgendamento.TabIndex = 0;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProduto.HeaderText = "                                              Produtos";
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnAgendamento);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 59);
            this.panel1.TabIndex = 3;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPreço;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}