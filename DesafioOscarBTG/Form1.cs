using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
