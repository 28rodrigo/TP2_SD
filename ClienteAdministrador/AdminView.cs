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
                        //var ApostasAtivas = _dbcontext.Apostas.Include("Chave").Where(element => element.Arquivada == false).ToList();
                        //foreach (var ele in reply.Utilizadores.ToList())
                        //{
                        //    listViewUtilizadores.Items.Add(ele.Utilizadores);
                        //}
                        //foreach (var ele in reply.Apostas)
                        //{
                        //    listViewChaves.Items.Add(ele.Apostas.SubItems.AddRange(new string[] { ele.Numeros, ele.Estrelas, ele.Premio.ToString(), ele.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                        //}
                        foreach (var element in reply.Utilizadores)
                            listViewUtilizadores.Items.Add(element.NIF.ToString());

                        foreach (var element in reply.Apostas)
                            listViewChaves.Items.Add(element.NumeroAposta.ToString()).SubItems.AddRange(new string[] { element.Numeros, element.Estrelas, element.Premio.ToString(), element.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });

                    }
                    else MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }
                catch
                {
                    loopAux++;
                    MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }
            }
            
        }

        public string ShowMyDialogBox()
        {
            DialogIpBox testDialog = new DialogIpBox();
            string text = "";
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            try
            {
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Read the contents of testDialog's TextBox.
                    text = testDialog.textBoxIP.Text + ";" + testDialog.textBoxPort.Text;
                }
                else
                {
                    text = "";
                }
            }
            catch
            {
                System.Environment.Exit(1);
            }
            testDialog.Dispose();
            return text;
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

           


            //buscar dados á base de dados
            ListLoader();

        }

        private void buttonArquivar_Click(object sender, EventArgs e)
        {

        }
    }
}
