using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    internal class FTCliente
    {
        static IPEndPoint ipEnd_cliente;
        static Socket clienteSock_cliente;
        public static string EnderecoIP= "127.0.0.1";
        public static int PortaHost = 1000;

        public static Label labelMensagem;

        public static void enviarArquivo(string arquivo)
        {
            try
            {
                ipEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                clienteSock_cliente = new Socket(AddressFamily.InterNetwork ,SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);  //nome da pasta;
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1); //nome do arquivo
               

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo); //array de bytes do nome do arquivo

                if(nomeArquivoByte.Length > 50000 * 1024) //verificando se o tamanho do arquivo é maior q 50mb
                {
                    labelMensagem.Invoke(new Action(() => //usando o invoke e passando um metodo anonimo
                    {
                        labelMensagem.ForeColor = Color.Red;
                        labelMensagem.Text = "O tamanho do arquivo é maior de 50mb, tente um arquivo menor";
                    }));
                    return; //finalizar caso caia no if.
                }
                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto); //pegando o arquivo
                byte[] clienteData = new byte[4 + nomeArquivoByte.Length + fileData.Length]; //array com tamanho suficiente para o arquivo
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length); //tamanho do nome do arquivo

                nomeArquivoLen.CopyTo(clienteData, 0);
                nomeArquivoByte.CopyTo(clienteData, 4);
                fileData.CopyTo(clienteData, 4 + nomeArquivoByte.Length);

                clienteSock_cliente.Connect(ipEnd_cliente);
                clienteSock_cliente.Send(clienteData, 0, clienteData.Length, 0);
                clienteSock_cliente.Close();

                labelMensagem.Invoke(new Action(() => //usando o invoke e passando um metodo anonimo
                {
                    labelMensagem.ForeColor = Color.Green;
                    labelMensagem.Text = "Arquivo [" + arquivo + "] transferido.";
                }));


            }
            catch(Exception ex)
            {
                labelMensagem.Invoke(new Action(() => //usando o invoke e passando um metodo anonimo
                {
                   labelMensagem.Text = "Falha o servidor não está atendendo " + ex.Message;
                }));
            }
            finally
            {
                clienteSock_cliente.Close();
            }
        }
    }
}
