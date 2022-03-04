using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.labelMensagem = labelStatus; //atribuindo o label do form ao label da classe
        }

        private void txtArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Enviar arquivo";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofd.FileName; //pegando o nome do arquivo.
            }

        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnderecoIP.Text) ||
                string.IsNullOrEmpty(txtPortaHost.Value.ToString()) ||
                txtArquivo.Text == "Selecionar arquivo para envio") //vendo se está vazio ou nulo
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Dados inválidos";
                return;
            }

            FTCliente.EnderecoIP = txtEnderecoIP.Text;
            FTCliente.PortaHost  = (int)txtPortaHost.Value;
            try
            {
                Task.Factory.StartNew(() => //método lambda
                {
                    FTCliente.enviarArquivo(txtArquivo.Text);
                });

            }catch(Exception ex)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Erro : " + ex.Message;
            }
        }
    }
}
