using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_ClientesFornecedores.g1_ClientesFornecedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace baseCF
{
    public partial class CadastroFornecedores : Form
    {
        private int _idUpdate = 0;
        Fill fill = new Fill();

        public CadastroFornecedores()
        {
            InitializeComponent();
        }

        private void Consultar(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                string SQL = "SELECT * FROM g1_tblFornecedores";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "g1_tblFornecedores");

                dataGridView1.DataSource = DS.Tables["g1_tblFornecedores"];

                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private IEnumerable<SelectItem> ObterItensSelect(string tabela, string colunaDesc, string colunaId)
        {
            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = $"Select {colunaId}, {colunaDesc} from {tabela}";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable itensDataTable = new DataTable();
            da.Fill(itensDataTable);
            con.Close();

            foreach (DataRow item in itensDataTable.Rows)
            {
                yield return new SelectItem
                {
                    Id = (int)item[colunaId],
                    Label = (string)item[colunaDesc]
                };
            }
        }

        private int ObterStatusCadastro()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox_cnpj.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_razaoSocial.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_nomeFantasia.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_telefoneFixo.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_telefoneCelular.Text) &&
                    comboBox_banco.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(this.textBox_agencia.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_contaCorrente.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_contaCorrente.Text) &&
                    !string.IsNullOrWhiteSpace(this.comboBox_segmento.Text) &&
                    comboBox_estado.SelectedItem != null &&
                    comboBox_cidade.SelectedItem != null &&
                    comboBox_bairro.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(this.textBox_logradouro.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_numero.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_complemento.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_cep.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_email.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_inscricaoEstadual.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_inscricaoMunicipal.Text) &&
                    comboBox_regimetTributacao.SelectedItem != null &&
                    comboBox_situacaoIcms.SelectedItem != null &&
                    comboBox_segmento.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(this.textBox_nomeContato.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_dadosAdicionais1.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_dadosAdicionais2.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBox_dadosAdicionais3.Text))
            {
                return 2;
            }

            return 1;
        }

        private int ObterValorSelecionado(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null && comboBox.SelectedItem is SelectItem)
            {
                return ((SelectItem)comboBox.SelectedItem).Id;
            }

            return -1;
        }

        private void LimparCampos()
        {
            textBox_cnpj.Text = "";
            textBox_razaoSocial.Text = "";
            textBox_nomeFantasia.Text = "";
            textBox_telefoneFixo.Text = "";
            textBox_telefoneCelular.Text = "";
            comboBox_banco.SelectedItem = null;
            textBox_agencia.Text = "";
            textBox_contaCorrente.Text = "";
            textBox_digitoContaCorrente.Text = "";
            comboBox_segmento.SelectedItem = null;
            comboBox_estado.SelectedItem = null;
            comboBox_cidade.SelectedItem = null;
            comboBox_bairro.SelectedItem = null;
            textBox_logradouro.Text = "";
            textBox_numero.Text = "";
            textBox_complemento.Text = "";
            textBox_cep.Text = "";
            textBox_email.Text = "";
            textBox_inscricaoEstadual.Text = "";
            textBox_inscricaoMunicipal.Text = "";
            textBox_nomeContato.Text = "";
            textBox_dadosAdicionais1.Text = "";
            textBox_dadosAdicionais2.Text = "";
            textBox_dadosAdicionais3.Text = "";
        }

        private void Criar()
        {
            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            int digitoInt = 0;
            if (!string.IsNullOrWhiteSpace(this.textBox_numero.Text))
            {
                int.TryParse(this.textBox_digitoContaCorrente.Text, out digitoInt);
            }

            int numeroInt = 0;
            if (!string.IsNullOrWhiteSpace(this.textBox_numero.Text))
            {
                int.TryParse(this.textBox_numero.Text, out numeroInt);
            }

            cmd.CommandText = "INSERT INTO g1_tblFornecedores " +
            /*1*/        " ( CNPJ, " +
                        "razaoSocial, " +
                        "nomeFantasia, " +
                        "telefoneFixo, " +
            /*5*/            "telefoneCelular, " +
                        "idBanco, " +
                        "agencia, " +
                        "contaCorrente, " +
                        "digitoContaCorrente, " +
              /*10*/          "idSegmento, " +
                        "idEstado, " +
                        "idCidade," +
                        " idBairro, " +
                        "logradouro, " +
               /*15*/         "numero, " +
                        "complemento, " +
                        "CEP, " +
                        "email, " +
                        "inscricaoEstadual," +
               /*20*/         " inscricaoMunicipal, " +
                        "nomeContato, " +
                        "statusCadastro, " +
                        "dadosAdicionais1, " +
                        "dadosAdicionais2, " +
                /*25*/        "dadosAdicionais3)" +
                    "VALUES " +
               /*1*/         $" ('{textBox_cnpj.Text}', " +
                            $"'{textBox_razaoSocial.Text}', " +
                            $"'{textBox_nomeFantasia.Text}', " +
                            $"'{textBox_telefoneFixo.Text}', " +
                /*5*/       $"'{textBox_telefoneCelular.Text}'," +
                            $"{ObterValorSelecionado(comboBox_banco)}," +
                            $"'{textBox_agencia.Text}'," +
                            $"'{textBox_contaCorrente.Text}', " +
                            $"{digitoInt}, " +
                 /*10*/     $"{ObterValorSelecionado(comboBox_segmento)}, " +
                            $"{ObterValorSelecionado(comboBox_estado)}," +
                            $"{ObterValorSelecionado(comboBox_cidade)}, " +
                            $"{ObterValorSelecionado(comboBox_bairro)}, " +
                            $"'{textBox_logradouro.Text}', " +
                   /*15*/   $"{numeroInt}, " +
                            $"'{textBox_complemento.Text}', " +
                            $"'{textBox_cep.Text}', " +
                            $"'{textBox_email.Text}', " +
                            $"'{textBox_inscricaoEstadual.Text}'," +
                     /*20*/ $"'{textBox_inscricaoMunicipal.Text}', " +
                            $"'{textBox_nomeContato.Text}', " +
                            $"{ObterStatusCadastro()}, " +
                            $"'{textBox_dadosAdicionais1.Text}', " +
                            $"'{textBox_dadosAdicionais2.Text}', " +
                      /*25*/$"'{textBox_dadosAdicionais3.Text}');";

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Dados inseridos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Atualizar()
        {
            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            int digitoInt = 0;
            if (!string.IsNullOrWhiteSpace(this.textBox_numero.Text))
            {
                int.TryParse(this.textBox_digitoContaCorrente.Text, out digitoInt);
            }

            int numeroInt = 0;
            if (!string.IsNullOrWhiteSpace(this.textBox_numero.Text))
            {
                int.TryParse(this.textBox_numero.Text, out numeroInt);
            }

            cmd.CommandText = "UPDATE g1_tblFornecedores " +
                " SET " +
            "  CNPJ " + "=" + $" '{textBox_cnpj.Text}', " +
    "razaoSocial " + "=" + $"'{textBox_razaoSocial.Text}', " +
    "nomeFantasia " + "=" + $"'{textBox_nomeFantasia.Text}', " +
    "telefoneFixo " + "=" + $"'{textBox_telefoneFixo.Text}', " +
/*5*/            "telefoneCelular " + "=" +                 /*5*/       $"'{textBox_telefoneCelular.Text}'," +
    "idBanco " + "=" + $"{ObterValorSelecionado(comboBox_banco)}," +
    "agencia " + "=" + $"'{textBox_agencia.Text}'," +
    "contaCorrente " + "=" + $"'{textBox_contaCorrente.Text}', " +
    "digitoContaCorrente " + "=" + $"{digitoInt}, " +
/*10*/          "idSegmento " + "=" +                  /*10*/     $"{ObterValorSelecionado(comboBox_segmento)}, " +
    "idEstado " + "=" + $"{ObterValorSelecionado(comboBox_estado)}," +
    "idCidade" + "=" + $"{ObterValorSelecionado(comboBox_cidade)}, " +
    " idBairro " + "=" + $"{ObterValorSelecionado(comboBox_bairro)}, " +
    "logradouro " + "=" + $"'{textBox_logradouro.Text}', " +
/*15*/         "numero " + "=" +                    /*15*/   $"{numeroInt}, " +
    "complemento " + "=" + $"'{textBox_complemento.Text}', " +
    "CEP " + "=" + $"'{textBox_cep.Text}', " +
    "email " + "=" + $"'{textBox_email.Text}', " +
    "inscricaoEstadual" + "=" + $"'{textBox_inscricaoEstadual.Text}'," +
/*20*/         " inscricaoMunicipal " + "=" +                      /*20*/ $"'{textBox_inscricaoMunicipal.Text}', " +
    "nomeContato " + "=" + $"'{textBox_nomeContato.Text}', " +
    "statusCadastro " + "=" + $"{ObterStatusCadastro()}, " +
    "dadosAdicionais1 " + "=" + $"'{textBox_dadosAdicionais1.Text}', " +
    "dadosAdicionais2 " + "=" + $"'{textBox_dadosAdicionais2.Text}', " +
/*25*/              "dadosAdicionais3" + "=" + /*25*/$"'{textBox_dadosAdicionais3.Text}' " +
                      $" WHERE idFornecedores = {_idUpdate};";

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idUpdate == 0)
                {
                    Criar();
                }
                else
                {
                    Atualizar();
                    _idUpdate = 0;
                    textBox1.Text = "000";
                }
                LimparCampos();
                picBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar, forneça mais informações e tente novamente. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * from g1_tblFornecedores WHERE nomeFantasia LIKE '%{textBox_nomeFantasia.Text}%' ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tabelaFornecedores = new DataTable();
            da.Fill(tabelaFornecedores);
            if (tabelaFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado.");
            }
            dataGridView1.DataSource = tabelaFornecedores;
            con.Close();
        }

        private void PreencherSelects()
        {
            comboBox_bairro.Items.AddRange(ObterItensSelect("g1_tblBairro", "descBairro", "idBairro").ToArray());
            comboBox_banco.Items.AddRange(ObterItensSelect("g1_tblBanco", "codBanco", "idBanco").ToArray());
            comboBox_cidade.Items.AddRange(ObterItensSelect("g1_tblCidade", "descCidade", "idCidade").ToArray());
            comboBox_estado.Items.AddRange(ObterItensSelect("g1_tblEstado", "siglaEstado", "idEstado").ToArray());
            //comboBox_regimetTributacao.Items.AddRange(ObterItensSelect("g1_tblBairro", "descBairro", "idBairro").ToArray());
            comboBox_segmento.Items.AddRange(ObterItensSelect("g1_tblSegmento", "descSegmento", "idSegmento").ToArray());
            //comboBox_situacaoIcms.Items.AddRange(ObterItensSelect("g1_tblTipoTributo", "descSituacaoTributo", "idTipoTributo").ToArray());
        }

        private void CadastroFornecedores_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbNomeUsuarioPrincipal.Text = FrmMenu.getUsuario;
        }

        private void CadastroFornecedores_Load(object sender, EventArgs e)
        {
            PreencherSelects();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            var selectedCells = this.dataGridView1.SelectedCells;
            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Uma linha deve ser selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();

            var selectedRowIndex = selectedCells[0].RowIndex;
            var rowData = this.dataGridView1.Rows[selectedRowIndex];
            var id = (int)rowData.Cells[0].Value;
            cmd.CommandText = "DELETE from g1_tblFornecedores WHERE idFornecedores = " + id;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            int rowAffected = cmd.ExecuteNonQuery();
            if (rowAffected == 0)
            {
                MessageBox.Show("Uma linha deve ser selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dados excluidos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Consultar(null, null);
            con.Close();
        }

        private string TratarCampoVazio(object valor)
        {
            if (valor is DBNull)
            {
                return "";
            }

            return (string)valor;
        }

        private int TratarCampoVazioInt(object valor)
        {
            if (valor is DBNull)
            {
                return -1;
            }

            return (int)valor;
        }

        private void SelecionarEdicao_Click(object sender, EventArgs e)
        {
            var selectedCells = this.dataGridView1.SelectedCells;
            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Uma linha deve ser selecionada.");
                return;
            }

            var selectedRowIndex = selectedCells[0].RowIndex;
            var rowData = this.dataGridView1.Rows[selectedRowIndex];
            _idUpdate = (int)rowData.Cells[0].Value;
            textBox1.Text = _idUpdate.ToString();

            OleDbConnection con = new OleDbConnection(Globals.ConnString);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from g1_tblFornecedores where idFornecedores = " + _idUpdate;

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox_cnpj.Text = TratarCampoVazio(reader["CNPJ"]);
                textBox_razaoSocial.Text = TratarCampoVazio(reader["razaoSocial"]);
                textBox_nomeFantasia.Text = TratarCampoVazio(reader["nomeFantasia"]);
                textBox_telefoneFixo.Text = TratarCampoVazio(reader["telefoneFixo"]);
                textBox_telefoneCelular.Text = TratarCampoVazio(reader["telefoneCelular"]);
                SelecionarValorCombo(comboBox_banco, reader["idBanco"]);
                textBox_agencia.Text = TratarCampoVazio(reader["agencia"]);
                textBox_contaCorrente.Text = TratarCampoVazio(reader["contaCorrente"]);
                textBox_digitoContaCorrente.Text = TratarCampoVazioInt(reader["digitoContaCorrente"]).ToString();
                SelecionarValorCombo(comboBox_segmento, reader["idSegmento"]);
                SelecionarValorCombo(comboBox_estado, reader["idEstado"]);
                SelecionarValorCombo(comboBox_cidade, reader["idCidade"]);
                SelecionarValorCombo(comboBox_bairro, reader["idBairro"]);
                textBox_logradouro.Text = TratarCampoVazio(reader["logradouro"]);
                textBox_numero.Text = TratarCampoVazioInt(reader["numero"]).ToString();
                textBox_complemento.Text = TratarCampoVazio(reader["complemento"]);
                textBox_cep.Text = TratarCampoVazio(reader["CEP"]);
                textBox_email.Text = TratarCampoVazio(reader["email"]);
                textBox_inscricaoEstadual.Text = TratarCampoVazio(reader["inscricaoEstadual"]);
                textBox_inscricaoMunicipal.Text = TratarCampoVazio(reader["inscricaoMunicipal"]);
                textBox_nomeContato.Text = TratarCampoVazio(reader["nomeContato"]);
                textBox_dadosAdicionais1.Text = TratarCampoVazio(reader["dadosAdicionais1"]);
                textBox_dadosAdicionais2.Text = TratarCampoVazio(reader["dadosAdicionais2"]);
                textBox_dadosAdicionais3.Text = TratarCampoVazio(reader["dadosAdicionais3"]);
            }
            con.Close();
        }

        private void SelecionarValorCombo(ComboBox comboBox, object valor)
        {
            if (valor is DBNull)
            {
                return;
            }

            var itemsList = new List<SelectItem>();
            foreach (var comboItem in comboBox.Items)
            {
                itemsList.Add((SelectItem)comboItem);
            }

            var item = itemsList.FirstOrDefault(i => i.Id == (int)valor);
            comboBox.SelectedItem = item;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            _idUpdate = 0;
            textBox1.Text = "000";
            LimparCampos();
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_nomeFantasia.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Fecha esse form e volta ao menu principal
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formMenuCadastro.ActiveForm);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormManual>().Count() == 0)
            {
                FormManual frm = new FormManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FormManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}
