using Google.Protobuf.WellKnownTypes;
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
        //parametro de Entrada - Address de ligação ao servidor
        private string Address;
        public AdminView(string _Address)
        {
            InitializeComponent();
            Address = _Address;
        }
        /// <summary>
        /// Função que é responsável por contactar o servidor para receber toda as apostas ativas e a informação de todos os Utilizadores
        /// </summary>
        public async void ListLoader()
        {
            //em cada chamada ao servidor caso a primeira tentativa falhar são tentadas mais duas vezes
            var loopAux = 0;
            var loopSucess = false;

            while(loopAux<3 && !loopSucess)
            {
                try
                {
                    //configurar ligação ao servidor
                    var httpHandler = new HttpClientHandler();
                    httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                    //criar cliente para acessar ao servidor
                    using var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                    var client = new ClienteAdministradorP.ClienteAdministradorPClient(channel);
                    //invocar função Consultar implementada no servidor 
                    //reply = resposta do servidor
                    var reply = await client.ConsultarAsync(new Empty());
                    if (reply.Estado)
                    {
                        //Estado -> true -> Operação correu bem
                        //atualizar ListView's
                        foreach (var element in reply.Utilizadores)
                            listViewUtilizadores.Items.Add(element.NIF.ToString());

                        foreach (var element in reply.Apostas)
                            listViewChaves.Items.Add(element.NumeroAposta.ToString()).SubItems.AddRange(new string[] { element.Numeros, element.Estrelas, element.Premio.ToString(), element.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                        loopSucess = true;
                    }
                    else
                    {
                        //Estado -> false -> Operação correu mal
                        MessageBox.Show("Erro de Conexão ao server!", "Estado da Ligação:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }                
                }
                catch
                {
                    //Erro a conectar com o Servidor
                    loopAux++;
                    MessageBox.Show("Erro de Conexão ao server!", "Estado da Ligação:", MessageBoxButtons.OK);
                }
            }
            
        }
        /// <summary>
        /// Função disparada quando a View é totalmente carregada
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento  Load</param>
        private void AdminView_Load(object sender, EventArgs e)
        {
            //executar função ListLoader
            ListLoader();
        }

        /// <summary>
        /// Função disparada quando o administrador clicar no botão Arquivar e que é responsável por contactar o servidor para arquivar todas as
        /// apostas do sorteio ativo
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private async void buttonArquivar_Click(object sender, EventArgs e)
        {
            var loopAux = 0;
            var loopSucess = false;
            //em cada chamada ao servidor caso a primeira tentativa falhar são tentadas mais duas vezes
            while (loopAux < 3 && !loopSucess)
            {
                try
                {
                    //configurar ligação ao servidor
                    var httpHandler = new HttpClientHandler();
                    httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                    //criar cliente para acessar ao servidor
                    using var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                    var client = new ClienteAdministradorP.ClienteAdministradorPClient(channel);
                    //invocar função Arquivar implementada no servidor 
                    //reply = resposta do servidor
                    var reply = await client.ArquivarAsync(new Empty());
                    

                    if (reply.EstadoArquivo)
                    {
                        //Estado -> true -> Operação correu bem
                        MessageBox.Show("Apostas Arquivadas com sucesso!", "Estado da Aposta:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }
                    else
                    {
                        //Estado -> false -> Operação correu mal
                        MessageBox.Show("Não há apostas para arquivar!", "Estado da Aposta:", MessageBoxButtons.OK);
                        loopSucess = true;
                    }
                    //limpar lista
                    listViewChaves.Items.Clear();
                }
                catch
                {
                    //Erro a conectar com o Servidor
                    loopAux++;
                    MessageBox.Show("A operação não pode prosseguir por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }
            }
        }
    }
}
