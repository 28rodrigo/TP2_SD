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
    public partial class DialogBoxIP : Form
    {
        public DialogBoxIP()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Função disparada quando é clicado o botão Cancel que fecha a Aplicação
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Função disparada quando o utilizador clica no botão OK e que é responsável por testar o formato/Padrão dos dados 
        /// inseridos(IP e Porta) para assegurar que dados são válidos e caso sejam válidos rederecionar para a proxima View
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Click</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string Address;
            string PatternIp = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)$";
            string PatternPorta = @"^((6553[0-5])|(655[0-2][0-9])|(65[0-4][0-9]{2})|(6[0-4][0-9]{3})|([1-5][0-9]{4})|([0-5]{0,5})|([0-9]{1,4}))$";
            var RegTestIP = new Regex(PatternIp);
            var RegTestPort = new Regex(PatternPorta);
            var AUXIP = textBoxIP.Text;
            var AUXPORT= textBoxPort.Text;
            //string[] Auxiliar = AUX.Split(";");
            if ((RegTestIP.IsMatch(AUXIP) == false) || (RegTestPort.IsMatch(AUXPORT) == false))
            {
                //ip e/ou porto são inválidos
                MessageBox.Show("Ip e/ou Porta são inválidos!", "Erro!", MessageBoxButtons.OK);
                return;
            }
            //definir address de ligação
            Address = "http://" + AUXIP + ":" + AUXPORT;
            //Chamar uma nova gestorView -> View Principal deste cliente
            GestorView gestorView = new GestorView(Address);
            gestorView.FormClosed += new FormClosedEventHandler(gestorView_FormClosed);
            gestorView.Show();

            // Esconder esta página
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
           
        }
        /// <summary>
        /// Função necessária para assegurar que quando Aplicação é fechada esta view é tambem fechada.
        /// </summary>
        /// <param><c>sender</c>referencia ao objeto que disparou esta função</param>
        /// <param><c>er</c>referencia ao evento Close</param>
        private void gestorView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
