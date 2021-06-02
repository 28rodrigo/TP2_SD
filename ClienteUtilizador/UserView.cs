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

namespace ClienteUtilizador
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            
        }

        private async Task buttonConfirmar_ClickAsync(object sender, EventArgs e)
        {
            var Reg = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            string NIF="";
            int[] _numeros = new int[5];
            int[] _estrelas = new int[2];
            if (textBoxNif.Text!=null && textBoxNif.Text != "" && (Reg.IsMatch(textBoxNif.Text) == true))
            {
                NIF = textBoxNif.Text;
                if (buttonConfirmarUnlock() == true)
                {
                    textBoxNum1.Text.ToInt32(_numeros[0]); // parseto
                    textBoxNum2.Text.ToString(_numeros[0]);
                    textBoxNum3.Text.ToString(_numeros[0]);
                    textBoxNum4.Text.ToString(_numeros[0]);
                    textBoxNum5.Text.ToString(_numeros[0]);
                    _estrelas[0] = textBoxEstrela1.Text; 
                    _estrelas[1] = textBoxEstrela2.Text;

                    //comunicação com o server testar/enviar
                    using var channel = GrpcChannel.ForAddress("https://localhost:5001");
                    var client = new ClienteUtilizadorP.ClienteUtilizadorPClient(channel);
                    var reply = await client.RegistarApostaAsync(
                                     new Aposta {
                                         NumeroApostador = NIF, 
                                         numeros = numeros,
                                         estrelas = 3;
                                        DataAposta = 4;
                });

                    MessageBox.Show("Valid Response!", "Sucesso", MessageBoxButtons.OK);
                }
            }
            else { MessageBox.Show("Por Favor Introduza um NIF Válido!", "Erro!", MessageBoxButtons.OK);}
        }

        public bool buttonConfirmarUnlock()
        {
            var RegNum1 = new Regex("[1-9]");
            var RegNum2 = new Regex("[1-4][0-9]|50");
            var RegEst1 = new Regex("[1-9]");
            var RegEst2 = new Regex("[1][0-2]");
            string[] numeros = new string[] { textBoxNum1.Text, textBoxNum2.Text, textBoxNum3.Text, textBoxNum4.Text, textBoxNum5.Text };
            string[] estrelas = new string[] { textBoxEstrela1.Text, textBoxEstrela2.Text };

            if (numeros[0] != null && numeros[1] != null && numeros[2] != null && numeros[3] != null && numeros[4] != null && estrelas[0] != null && estrelas[1] != null)
            {
                if (numeros[0] != "" && numeros[1] != "" && numeros[2] != "" && numeros[3] != "" && numeros[4] != "" && estrelas[0] != "" && estrelas[1] != "")
                {
                    if (((RegEst1.IsMatch(estrelas[0]) == true && estrelas[0].Length==1) || RegEst2.IsMatch(estrelas[0]) == true) && ((RegEst1.IsMatch(estrelas[1]) == true && estrelas[1].Length == 1) || RegEst2.IsMatch(estrelas[1]) == true) && ((RegNum1.IsMatch(numeros[0]) == true && numeros[0].Length == 1) || RegNum2.IsMatch(numeros[0]) == true) && ((RegNum1.IsMatch(numeros[1]) == true && numeros[1].Length == 1) || RegNum2.IsMatch(numeros[1]) == true) && ((RegNum1.IsMatch(numeros[2]) == true && numeros[2].Length == 1) || RegNum2.IsMatch(numeros[2]) == true) && ((RegNum1.IsMatch(numeros[3]) == true && numeros[3].Length == 1) || RegNum2.IsMatch(numeros[3]) == true) && ((RegNum1.IsMatch(numeros[4]) == true && numeros[4].Length == 1) || RegNum2.IsMatch(numeros[4]) == true))
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

        private async Task buttonConsultar_ClickAsync(object sender, EventArgs e)
        {
            var Reg = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            string NIF = "";

            if (textBoxNif.Text != null && textBoxNif.Text != "" && (Reg.IsMatch(textBoxNif.Text) == true))
            {
                NIF = textBoxNif.Text;

                //comunicação com o server testar/receber
                using var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new ClienteUtilizadorP.ClienteUtilizadorPClient(channel);
                var reply = await client.HistoricoApostasAsync(
                                 new PedidoHistorico { NumeroApostador = NIF });

                MessageBox.Show("Valid Response!", "Sucesso", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Por Favor Introduza um NIF Válido!", "Erro!", MessageBoxButtons.OK); }
        }
    }
}
