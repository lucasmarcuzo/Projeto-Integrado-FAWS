using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_Produtos;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static interface_wms.conexao;
using static interface_wms.metodos;
using static interface_wms.relatorio;

namespace interface_wms
{
    public partial class frmProdutos : Form
    {

        public bool admin;
        public string nomeAntigo;
        public string strCaminho = Application.StartupPath.ToString() + "\\img-products\\";
        public string strCaminho2 = Application.StartupPath.ToString() + "\\material\\";

        public void ativar()
        {
            txtNameProd.Enabled = true;
            txtRefProd.Enabled = true;
            txtDescripProd.Enabled = true;
            txtCategProd.Enabled = true;
            txtSubCategProd.Enabled = true;
            txtFornecedores.Enabled = true;
            txtTipoUnid.Enabled = true;
            txtExpDateProd.Enabled = true;
            txtWeightProd.Enabled = true;
            txtWeightLiqProd.Enabled = true;
            txtPriceProd.Enabled = true;
            txtQtdeProd.Enabled = true;
            txtQtdeDispProd.Enabled = true;
            txtEANProd.Enabled = true;
            picIMGProd.Visible = true;
            picIMGProd.Enabled = true;
            string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
            picIMGProd.ImageLocation = imagem;
            picIMGProd.Load();
        }

        //desativa todas as box's do form. Ativo por padrão.
        public void desativar()
        {
            txtCodProd.Enabled = true;
            txtNameProd.Enabled = false;
            txtRefProd.Enabled = false;
            txtDescripProd.Enabled = false;
            txtCategProd.Enabled = false;
            txtSubCategProd.Enabled = false;
            txtFornecedores.Enabled = false;
            txtTipoUnid.Enabled = false;
            txtExpDateProd.Enabled = false;
            txtWeightProd.Enabled = false;
            txtWeightLiqProd.Enabled = false;
            txtPriceProd.Enabled = false;
            txtQtdeProd.Enabled = false;
            txtQtdeDispProd.Enabled = false;
            txtEANProd.Enabled = false;
            picIMGProd.Visible = false;
            picIMGProd.Enabled = false;
        }

        //limpar todas as textbox's
        public void limpaTudo()
        {
            txtNameProd.Clear();
            txtRefProd.Clear();
            txtDescripProd.Clear();
            txtExpDateProd.Clear();
            txtWeightProd.Clear();
            txtWeightLiqProd.Clear();
            txtPriceProd.Clear();
            txtQtdeProd.Clear();
            txtQtdeDispProd.Clear();
            txtEANProd.Clear();
            txtCodProd.Clear();
            nomeAntigo = "";
        }

        public bool verificaPreenchido()
        {
            bool preenchido = false;
            string nome, descricao, categ, subCateg, fornecedor, tipoUn, val, pesoB, pesoL, preco, qtde, qtdeDisp, ean;
            nome = txtNameProd.Text;
            descricao = txtDescripProd.Text;
            categ = txtCategProd.Text;
            subCateg = txtSubCategProd.Text;
            fornecedor = txtFornecedores.Text;
            tipoUn = txtTipoUnid.Text;
            val = txtExpDateProd.Text;
            pesoB = txtWeightProd.Text;
            pesoL = txtWeightLiqProd.Text;
            preco = txtPriceProd.Text;
            qtde = txtQtdeProd.Text;
            qtdeDisp = txtQtdeDispProd.Text;
            ean = txtEANProd.Text;

            if (nome.Length == 0 || descricao.Length == 0 || categ.Length == 0 || subCateg.Length == 0 || tipoUn.Length == 0
                   || val.Length == 0 || pesoB.Length == 0 || pesoL.Length == 0 || preco.Length == 0 || qtde.Length == 0 || qtdeDisp.Length == 0 || ean.Length == 0)
                preenchido = false;
            else
                preenchido = true;

            return preenchido;
        }

        public void salvarImg()
        {
            string nomeImg = txtNameProd.Text;
            if (File.Exists(strCaminho + nomeImg + ".png") || File.Exists(strCaminho + nomeAntigo + ".png"))
            {
                Bitmap img = new Bitmap(Path.Combine(strCaminho2, "img-padrao.png"));
                picIMGProd.Image = img;
                picIMGProd.ImageLocation = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                picIMGProd.Load();

                if (nomeAntigo == nomeImg)
                {
                    File.Copy(Path.Combine(strCaminho2, "auxiliar.png"), Path.Combine(strCaminho, nomeImg + ".png"), true);
                    picIMGProd.ImageLocation = strCaminho2 + "auxiliar.png";
                    Bitmap img2 = new Bitmap(Path.Combine(strCaminho2, "auxiliar.png"));
                    picIMGProd.Image = img2;
                    picIMGProd.Load();
                }
                else
                {
                    File.Copy(Path.Combine(strCaminho2, "auxiliar.png"), Path.Combine(strCaminho, nomeAntigo + ".png"), true);
                    picIMGProd.ImageLocation = strCaminho2 + "auxiliar.png";
                    Bitmap img2 = new Bitmap(Path.Combine(strCaminho2, "auxiliar.png"));
                    picIMGProd.Image = img2;
                    picIMGProd.Load();
                    File.Move(strCaminho + nomeAntigo + ".png", strCaminho + nomeImg + ".png");
                }
            }
            else
            {
                picIMGProd.Image.Save(strCaminho + nomeImg + ".png", System.Drawing.Imaging.ImageFormat.Png);
                txtImgLocal.Text = strCaminho + txtNameProd.Text + ".png";
            }
        }


        //Chamando fornecedores direto da tabela de fornecedores
        public void chamarFornecedores()
        {
            try
            {
                string SQL = "SELECT idFornecedores, nomeFantasia FROM g1_tblFornecedores";
                var fornecedores = retornaTable(SQL);

                int b = Convert.ToInt32(fornecedores.Rows.Count);
                txtFornecedores.Items.Clear();

                for (int i = 0; i < b; i++)
                {
                    txtFornecedores.Items.Add(fornecedores.Rows[i][1]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //Esse método sem retorno irá chamar para a comboBox Categoria todos as categorias cadastradas no banco de dados até o momento. Ela atualiza automaticamente.
        public void chamarCat()
        {
            try
            {
                string SQL = "SELECT ID,NOME FROM g5_Categoria";
                var categoria = retornaTable(SQL);

                int b = Convert.ToInt32(categoria.Rows.Count);
                txtCategProd.Items.Clear();

                for (int i = 0; i < b; i++)
                {
                    txtCategProd.Items.Add(categoria.Rows[i][1]);
                }
                txtCategProd.Items.Add("Nova categoria");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //Esse método sem retorno irá chamar para a comboBox Sub Categoria todos as sub categorias cadastradas no banco de dados até o momento. Ela atualiza automaticamente.
        public void chamarSubCat()
        {
            try
            {
                string SQL = "SELECT g5_subcategoria.ID,g5_subcategoria.NOME FROM g5_SubCategoria INNER JOIN g5_categoria on g5_subcategoria.idcategoria = g5_categoria.ID WHERE g5_categoria.nome LIKE '" + txtCategProd.Text + "'";
                var subcategoria = retornaTable(SQL);

                int b = Convert.ToInt32(subcategoria.Rows.Count);
                txtSubCategProd.Items.Clear();

                for (int i = 0; i < b; i++)
                {
                    txtSubCategProd.Items.Add(subcategoria.Rows[i][1]);
                }
                txtSubCategProd.Items.Add("Nova sub categoria");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        //Daqui para baixo, começa o programa e implementação dos botões.        
        public frmProdutos(bool admin)
        {
            InitializeComponent();
            chamarCat();
            chamarSubCat();
            this.admin = admin;
            gerarRelatórioToolStripMenuItem.Enabled = admin;
            if (admin == true)
            {
                lblUser.Text = "Administrador";
            }
            else
            {
                lblUser.Text = "Funcionário";
            }
        }

        public void btnMenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Módulo disponível apenas na versão Beta.", "FAWS WMS");

            this.Close();
        }

        public void picIMGProd_Click(object sender, EventArgs e)
        {
            openBrowser.Title = "Selecionar Imagem do Produto";
            openBrowser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            if (openBrowser.ShowDialog() != DialogResult.Cancel)
            {
                Bitmap image = new Bitmap(openBrowser.FileName);
                txtImgLocal.Text = Application.StartupPath.ToString() + "\\img-products\\" + txtNameProd.Text + ".png";
            }

        }

        //Ainda não implementado. 05/06/2021. 
        public void picIMGProd_MouseHover(object sender, EventArgs e)
        {

            ToolTip hover = new ToolTip();
            hover.SetToolTip(picIMGProd, "Clique para inserir ou editar a imagem do produto");
        }


        public void btnNew_Click(object sender, EventArgs e)
        {
            txtNameProd.Focus();
            try
            {
                btnEditImage.Visible = false;
                dgwListProd.Rows.Clear();
                btnSearch.Enabled = false;
                dgwListProd.Enabled = false;
                txtSearchProd.Enabled = false;
                lblInstructions.Text = "* preenchimento obrigatório. ** preenchimento automático.  Ao finalizar, clique em Salvar.";
                lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
                lblInstructions.Location = new Point(34, 30);
                limpaTudo();
                chamarCat();
                ativar();
                txtCodProd.Enabled = false;
                txtRefProd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                limpaTudo();
                txtNameProd.Focus();
                txtNameProd.TabIndex = 1;
                btnEditImage.Enabled = true;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        public void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtCodProd.Text != "")
                {
                    btnEditProd.Enabled = true;
                    btnDelete.Enabled = true;
                    string pasta = Application.StartupPath + @"\BDP2-WMSV2.mdb";
                    string SQL = "SELECT g5_produto.nome, g5_produto.Referencia, g5_produto.Descricao, g5_categoria.nome, g5_subcategoria.nome, g1_tblFornecedores.NomeFantasia, g5_produto.Validade,g5_produto.PesoBrut,g5_produto.PesoLiq,g5_produto.PrecoProduto,g5_produto.PrecoTipo,g5_produto.Quantidade,g5_produto.QtdeDisponivel,g5_produto.CodigoEAN FROM(g1_tblFornecedores INNER JOIN(g5_produto INNER JOIN(g5_subCategoria inner join g5_categoria on g5_subCategoria.idCategoria = g5_categoria.ID) on g5_produto.SubCategoria = g5_SubCategoria.ID) on g1_tblFornecedores.idFornecedores = g5_produto.Fornecedor) WHERE g5_produto.CodigoProduto = " + txtCodProd.Text + ";";
                    DataTable dados = retornaTable(SQL);

                    //referencia
                    int rf = (int)dados.Rows[0][1];
                    string referencia = converteInt(rf);
                    txtRefProd.Text = referencia;

                    //pesoBruto
                    double pb = (double)dados.Rows[0][7];
                    string pesobruto = converteDouble(pb);
                    txtWeightProd.Text = pesobruto;

                    //pesoLiq
                    double pl = (double)dados.Rows[0][8];
                    string pesoLiquido = converteDouble(pl);
                    txtWeightLiqProd.Text = pesoLiquido;

                    //preço
                    double pc = (double)dados.Rows[0][9];
                    string preco = converteDouble(pc);
                    txtPriceProd.Text = preco;

                    //validade
                    DateTime val = (DateTime)dados.Rows[0][6];
                    string validade = converteDate(val);
                    txtExpDateProd.Text = validade;

                    //dados que não precisam de conversão
                    txtNameProd.Text = (string)dados.Rows[0][0];
                    nomeAntigo = (string)dados.Rows[0][0];
                    txtDescripProd.Text = (string)dados.Rows[0][2];
                    txtCategProd.SelectedItem = (string)dados.Rows[0][3];
                    chamarSubCat();
                    txtSubCategProd.SelectedItem = (string)dados.Rows[0][4];
                    txtEANProd.Text = (string)dados.Rows[0][13];
                    chamarFornecedores();
                    txtFornecedores.SelectedItem = (string)dados.Rows[0][5];
                    txtTipoUnid.Text = (string)dados.Rows[0][10];
                    txtQtdeProd.Text = Convert.ToString((Int16)dados.Rows[0][11]);
                    txtQtdeDispProd.Text = Convert.ToString((Int16)dados.Rows[0][12]);
                    string imagem = Application.StartupPath.ToString() + "\\img-products\\" + txtNameProd.Text + ".png";
                    picIMGProd.ImageLocation = imagem;
                    picIMGProd.Load();
                    picIMGProd.Visible = true;
                }
                else
                {
                    btnEditProd.Enabled = false;
                    btnDelete.Enabled = false;
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            try
            {
                ativar();
                btnEditImage.Visible = true;
                txtRefProd.Enabled = false;
                txtCodProd.Enabled = false;
                txtEANProd.Enabled = false;
                txtCategProd.Enabled = false;
                txtSubCategProd.Enabled = false;
                txtFornecedores.Enabled = false;
                btnSave.Enabled = false;
                btnEditImage.Enabled = true;
                btnSaveChanges.Enabled = true;
                btnNew.Enabled = false;
                string imagem = Application.StartupPath.ToString() + "\\img-products\\" + txtNameProd.Text + ".png";
                picIMGProd.ImageLocation = imagem;
                picIMGProd.Load();
                picIMGProd.Visible = true;
                picIMGProd.Enabled = false;
                btnCancel.Enabled = true;
                txtImgLocal.Text = "";
                dgwListProd.Rows.Clear();
                btnSearch.Enabled = false;
                dgwListProd.Enabled = false;
                txtSearchProd.Enabled = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //Agora, ao clicar em excluir, a coluna "Ativo", definido por padrão como 1, receberá o valor 0, que significa "Desativado".
        //O produto não será excluído realmente do banco de dados, só mudará seu status de Ativo para Desativado.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                try
                {
                    var result = MessageBox.Show("Tem certeza que deseja excluir o produto " + txtNameProd.Text + "?", "FAWS WMS", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string nomeImg = Path.GetFileName(Application.StartupPath + "\\img-products\\" + txtNameProd.Text);
                        string SQL = "UPDATE g5_Produto SET g5_Produto.Ativo = 0 WHERE CodigoProduto LIKE '" + txtCodProd.Text + "'";
                        executaConsulta(SQL);
                        MessageBox.Show("Produto excluído com sucesso", "FAWS WMS");
                        limpaTudo();

                        //Marcar a imagem como excluída
                        picIMGProd.Image.Dispose();
                        string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                        picIMGProd.ImageLocation = imagem;
                        picIMGProd.Load();
                        File.Move(Application.StartupPath + "\\img-products\\" + nomeImg + ".png", Application.StartupPath + "\\img-products\\" + nomeImg + "_Excluido.png");

                        picIMGProd.Visible = true;
                        btnSearch.Enabled = true;
                        dgwListProd.Enabled = true;
                        txtSearchProd.Enabled = true;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Somente o administrador pode realizar exclusão!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, descricao, categ, subCateg, fornecedor, tipoUn, cod, val, pesoB, pesoL, preco, qtde, qtdeDisp, ean, imagem;

                nome = txtNameProd.Text;
                descricao = txtDescripProd.Text;
                categ = txtCategProd.Text;
                subCateg = txtSubCategProd.Text;
                fornecedor = txtFornecedores.Text;
                tipoUn = txtTipoUnid.Text;
                val = txtExpDateProd.Text;
                pesoB = txtWeightProd.Text;
                pesoL = txtWeightLiqProd.Text;
                preco = txtPriceProd.Text;
                qtde = txtQtdeProd.Text;
                qtdeDisp = txtQtdeDispProd.Text;
                ean = txtEANProd.Text;
                imagem = txtImgLocal.Text;

                if (!verificaPreenchido())
                {
                    MessageBox.Show("Preencha todos os campos do formulário para salvar o cadastro.", "FAWS WMS");
                }
                else
                {

                    //Buscar o codigo da categoria nos métodos que retornam valor:
                    int categoria = procuraCateg(categ);
                    int subCategoria = procuraSubCateg(subCateg);
                    int codigoFornecedor = procuraFornecedor(fornecedor);

                    //gerando código do produto:
                    int referencia = procuraID() + 1;
                    cod = "" + Convert.ToInt32(categoria) + Convert.ToInt32(subCategoria) + referencia;
                    int codigo = Convert.ToInt32(cod);
                    salvarImg();

                    //String para inserir os dados no banco de dados
                    string SQL = "INSERT INTO g5_produto (CodigoProduto,Categoria,SubCategoria,Referencia,Nome,CodigoEAN,Descricao,Validade,PesoLiq,PesoBrut,Quantidade,QtdeDisponivel,PrecoProduto,PrecoTipo,Imagem, Fornecedor) VALUES (" + codigo + "," + categoria + "," + subCategoria + ",'" + referencia + "','" + nome + "','" + ean + "','" + descricao + "','" + val + "','" + pesoL + "','" + pesoB + "','" + qtde + "','" + qtdeDisp + "','" + preco + "','" + tipoUn + "','" + imagem + "'," + codigoFornecedor + ")";
                    executaConsulta(SQL);

                    MessageBox.Show("Produto Cadastrado.", "FAWS WMS");

                    limpaTudo();
                    desativar();

                    lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
                    lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
                    txtImgLocal.Text = "";
                    btnSearch.Enabled = true;
                    dgwListProd.Enabled = true;
                    txtSearchProd.Enabled = true;
                    btnEditImage.Visible = true;
                    picIMGProd.Visible = true;
                    imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                    picIMGProd.ImageLocation = imagem;
                    picIMGProd.Load();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja cancelar?", "FAWS WMS", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                desativar();
                lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
                lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Regular);
                btnNew.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnSaveChanges.Enabled = false;
                btnEditImage.Enabled = false;
                btnEditImage.Visible = false;
                txtImgLocal.Text = "";
                limpaTudo();
                btnSearch.Enabled = true;
                dgwListProd.Enabled = true;
                txtSearchProd.Enabled = true;
                string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                picIMGProd.ImageLocation = imagem;
                picIMGProd.Load();
                picIMGProd.Visible = true;
            }
            else
            {

            }
        }

        //Aqui, caso o usuário selecione "Nova Categoria", o formulário para cadastrar a nova categoria será aberto.
        private void txtCategProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCategProd.Text == "Nova categoria")
                {
                    Form cadastroCat = new frmAddCateg();
                    cadastroCat.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //Aqui, quando o usuário clicar em Categoria do produto ele vai chamar o método chamarCat que fará a consulta e preenchimento dos itens no comboBox de acordo com as
        //categorias presentes no banco de dados.
        private void txtCategProd_MouseClick(object sender, MouseEventArgs e)
        {
            chamarCat();
        }

        private void txtSubCategProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSubCategProd.Text == "Nova sub categoria")
                {
                    Form cadastroSubCat = new frmAddSubCateg();
                    cadastroSubCat.Show();

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtSubCategProd_MouseClick(object sender, MouseEventArgs e)
        {
            chamarSubCat();
        }

        private void tmrDataHora_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgwListProd.Rows.Clear();

            try
            {
                string consulta = "SELECT g5_produto.ID,g5_produto.CodigoProduto,g5_produto.Nome,g5_produto.Referencia,g5_categoria.Nome,g5_subcategoria.Nome,g1_tblFornecedores.nomeFantasia,g5_produto.Quantidade,g5_produto.QtdeDisponivel FROM (g1_tblFornecedores INNER JOIN(g5_subcategoria INNER JOIN(g5_categoria inner join g5_produto on g5_produto.categoria = g5_categoria.ID) on g5_produto.SubCategoria = g5_subcategoria.ID) on g1_tblFornecedores.idFornecedores = g5_Produto.Fornecedor) WHERE g5_Produto.Ativo = YES";

                if (txtSearchProd.Text != "")
                {
                    consulta = "SELECT g5_produto.ID,g5_produto.CodigoProduto,g5_produto.Nome,g5_produto.Referencia,g5_categoria.Nome,g5_subcategoria.Nome,g1_tblFornecedores.nomeFantasia,g5_produto.Quantidade,g5_produto.QtdeDisponivel FROM (g1_tblFornecedores INNER JOIN(g5_subcategoria INNER JOIN(g5_categoria inner join g5_produto on g5_produto.categoria = g5_categoria.ID) on g5_produto.SubCategoria = g5_subcategoria.ID) on g1_tblFornecedores.idFornecedores = g5_Produto.Fornecedor) WHERE g5_produto.nome LIKE '" + txtSearchProd.Text + "%' OR g5_produto.CodigoProduto LIKE '" + txtSearchProd.Text + "' AND g5_Produto.Ativo = YES";
                }

                DataTable dados = retornaTable(consulta);

                foreach (DataRow linha in dados.Rows)
                {
                    dgwListProd.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception er)
            {
                dgwListProd.Rows.Clear();
                MessageBox.Show("Erro " + er);
            }
            finally
            {

            }
        }

        private void dgwListProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwListProd.CurrentCell.ColumnIndex == 1)
            {
                txtCodProd.Text = Convert.ToString(dgwListProd.CurrentCell.Value);
            }
        }

        private void openBrowser_FileOk(object sender, CancelEventArgs e)
        {
            picIMGProd.Image = System.Drawing.Image.FromFile(openBrowser.FileName);
        }

        private void txtEANProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNum(e);
        }

        private void txtQtdeProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNum(e);
        }

        private void txtQtdeDispProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNum(e);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, descricao, tipoUn, val, pesoB, pesoL, preco, qtde, qtdeDisp;
                nome = txtNameProd.Text;
                descricao = txtDescripProd.Text;
                tipoUn = txtTipoUnid.Text;
                val = txtExpDateProd.Text;
                pesoB = txtWeightProd.Text;
                pesoL = txtWeightLiqProd.Text;
                preco = txtPriceProd.Text;
                qtde = txtQtdeProd.Text;
                qtdeDisp = txtQtdeDispProd.Text;

                if (nome.Length == 0 || descricao.Length == 0 || tipoUn.Length == 0
                    || val.Length == 0 || pesoB.Length == 0 || pesoL.Length == 0 || preco.Length == 0 || qtde.Length == 0 || qtdeDisp.Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos do formulário para salvar o cadastro.", "FAWS WMS");
                }
                else
                {
                    string SQL = "UPDATE g5_Produto SET g5_Produto.Nome = '" + nome +
                        "', g5_Produto.Quantidade = '" + qtde +
                        "', g5_Produto.QtdeDisponivel = '" + qtdeDisp +
                        "', g5_Produto.Descricao = '" + descricao +
                        "', g5_Produto.PesoBrut = '" + pesoB +
                        "', g5_Produto.PesoLiq = '" + pesoL +
                        "', g5_Produto.PrecoProduto = " + preco +
                        ", g5_Produto.Validade = " + val +
                        ", g5_Produto.PrecoTipo = '" + tipoUn +
                        "' WHERE g5_Produto.CodigoProduto = " + txtCodProd.Text;
                    executaConsulta(SQL);
                    salvarImg();
                    MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS");
                    limpaTudo();
                    desativar();
                    btnSaveChanges.Enabled = false;
                    txtImgLocal.Text = "";
                    btnSearch.Enabled = true;
                    btnNew.Enabled = true;
                    btnCancel.Enabled = false;
                    dgwListProd.Enabled = true;
                    txtSearchProd.Enabled = true;
                    picIMGProd.Visible = true;
                    picIMGProd.Enabled = false;
                    string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                    picIMGProd.ImageLocation = imagem;
                    picIMGProd.Load();


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnNew, "Cadastrar novo produto");
        }

        private void btnEditProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnEditProd, "Editar cadastro ativo");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnDelete, "Excluir cadastro ativo");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnSearch, "Ver todos os produtos cadastrados");
        }

        private void txtWeightProd_KeyPress(object sender, KeyPressEventArgs e)
        {

            apenasNum(e);

        }

        private void txtWeightLiqProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNum(e);
        }

        private void grpSearchProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(grpSearchProd, "Dê um duplo clique sobre o código desejado para ver todas as informações do cadastro");
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            string nomeImg = txtNameProd.Text;
            openBrowser.Title = "Selecionar Imagem do Produto";
            openBrowser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            if (openBrowser.ShowDialog() != DialogResult.Cancel)
            {
                txtImgLocal.Text = strCaminho + nomeImg + ".png";
                picIMGProd.ImageLocation = strCaminho2 + "auxiliar.png";
                picIMGProd.Image.Save(strCaminho2 + "auxiliar.png", System.Drawing.Imaging.ImageFormat.Png);
                Bitmap img = new Bitmap(Path.Combine(strCaminho2, "auxiliar.png"));
                picIMGProd.Image = img;
                picIMGProd.Load();
            }
        }

        private void btnEditImage_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(picIMGProd, "Clique para inserir ou editar a imagem do produto");
        }

        private void permissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Suas permissões:\n{ lblUser.Text}\n\n" +
                $"\n[ X ]\tCadastrar novos produtos" +
                $"\n[ X ]\tEditar produtos" +
                $"\n[ X ]\tExcluir produtos", "FAWS WMS");
        }

        private void txtPriceProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 46) //--> Se a tecla digitada não for número nem Backspace (ASCII código 08)

            {
                //Desativar o evento (de digitar)
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números, vírgulas e pontos.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtFornecedores_Click(object sender, EventArgs e)
        {
            chamarFornecedores();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nomeArquivo = gerarRelatorio(pesquisaProdutos().Count);
            //abrir o PDF no visualizador do win
            var caminhoRel = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            var caminho = @"C:\FAWS\Relatorios\";
            if (!File.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            string newCaminho = Path.Combine(caminho + nomeArquivo);
            File.Move(caminhoRel, newCaminho);

            if (File.Exists(newCaminho))
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = $"/c start chrome {newCaminho}",
                    FileName = "cmd.exe",
                    CreateNoWindow = true
                });
            }
        }

        //Abrir manual de Ajuda.
        private void tsmiSuporteRec_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManual>().Count() == 0)
            {
                FrmManual frm = new FrmManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        //Sair para o Menu
        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmMenu>().Count() == 0)
            {
                FrmMenu frm = new FrmMenu();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmMenu)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        //Mensagem de Saída Padrão
        private void frmProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair? \nOs dados que não foram enviados não serão salvos!", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}
