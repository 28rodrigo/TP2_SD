using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace ClienteUtilizador
{
    public partial class UserView : Form
    {
        //parametro de Entrada - Address de ligação ao servidor
        private string Address;
        public UserView(string _Address)
        {
            InitializeComponent();
            Address = _Address;
        }

        /// <summary>
        /// Função responsável por testar o formato/Padrão dos dados inseridos(Numeros e Estrelas) para assegurar que dados enviados para o servidor
        /// são válidos
        /// </summary>
        /// <returns>false -> Dados inseridos são inválidos ; true-> Dados inseridos são válidos</returns>
        private bool buttonConfirmarUnlock()
        {
            //Expressoes regulares para testar inputs
            var RegNum1 = new Regex("[1-9]");
            var RegNum2 = new Regex("[1-4][0-9]|50");
            var RegEst1 = new Regex("[1-9]");
            var RegEst2 = new Regex("[1][0-2]");
            string[] numeros = new string[] { textBoxNum1.Text, textBoxNum2.Text, textBoxNum3.Text, textBoxNum4.Text, textBoxNum5.Text };
            string[] estrelas = new string[] { textBoxEstrela1.Text, textBoxEstrela2.Text };

            //verificar se numeros e estrelas são repetidos,se falta algum valor ou se são inválidos
            if (numeros[0] != null && numeros[1] != null && numeros[2] != null && numeros[3] != null && numeros[4] != null && estrelas[0] != null && estrelas[1] != null)
            {
                if (numeros[0] != "" && numeros[1] != "" && numeros[2] != "" && numeros[3] != "" && numeros[4] != "" && estrelas[0] != "" && estrelas[1] != "")
                {
                    if (((RegEst1.IsMatch(estrelas[0]) == true && estrelas[0].Length == 1) || RegEst2.IsMatch(estrelas[0]) == true) && ((RegEst1.IsMatch(estrelas[1]) == true && estrelas[1].Length == 1) || RegEst2.IsMatch(estrelas[1]) == true) && ((RegNum1.IsMatch(numeros[0]) == true && numeros[0].Length == 1) || RegNum2.IsMatch(numeros[0]) == true) && ((RegNum1.IsMatch(numeros[1]) == true && numeros[1].Length == 1) || RegNum2.IsMatch(numeros[1]) == true) && ((RegNum1.IsMatch(numeros[2]) == true && numeros[2].Length == 1) || RegNum2.IsMatch(numeros[2]) == true) && ((RegNum1.IsMatch(numeros[3]) == true && numeros[3].Length == 1) || RegNum2.IsMatch(numeros[3]) == true) && ((RegNum1.IsMatch(numeros[4]) == true && numeros[4].Length == 1) || RegNum2.IsMatch(numeros[4]) == true))
                    {
                        if (numeros[0] != numeros[1] && numeros[0] != numeros[2] && numeros[0] != numeros[3] && numeros[0] != numeros[4] && numeros[1] != numeros[2] && numeros[1] != numeros[3] && numeros[1] != numeros[4] && numeros[2] != numeros[3] && numeros[2] != numeros[4] && numeros[3] != numeros[4] && estrelas[0] != estrelas[1])
                        {
                            return true;
                        }
                        else { MessageBox.Show("Números/Estrelas Repetidos!", "Erro!", MessageBoxButtons.OK); return false; }
                    }
                    else { MessageBox.Show("Números/Estrelas Inválidos!", "Erro!", MessageBoxButtons.OK); return false; }
                }
                else { MessageBox.Show("Números/Estrelas Por Preencher!", "Erro!", MessageBoxButtons.OK); return false; }
            }
            else
            { MessageBox.Show("Números/Estrelas Por Preencher!", "Erro!", MessageBoxButtons.OK); return false; }
        }

        /// <summary>
        /// Função disparada quando o utlizador clica no botão de consultar que é responsável por contactar o servidor para receber toda as
        /// apostas realizadas de um determinado Utilizador
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private async void buttonConsultar_Click(object sender, EventArgs e)
        {   
            //verificar NIF
            var Reg = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            int NIF = 0;
            //em cada chamada ao servidor caso a primeira tentativa falhar são tentadas mais duas vezes
            var loopAux = 0;
            try
            {
                if (textBoxNif.Text.Count() == 9 && (Reg.IsMatch(textBoxNif.Text) == true))
                {
                    //parse NIF para inteiro
                    NIF = Int32.Parse(textBoxNif.Text);
                    //limpar listView onde é representado o histórico
                    listViewRAnteriores.Items.Clear();

                    //configurar ligação ao servidor
                    var httpHandler = new HttpClientHandler();
                    httpHandler.ServerCertificateCustomValidationCallback =HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    //criar cliente para acessar ao servidor
                    var channel = GrpcChannel.ForAddress(Address,new GrpcChannelOptions { HttpHandler = httpHandler });
                    var client = new ClienteUtilizadorP.ClienteUtilizadorPClient(channel);
                    //invocar função HistoricoApostas, implementada no servidor 
                    //reply = resposta do servidor
                    var reply = await client.HistoricoApostasAsync(new PedidoHistorico { NumeroApostador = NIF });
                    if (reply.Estado)
                    {
                        //Estado -> True -> Operação correu bem
                        foreach (var ele in reply.HistoricoApostas)
                        {
                            //teste para, caso premio = 0 => Sem prémio
                            string premio = "";
                            if (ele.Premio == 0) { premio = "Sem Prémio"; }
                            else { premio = ele.Premio.ToString() + "º"; }
                            listViewRAnteriores.Items.Add(ele.NumeroAposta.ToString()).SubItems.AddRange(new string[] { ele.Numeros, ele.Estrelas, premio, ele.DataAposta.ToDateTime().ToLocalTime().ToString("dd/MM/yyyy HH:mm") });
                        }
                        MessageBox.Show("Sucesso!", "Estado do Pedido:", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Estado -> False -> Operação correu mal
                        MessageBox.Show("O Pedido não pode ser retornado por um erro de servidor ou o Nif não existe!", "Estado do Pedido:", MessageBoxButtons.OK); 
                    }
                       
                }      //NIF Inválido 
                else { MessageBox.Show("Por Favor Introduza um NIF Válido!", "Erro!", MessageBoxButtons.OK); }
            }
            catch
            {
                //Erro a conectar com o Servidor
                loopAux++;
                MessageBox.Show("O Pedido não pode ser retornado por um erro de ligação aoservidor!", "Estado do Pedido:", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Função disparada quando o utlizador clica no botão de registar aposta que é responsável por contactar o servidor para registar uma aposta
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private async void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //verificar NIF
            var Reg = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            int NIF = 0;
            int[] _numeros = new int[5];
            int[] _estrelas = new int[2];
            if (textBoxNif.Text.Count() == 9 && (Reg.IsMatch(textBoxNif.Text) == true))
            {
                //Parse de string para inteiro
                try
                {
                    NIF = Int32.Parse(textBoxNif.Text);
                    if (buttonConfirmarUnlock())
                    {
                        _numeros[0] = Int32.Parse(textBoxNum1.Text);
                        _numeros[1] = Int32.Parse(textBoxNum2.Text);
                        _numeros[2] = Int32.Parse(textBoxNum3.Text);
                        _numeros[3] = Int32.Parse(textBoxNum4.Text);
                        _numeros[4] = Int32.Parse(textBoxNum5.Text);
                        Array.Sort(_numeros);
                        _estrelas[0] = Int32.Parse(textBoxEstrela1.Text);
                        _estrelas[1] = Int32.Parse(textBoxEstrela2.Text);
                        Array.Sort(_estrelas);

                        //configurar ligação ao servidor
                        var httpHandler = new HttpClientHandler();
                        httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                        //criar cliente para acessar ao servidor
                        var channel = GrpcChannel.ForAddress(Address, new GrpcChannelOptions { HttpHandler = httpHandler });
                        var client = new ClienteUtilizadorP.ClienteUtilizadorPClient(channel);
                        //invocar função RegistarAposta implementada no servidor 
                        //reply = resposta do servidor
                        var reply = await client.RegistarApostaAsync(
                            new Aposta
                            {
                                NumeroApostador = NIF,
                                Numeros = { _numeros[0], _numeros[1], _numeros[2], _numeros[3], _numeros[4] },
                                Estrelas = { _estrelas[0], _estrelas[1] },
                                DataAposta = Timestamp.FromDateTime(DateTime.UtcNow)
                            });
                        if (reply.Estado)
                        {
                            //Estado -> True -> Operação correu bem
                            MessageBox.Show("Aposta subemetida com sucesso!", "Estado da Aposta:", MessageBoxButtons.OK);
                        }
                        else
                        {
                            //Estado -> False -> Operação correu mal
                            MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                        }
                    }
                }
                catch
                {
                    //Erro a conectar com o Servidor
                    MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }    
            }
            else { MessageBox.Show("Por Favor Introduza um NIF Válido!", "Erro!", MessageBoxButtons.OK); }
        }
        /// <summary>
        /// Função disparada quando uma tecla é primida para assegurar que apenas são permitidos numeros nos inputs
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento  KeyPress</param>
        private void textBoxNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}