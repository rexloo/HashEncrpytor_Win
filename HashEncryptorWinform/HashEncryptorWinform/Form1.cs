using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HashEncryptorWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int TimeEscaped;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbMsg.Focus();
            this.toolStripStatusLabel1.Text = "Log: Programme ready.";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.btnCopy.Enabled = true;
            HashEncrypt he = new HashEncrypt(this.tbMsg.Text, this.mtbKey.Text);
            he.RunEncrypt();
            this.tbResultHex.Text = he.ResultHex;
            this.tbResultBase64.Text = he.ResultBase64;
            this.tbPassword.Text = (he.GetPassword());
            this.toolStripStatusLabel1.Text = "Log: Secured password has been generated.";
            TimeEscaped = 0;
            timer1.Enabled = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            btnCopy.Enabled = false;
            Clipboard.SetText(this.tbPassword.Text);
            this.tbResultHex.Clear();
            this.tbResultBase64.Clear();
            this.tbPassword.Clear();
            this.toolStripStatusLabel1.Text = "Log: Password has been copied to clipboard.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbMsg.Clear();
            this.mtbKey.Clear();
            this.tbResultHex.Clear();
            this.tbResultBase64.Clear();
            this.tbPassword.Clear();
            Clipboard.Clear();
            this.btnCopy.Enabled = false;
            this.toolStripStatusLabel1.Text = "Log: Programme has been reset.";
            this.timer1.Enabled = false;
            this.toolStripProgressBar1.Value = 0;
        }

        private void tbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.mtbKey.Focus();
            }
        }

        private void mtbKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnEncrypt_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeEscaped < toolStripProgressBar1.Maximum)
            {
                TimeEscaped++;
                this.toolStripProgressBar1.Value = TimeEscaped;
            }
            else
            {
                this.btnClear_Click(sender, e);
                this.toolStripProgressBar1.Value = 0;
                this.timer1.Enabled = false;
            }
        }
    }
}
