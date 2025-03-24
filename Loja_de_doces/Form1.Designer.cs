namespace Loja_de_doces
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.ltbPedidos = new System.Windows.Forms.ListBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnAgendar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(197, 550);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Controls.Add(this.pcbMenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 103);
            this.panel2.TabIndex = 5;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMenu.Location = new System.Drawing.Point(62, 39);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(49, 20);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // pcbMenu
            // 
            this.pcbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenu.Image")));
            this.pcbMenu.Location = new System.Drawing.Point(0, 12);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(56, 74);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMenu.TabIndex = 0;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.UseWaitCursor = true;
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(125, 508);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.UseWaitCursor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.Location = new System.Drawing.Point(0, 313);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(197, 38);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.UseWaitCursor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Location = new System.Drawing.Point(0, 246);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(197, 38);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.UseWaitCursor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.ForeColor = System.Drawing.Color.Black;
            this.btnAgendar.Location = new System.Drawing.Point(0, 180);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(197, 38);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.UseWaitCursor = true;
            // 
            // ltbPedidos
            // 
            this.ltbPedidos.FormattingEnabled = true;
            this.ltbPedidos.Location = new System.Drawing.Point(653, 39);
            this.ltbPedidos.Name = "ltbPedidos";
            this.ltbPedidos.Size = new System.Drawing.Size(208, 472);
            this.ltbPedidos.TabIndex = 2;
            this.ltbPedidos.UseWaitCursor = true;
            this.ltbPedidos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(892, 550);
            this.Controls.Add(this.ltbPedidos);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListBox ltbPedidos;
    }
}

