using System;
using System.IO;
using System.Windows.Forms;

namespace FAWS_WMS.Telas
{
    public partial class FrmManualAjuda : Form
    {
        private static string TreeNodeName = "";
        private static string Path = "";

        private static Control.ControlCollection ControlesManual;
        public static Control.ControlCollection getControlesManual { get => ControlesManual; }
        private static Control.ControlCollection setControlesManual { set => ControlesManual = value; }

        public FrmManualAjuda()
        {
            InitializeComponent();
            btnAbrirManualAjuda.Enabled = false;
            setControlesManual = Controls;
        }

        //Pegar Manuais  dos módulos da Pasta Manuais
        public static string PegarManuais()
        {
            string Path = Application.StartupPath + @"\Manuais\";
            return Path;
        }

        //Pegando nome do arquivo que o usuario deseja abrir
        private void trv_SelecionarAjuda_AfterSelect(object sender, TreeViewEventArgs e)
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
        private void WfAjuda_Load(object sender, EventArgs e)
        {
            Path = PegarManuais();
        }

        private void btnVerManuais_Click(object sender, EventArgs e)
        {
            axAcroManual.Visible = false;
            ListDirectory(treeSelecionarAjuda, Path);
        }

        //abrir manual com duplo clique no nome
        private void trv_SelecionarAjuda_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
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
        private void FrmManualAjuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            axAcroManual.Dispose();
        }


    }
}
