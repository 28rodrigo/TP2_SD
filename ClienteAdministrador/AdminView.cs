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
            listViewChaves.Items.Clear();
            try
            {
                //configurar ligação ao servidor
                var httpHandler = new HttpClientHandler();
                httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                //criar cliente para acessar ao servidor
                var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                var client = new ClienteAdministradorP.ClienteAdministradorPClient(channel);
                //invocar função Consultar implementada no servidor 
                //reply = resposta do servidor
                var reply = await client.ConsultarAsync(new Empty());
                if (reply.Estado)
                {
                    //Estado -> true -> Operação correu bem
                    //atualizar ListView's
                    foreach (var element in reply.Apostas)
                    {
                        //teste para, caso premio = 0 => Sem prémio
                        string premio="";
                        if (element.Premio == 0) { premio = "Sem Prémio"; }
                        else { premio = element.Premio.ToString() + "º"; }
                        listViewChaves.Items.Add(element.NumeroAposta.ToString()).SubItems.AddRange(new string[] { element.NumeroApostador.ToString(), element.Numeros, element.Estrelas, premio, element.DataAposta.ToDateTime().ToLocalTime().ToString("dd/MM/yyyy HH:mm") });
                    }
                    listViewChaves.Show();
                    buttonArquivar.Enabled = true;
                }
                else
                {
                    //Estado -> false -> Sem Chaves para arquivar
                    MessageBox.Show("Não há chaves a arquivar!", "Estado:", MessageBoxButtons.OK);
                    buttonArquivar.Enabled = false;
                    listViewChaves.Hide();
                }                
            }
            catch
            {
                //Erro a conectar com o Servidor
                MessageBox.Show("Erro de Conexão ao server!", "Estado da Ligação:", MessageBoxButtons.OK);
            }   
        }
        /// <summary>
        /// Função disparada quando a View é totalmente carregada
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>e</c>referencia ao evento  Load</param>
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
        /// <param><c>e</c>referencia ao evento Click</param>
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
                    //criar cliente para acessar ao servidor
                    var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
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

        /// <summary>
        /// Função disparada quando o botão "Atualizar Tabela" (buttonRefresh) é clicado
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>e</c>referencia ao evento Click</param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //executar função ListLoader
            ListLoader();
        }
    }
}
