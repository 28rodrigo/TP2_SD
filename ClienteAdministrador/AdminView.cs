using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAdministrador
{
    public partial class AdminView : Form
    {
        private string Address;
        public AdminView(string _Address)
        {
            InitializeComponent();
            Address = _Address;
        }

        public async void ListLoader()
        {
            var loopAux = 0;
            var loopSucess = false;
            while(loopAux<3 && !loopSucess)
            {
                try
                {
                    var httpHandler = new HttpClientHandler();
                    httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

                    using var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                    var client = new ClienteAdministradorP.ClienteAdministradorPClient(channel);
                    var reply = await client.ConsultarAsync(new ConsultarInput { Pedido = true });
                    if (reply.Estado)
                    {
                        loopSucess = true;
                        foreach (var element in reply.Utilizadores)
                            listViewUtilizadores.Items.Add(element.NIF.ToString());

                        foreach (var element in reply.Apostas)
                            listViewChaves.Items.Add(element.NumeroAposta.ToString()).SubItems.AddRange(new string[] { element.Numeros, element.Estrelas, element.Premio.ToString(), element.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                    }
                    else
                    {
                        MessageBox.Show("Erro de Conexão ao server!", "Estado da Ligação:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }                
                }
                catch
                {
                    loopAux++;
                    MessageBox.Show("Erro de Conexão ao server!", "Estado da Ligação:", MessageBoxButtons.OK);
                }
            }
            
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            //buscar dados á base de dados (GRPC)
            ListLoader();
        }

        private async void buttonArquivar_Click(object sender, EventArgs e)
        {
            var loopAux = 0;
            var loopSucess = false;
            while (loopAux < 3 && !loopSucess)
            {
                try
                {
                    var httpHandler = new HttpClientHandler();
                    httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                    using var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                    var client = new ClienteAdministradorP.ClienteAdministradorPClient(channel);
                    var reply = await client.ArquivarAsync(new ArquivoInput { Pedido = true });
                    //enviar mensagem

                    if (reply.EstadoArquivo)
                    {
                        MessageBox.Show("Apostas Arquivadas com sucesso!", "Estado da Aposta:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }
                    else
                    {
                        MessageBox.Show("Não há apostas para arquivar!", "Estado da Aposta:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }
                    //limpar lista
                    listViewChaves.Items.Clear();
                }
                catch
                {
                    loopAux++;
                    MessageBox.Show("A operação não pode prosseguir por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }
            }
        }
    }
}
