using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net.Http;


namespace ClienteGestor
{
    public partial class GestorView : Form
    {
        //parametro de Entrada - Address de ligação ao servidor
        private string Address;
        public GestorView(string _Address)
        {
            InitializeComponent();
            Address = _Address;
        }

        /// <summary>
        /// Função disparada quando o gestor clicar no botão Registar e que é responsável por contactar o servidor para receber toda as
        /// apostas vencedoras 
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private async void buttonConfirmarRegisto_Click(object sender, EventArgs e)
        {
            int[] _numeros = new int[5];
            int[] _estrelas = new int[2];
            //verificar validade da chave
            if (buttonConfirmarChave() == true)
            {
                //converter string -> inteiro
                _numeros[0] = Int32.Parse(textBoxNum1.Text);
                _numeros[1] = Int32.Parse(textBoxNum2.Text);
                _numeros[2] = Int32.Parse(textBoxNum3.Text);
                _numeros[3] = Int32.Parse(textBoxNum4.Text);
                _numeros[4] = Int32.Parse(textBoxNum5.Text);
                Array.Sort(_numeros);
                _estrelas[0] = Int32.Parse(textBoxEstrela1.Text);
                _estrelas[1] = Int32.Parse(textBoxEstrela2.Text);
                Array.Sort(_estrelas);

                //em cada chamada ao servidor caso a primeira tentativa falhar são tentadas mais duas vezes
                var loopAux = 0;
                var loopSucess = false;
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
                        var _client = new ClienteGestorSorteioP.ClienteGestorSorteioPClient(channel);
                        //invocar função GerirSorteio implementada no servidor 
                        //reply = resposta do servidor
                        var reply = await _client.GerirSorteioAsync(
                            //definir parametros de entrada 
                            new Resultado
                            {
                                Numeros = { _numeros[0], _numeros[1], _numeros[2], _numeros[3], _numeros[4] },
                                Estrelas = { _estrelas[0], _estrelas[1] }
                            });
                        if (reply.Estado)
                        {
                            //Estado -> true -> Operação correu bem
                            //atualizar ListView
                            foreach (var ele in reply.ApostasVencedoras)
                            {
                                listViewRAnteriores.Items.Add(ele.NumeroAposta.ToString()).SubItems.AddRange(new string[] { ele.NIF.ToString(), ele.Numeros, ele.Estrelas, ele.Premio.ToString() + "º", ele.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                            }
                            
                            MessageBox.Show("Aposta subemetida com sucesso!", "Estado da Aposta:", MessageBoxButtons.OK);
                            loopSucess = true;
                            
                        }
                        else
                        {
                            //Estado -> frue -> Operação correu ~mal
                            loopSucess = true;
                            MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                        } 
                    }
                    catch
                    {
                        //Erro a conectar com o Servidor
                        loopAux++;
                        MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                    }
                }

            }
        }
        /// <summary>
        /// Função responsável por testar o formato/Padrão dos dados inseridos(Numeros e Estrelas) para assegurar que dados enviados para o servidor
        /// são válidos
        /// </summary>
        /// <returns>false -> Dados inseridos são inválidos ; true-> Dados inseridos são válidos</returns>
        public bool buttonConfirmarChave()
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
            else { MessageBox.Show("Números/Estrelas Por Preencher!", "Erro!", MessageBoxButtons.OK); return false; }
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
