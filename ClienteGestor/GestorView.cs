using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClienteGestor
{
    public partial class GestorView : Form
    {
        public GestorView()
        {
            InitializeComponent();
        }

        private async void buttonConfirmarRegisto_Click(object sender, EventArgs e)
        {
            string[] numeros = new string[5];
            string[] estrelas = new string[2];
            if (buttonConfirmarChave() == true)
            {
                numeros[0] = textBoxNum1.Text;
                numeros[1] = textBoxNum2.Text;
                numeros[2] = textBoxNum3.Text;
                numeros[3] = textBoxNum4.Text;
                numeros[4] = textBoxNum5.Text;
                estrelas[0] = textBoxEstrela1.Text;
                estrelas[1] = textBoxEstrela2.Text;

                //comunicação com o server testar/enviar chave vencedora /receber vencedores

                MessageBox.Show("Valid Response!", "Sucesso", MessageBoxButtons.YesNo);
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
    }
}
