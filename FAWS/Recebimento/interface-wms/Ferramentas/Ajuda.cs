using FAWS_WMS.Telas;
using interface_wms.Ferramentas;
using System;
using System.IO;
using System.Windows.Forms;

namespace Interface_WMS_Recebimento.Ferramentas
{
    public class FrmAjuda : FrmManualAjuda
    {
        private void InitializeComponent()
        {
            this.grbVisualizarManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirManualAjuda
            // 
            this.btnAbrirManualAjuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAbrirManualAjuda.Click += new System.EventHandler(this.btnAbrirManualAjuda_Click);
            // 
            // treeSelecionarAjuda
            // 
            this.treeSelecionarAjuda.LineColor = System.Drawing.Color.Black;
            this.treeSelecionarAjuda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSelecionarAjuda_AfterSelect);
            this.treeSelecionarAjuda.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSelecionarAjuda_NodeMouseDoubleClick);
            // 
            // btnVerManuais
            // 
            this.btnVerManuais.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerManuais.Click += new System.EventHandler(this.btnVerManuais_Click);
            // 
            // FrmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1049, 729);
            this.IsMdiContainer = true;
            this.Name = "FrmAjuda";
            this.Activated += new System.EventHandler(this.FrmAjuda_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAjuda_FormClosing);
            this.Load += new System.EventHandler(this.FrmAjuda_Load);
            this.Controls.SetChildIndex(this.treeSelecionarAjuda, 0);
            this.Controls.SetChildIndex(this.lbManualUsuario, 0);
            this.Controls.SetChildIndex(this.lbGuiaManual, 0);
            this.Controls.SetChildIndex(this.grbVisualizarManual, 0);
            this.Controls.SetChildIndex(this.btnVerManuais, 0);
            this.Controls.SetChildIndex(this.btnAbrirManualAjuda, 0);
            this.grbVisualizarManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private static string TreeNodeName = "";
        private static string Path = "";

        private static Control.ControlCollection ControlesManual;
        private static Control.ControlCollection setControlesManual { set => ControlesManual = value; }

        public FrmAjuda()
        {
            InitializeComponent();
            btnAbrirManualAjuda.Enabled = false;

            AbasFormatacoes.PassarCampos(lbManualUsuario, lbGuiaManual);
            AbasFormatacoes.PassarCampos(grbVisualizarManual);
            AbasFormatacoes.PassarCampos(btnVerManuais, btnAbrirManualAjuda);
            AbasFormatacoes.PassarCampos(treeSelecionarAjuda);

            setControlesManual = Controls;
        }

        //Iniciar formulário na cor e Tamanho desejado
        private void FrmAjuda_Activated(object sender, EventArgs e)
        {
            if (FrmPreferencias.getPadraoEscuro)
            {
                AbasFormatacoes.AtualizarCorDeFundoForm(Controls, "escuro");
            }
            else
            {
                AbasFormatacoes.AtualizarCorDeFundoForm(Controls, "padrao");
            }

            FrmPreferencias.AtualizarTamanhoCampos(FrmPreferencias.getTamanhoFonteValor);
        }

        //Pegando nome do arquivo que o usuario deseja abrir
        private void treeSelecionarAjuda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNodeName = treeSelecionarAjuda.SelectedNode.ToString().Replace("TreeNode: ", String.Empty);

            if (treeSelecionarAjuda.SelectedNode.Text == "Manuais")
            {
                btnAbrirManualAjuda.Enabled = false;
            }
            else
            {
                btnAbrirManualAjuda.Enabled = true;
            }
        }

        //Pegando nomes dos arquivos dos manuais, e mostrando
        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            Path = PegarManuais();
        }

        private void btnVerManuais_Click(object sender, EventArgs e)
        {
            axAcroManual.Visible = false;
            ListDirectory(treeSelecionarAjuda, Path);
        }

        private void treeSelecionarAjuda_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnAbrirManualAjuda.PerformClick();
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }

        private void btnAbrirManualAjuda_Click(object sender, EventArgs e)
        {
            axAcroManual.Visible = true;
            treeSelecionarAjuda.Nodes.Clear();

            string sup = Application.StartupPath + @"\Manuais\" + TreeNodeName;
            axAcroManual.LoadFile(sup);

            btnAbrirManualAjuda.Enabled = false;
        }

        //Fechar visualizador
        private void FrmAjuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            axAcroManual.Dispose();
        }

    }
}
