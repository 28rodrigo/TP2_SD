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
        public AdminView()
        {
            InitializeComponent();
            Address = "";
        }

        public async void ListLoader()
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
                    var ApostasAtivas = _dbcontext.Apostas.Include("Chave").Where(element => element.Arquivada == false).ToList();
                    foreach (var ele in reply.Utilizadores.ToList())
                    {
                        listViewUtilizadores.Items.Add(ele.Utilizadores);
                    }
                    foreach (var ele in reply.Apostas)
                    {
                        listViewChaves.Items.Add(ele.Apostas.SubItems.AddRange(new string[] { ele.Numeros, ele.Estrelas, ele.Premio.ToString(), ele.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                    }
                }
                else MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
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
            string PatternIp = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)$";
            string PatternPorta = @"^((6553[0-5])|(655[0-2][0-9])|(65[0-4][0-9]{2})|(6[0-4][0-9]{3})|([1-5][0-9]{4})|([0-5]{0,5})|([0-9]{1,4}))$";
            var RegTestIP = new Regex(PatternIp);
            var RegTestPort = new Regex(PatternPorta);
            var AUX = ShowMyDialogBox();
            string[] Auxiliar = AUX.Split(";");
            while ((RegTestIP.IsMatch(Auxiliar[0]) == false) || (RegTestPort.IsMatch(Auxiliar[1]) == false))
            {
                AUX = ShowMyDialogBox();
                Auxiliar = AUX.Split(";");
            }
            Address = "http://" + Auxiliar[0] + ":" + Auxiliar[1];
        }
    }
}
