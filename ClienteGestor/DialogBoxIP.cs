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
            var AUXPORT= textBoxPort.Text;
            //string[] Auxiliar = AUX.Split(";");
            if ((RegTestIP.IsMatch(AUXIP) == false) || (RegTestPort.IsMatch(AUXPORT) == false))
            {
                MessageBox.Show("Números/Estrelas Repetidos!", "Erro!", MessageBoxButtons.OK);
                return;
            }
            Address = "http://" + AUXIP + ":" + AUXPORT;
            GestorView gestorView = new GestorView(Address);
            gestorView.FormClosed += new FormClosedEventHandler(gestorView_FormClosed);
            gestorView.Show();

            // Since this.Hide() for some reason doesn't work, i'll have to do this crap
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
           
        }
        private void gestorView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
