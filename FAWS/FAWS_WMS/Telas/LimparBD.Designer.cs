
namespace FAWS_WMS.Telas
{
    partial class FrmLimpar
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fornecedores");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Segmeto");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tipo de Tributo");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tributo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Status de Cadastro");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Clientes e Fornecedores", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Categoria");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Subcategoria");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Produtos", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Portarias");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Recebimento");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Divergências");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Recebimento", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Armazenagem");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Armazém", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Estoque Saída");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Pedido");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Expedição", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Limpar Tudo", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11,
            treeNode15,
            treeNode17,
            treeNode20});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLimpar));
            this.treLimpezaBD = new System.Windows.Forms.TreeView();
            this.btnCancelarLimpar = new System.Windows.Forms.Button();
            this.btnCancelarPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treLimpezaBD
            // 
            this.treLimpezaBD.CheckBoxes = true;
            this.treLimpezaBD.Enabled = false;
            this.treLimpezaBD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.treLimpezaBD.Location = new System.Drawing.Point(1, -5);
            this.treLimpezaBD.Name = "treLimpezaBD";
            treeNode1.Checked = true;
            treeNode1.Name = "NoClientes";
            treeNode1.Text = "Clientes";
            treeNode2.Checked = true;
            treeNode2.Name = "NoFornecedores";
            treeNode2.Text = "Fornecedores";
            treeNode3.Checked = true;
            treeNode3.Name = "NoSegmento";
            treeNode3.Text = "Segmeto";
            treeNode4.Checked = true;
            treeNode4.Name = "NoTipoTributo";
            treeNode4.Text = "Tipo de Tributo";
            treeNode5.Checked = true;
            treeNode5.Name = "NoTributo";
            treeNode5.Text = "Tributo";
            treeNode6.Checked = true;
            treeNode6.Name = "NoStatusCadastro";
            treeNode6.Text = "Status de Cadastro";
            treeNode7.Checked = true;
            treeNode7.Name = "NoClientesFornecedores";
            treeNode7.Text = "Clientes e Fornecedores";
            treeNode8.Checked = true;
            treeNode8.Name = "NoProduto";
            treeNode8.Text = "Produto";
            treeNode9.Checked = true;
            treeNode9.Name = "NoCategoria";
            treeNode9.Text = "Categoria";
            treeNode10.Checked = true;
            treeNode10.Name = "NoSubcategoria";
            treeNode10.Text = "Subcategoria";
            treeNode11.Checked = true;
            treeNode11.Name = "NoProdutos";
            treeNode11.Text = "Produtos";
            treeNode12.Checked = true;
            treeNode12.Name = "NoPortaria";
            treeNode12.Text = "Portarias";
            treeNode13.Checked = true;
            treeNode13.Name = "NoRecebimento";
            treeNode13.Text = "Recebimento";
            treeNode14.Checked = true;
            treeNode14.Name = "NoDivergencias";
            treeNode14.Text = "Divergências";
            treeNode15.Checked = true;
            treeNode15.Name = "NoRecebimento";
            treeNode15.Text = "Recebimento";
            treeNode16.Checked = true;
            treeNode16.Name = "NoArmazenagem";
            treeNode16.Text = "Armazenagem";
            treeNode17.Checked = true;
            treeNode17.Name = "NoArmazem";
            treeNode17.Text = "Armazém";
            treeNode18.Checked = true;
            treeNode18.Name = "NoEstoqueSaida";
            treeNode18.Text = "Estoque Saída";
            treeNode19.Checked = true;
            treeNode19.Name = "NoPedido";
            treeNode19.Text = "Pedido";
            treeNode20.Checked = true;
            treeNode20.Name = "NoExpedicao";
            treeNode20.Text = "Expedição";
            treeNode21.Checked = true;
            treeNode21.Name = "NoLimparTudo";
            treeNode21.Text = "Limpar Tudo";
            this.treLimpezaBD.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treLimpezaBD.Size = new System.Drawing.Size(481, 506);
            this.treLimpezaBD.TabIndex = 0;
            this.treLimpezaBD.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treLimpezaBD_AfterCheck);
            // 
            // btnCancelarLimpar
            // 
            this.btnCancelarLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelarLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarLimpar.Image = global::FAWS_WMS.Properties.Resources.cancelar;
            this.btnCancelarLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarLimpar.Location = new System.Drawing.Point(13, 531);
            this.btnCancelarLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarLimpar.Name = "btnCancelarLimpar";
            this.btnCancelarLimpar.Size = new System.Drawing.Size(127, 57);
            this.btnCancelarLimpar.TabIndex = 26;
            this.btnCancelarLimpar.Text = "Cancelar";
            this.btnCancelarLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarLimpar.UseVisualStyleBackColor = false;
            this.btnCancelarLimpar.Click += new System.EventHandler(this.btnCancelarLimpar_Click);
            // 
            // btnCancelarPort
            // 
            this.btnCancelarPort.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPort.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelarPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarPort.Image = global::FAWS_WMS.Properties.Resources.excluirBD;
            this.btnCancelarPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPort.Location = new System.Drawing.Point(342, 531);
            this.btnCancelarPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarPort.Name = "btnCancelarPort";
            this.btnCancelarPort.Size = new System.Drawing.Size(127, 57);
            this.btnCancelarPort.TabIndex = 25;
            this.btnCancelarPort.Text = "Executar\r\nLimpeza";
            this.btnCancelarPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPort.UseVisualStyleBackColor = false;
            this.btnCancelarPort.Click += new System.EventHandler(this.btnCancelarPort_Click);
            // 
            // FrmLimpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(482, 601);
            this.Controls.Add(this.btnCancelarLimpar);
            this.Controls.Add(this.btnCancelarPort);
            this.Controls.Add(this.treLimpezaBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLimpar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limpar Banco de Dados";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarPort;
        private System.Windows.Forms.TreeView treLimpezaBD;
        private System.Windows.Forms.Button btnCancelarLimpar;
    }
}