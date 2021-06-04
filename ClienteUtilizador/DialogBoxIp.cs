using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClienteUtilizador
{
    public partial class DialogBoxIp : Form
    {
        public DialogBoxIp()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string Address;
            string PatternIp = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]?)$";
            string PatternPorta = @"^((6553[0-5])|(655[0-2][0-9])|(65[0-4][0-9]{2})|(6[0-4][0-9]{3})|([1-5][0-9]{4})|([0-5]{0,5})|([0-9]{1,4}))$";
            var RegTestIP = new Regex(PatternIp);
            var RegTestPort = new Regex(PatternPorta);
            var AUXIP = textBoxIP.Text;
            var AUXPORT = textBoxPort.Text;
            //string[] Auxiliar = AUX.Split(";");
            if ((RegTestIP.IsMatch(AUXIP) == false) || (RegTestPort.IsMatch(AUXPORT) == false))
            {
                MessageBox.Show("Números/Estrelas Repetidos!", "Erro!", MessageBoxButtons.OK);
                return;
            }
            Address = "http://" + AUXIP + ":" + AUXPORT;
            UserView userView = new UserView(Address);
            userView.FormClosed += new FormClosedEventHandler(userView_FormClosed);
            userView.Show();

            // Since this.Hide() for some reason doesn't work, i'll have to do this crap
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        private void userView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
