using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioOscarBTG
{
    public partial class Form1 : Form
    {
        private string strConn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_DesafioOscarBTG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        SqlCommand command = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirComo = new OpenFileDialog();

            DialogResult Caminho;

            StreamReader fluxotexto;

            string arquivo;
            int registro = 0;

            AbrirComo.Title = "Abrir Como";
            AbrirComo.FileName = "Nome Arquivo";
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt";
            Caminho = AbrirComo.ShowDialog();
            arquivo = AbrirComo.FileName;


            if (arquivo == " ")
            {
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
            }

            else
            {
                fluxotexto = new StreamReader(arquivo);
                string linhatexto = fluxotexto.ReadLine();

                while (linhatexto != null)
                {
                    linhatexto = fluxotexto.ReadLine();
                    registro = registro + 1;

                }

                txtArquivo.Text = AbrirComo.FileName;

                fluxotexto.Close();


                txtInfo.Text = ((registro - 1).ToString() + " Linhas encontradas");

                lblCaminhoSucesso.Text = "Arquivo lido com sucesso!";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtArquivo.Text))
            {
                var lista = new List<string>();
                int i = 0;

                using (StreamReader fluxotexto = new StreamReader(txtArquivo.Text))

                    while (true)
                    {

                        string linhatexto = fluxotexto.ReadLine();

                        if (linhatexto == null)
                        {
                            break;
                        }
                        if (i != 0)
                        {
                            int delimeter = 9;
                            char _delimeter = Convert.ToChar(delimeter);
                            string[] rowData = linhatexto.Split(_delimeter);
                            cadastra(rowData[0], rowData[1], rowData[2], rowData[3], rowData[4], rowData[5]);
                        }

                        i++;
                    }
            }
            else
            {
                MessageBox.Show("Arquivo não existe!");
            }
        }

        private void cadastra(string comprador, string descricao, string preco_unitario, string quantidade, string endereco, string fornecedor)
        {
            conn = new SqlConnection(strConn);
            conn.Open();

            string strSql = "Insert into Dados (Comprador, Descricao, PrecoUnitario, Quantidade, Endereco, Fornecedor ) " +
                "Values (@comprador, @descricao, @preco_unitario, @quantidade, @endereco, @fornecedor)";

            command = new SqlCommand(strSql, conn);

            command.Parameters.AddWithValue("@comprador", comprador);
            command.Parameters.AddWithValue("@descricao", descricao);
            command.Parameters.AddWithValue("@preco_unitario", float.Parse(preco_unitario));
            command.Parameters.AddWithValue("@quantidade", Convert.ToInt32(quantidade));
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@fornecedor", fornecedor);

            command.ExecuteNonQuery();

            lblGravacaoSucesso.Text = "Arquivo gravado com sucesso!";
            listaGrid();

            conn.Close();


        }

        private void listaGrid()
        {
            string strSql = "SELECT * FROM Dados";
            conn = new SqlConnection(strConn);
            conn.Open();
            command = new SqlCommand(strSql, conn);

            try{
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtLista = new DataTable();

                adapter.Fill(dtLista);
                dgvDadosSql.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro!");
            }

            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaGrid();
        }
    }
}
