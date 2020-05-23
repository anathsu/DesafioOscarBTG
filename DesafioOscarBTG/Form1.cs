﻿using System;
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
            string strConn = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Desafio; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();

            string strSql = "Insert into Dados (comprador, descricao, preco_unitario, quantidade, endereco, fornecedor ) " +
                "Values (@comprador, @descricao, @preco_unitario, @quantidade, @endereco, @fornecedor)";

            var insert = new SqlCommand(strSql, conn);

            insert.Parameters.AddWithValue("@comprador", comprador);
            insert.Parameters.AddWithValue("@descricao", descricao);
            insert.Parameters.AddWithValue("@preco_unitario", float.Parse(preco_unitario));
            insert.Parameters.AddWithValue("@quantidade", Convert.ToInt32(quantidade));
            insert.Parameters.AddWithValue("@endereco", endereco);
            insert.Parameters.AddWithValue("@fornecedor", fornecedor);

            insert.ExecuteNonQuery();

            lblGravacaoSucesso.Text = "Arquivo gravado com sucesso!";

            conn.Close();


        }
    }
}
