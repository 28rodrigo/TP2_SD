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

namespace ClienteGestor
{
    public partial class GestorView : Form
    {
        private string Address;
        public GestorView()
        {
            InitializeComponent();
            Address = "";
        }

        public string ShowMyDialogBox()
        {
            DialogBoxIP testDialog = new DialogBoxIP();
            string text="";
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

        private async void buttonConfirmarRegisto_Click(object sender, EventArgs e)
        {
            int[] _numeros = new int[5];
            int[] _estrelas = new int[2];
            if (buttonConfirmarChave() == true)
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

                //comunicação com o server testar/enviar chave vencedora /receber vencedores
                try
                {
                    using var channel = GrpcChannel.ForAddress(Address);
                    var client = new ClienteGestorSorteioP.ClienteGestorSorteioPClient(channel);
                    var reply = await client.GerirSorteioAsync(
                        new Resultado
                        {
                            Numeros = { _numeros[0], _numeros[1], _numeros[2], _numeros[3], _numeros[4] },
                            Estrelas = { _estrelas[0], _estrelas[1] }
                        });
                    if (reply.Estado)
                    {
                        MessageBox.Show("Aposta subemetida com sucesso!", "Estado da Aposta:", MessageBoxButtons.OK);
                        foreach (var ele in reply.ApostasVencedoras)
                        {
                            listViewRAnteriores.Items.Add(ele.NumeroAposta.ToString()).SubItems.AddRange(new string[] { ele.NIF.ToString(), ele.Numeros, ele.Estrelas, ele.Premio.ToString()+"º", ele.DataAposta.ToDateTime().ToString("dd/MM/yyyy HH:mm") });
                        }
                    }
                    else MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("A aposta não pode ser subemetida por um erro de servidor!", "Estado da Aposta:", MessageBoxButtons.OK);
                }

            }
        }

        public bool buttonConfirmarChave()
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

        private void textBoxNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GestorView_Load(object sender, EventArgs e)
        {
            string PatternIp = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)$";
            string PatternPorta = @"^((6553[0-5])|(655[0-2][0-9])|(65[0-4][0-9]{2})|(6[0-4][0-9]{3})|([1-5][0-9]{4})|([0-5]{0,5})|([0-9]{1,4}))$";
            var RegTestIP = new Regex(PatternIp);
            var RegTestPort = new Regex(PatternPorta);
            var AUX = ShowMyDialogBox();
            string[] Auxiliar = AUX.Split(";");
            while ((RegTestIP.IsMatch(Auxiliar[0]) ==false) || (RegTestPort.IsMatch(Auxiliar[1]) == false))
            {
                AUX = ShowMyDialogBox();
                Auxiliar = AUX.Split(";");
            }
            Address = "http://" + Auxiliar[0] + ":" + Auxiliar[1];
        }
    }
}
