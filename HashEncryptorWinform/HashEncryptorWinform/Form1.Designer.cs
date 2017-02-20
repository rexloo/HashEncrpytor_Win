namespace HashEncryptorWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.mtbKey = new System.Windows.Forms.MaskedTextBox();
            this.tbResultHex = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbResultBase64 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(20, 29);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(157, 23);
            this.tbMsg.TabIndex = 0;
            this.tbMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMsg_KeyDown);
            // 
            // mtbKey
            // 
            this.mtbKey.Location = new System.Drawing.Point(20, 81);
            this.mtbKey.Name = "mtbKey";
            this.mtbKey.PasswordChar = '*';
            this.mtbKey.Size = new System.Drawing.Size(157, 23);
            this.mtbKey.TabIndex = 1;
            this.mtbKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbKey_KeyDown);
            // 
            // tbResultHex
            // 
            this.tbResultHex.Font = new System.Drawing.Font("Consolas", 9F);
            this.tbResultHex.Location = new System.Drawing.Point(197, 29);
            this.tbResultHex.Multiline = true;
            this.tbResultHex.Name = "tbResultHex";
            this.tbResultHex.ReadOnly = true;
            this.tbResultHex.Size = new System.Drawing.Size(157, 56);
            this.tbResultHex.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Consolas", 9F);
            this.tbPassword.Location = new System.Drawing.Point(198, 183);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(156, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hash Result Hex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(20, 119);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(157, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(20, 151);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(157, 23);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbResultBase64
            // 
            this.tbResultBase64.Font = new System.Drawing.Font("Consolas", 9F);
            this.tbResultBase64.Location = new System.Drawing.Point(197, 106);
            this.tbResultBase64.Multiline = true;
            this.tbResultBase64.Name = "tbResultBase64";
            this.tbResultBase64.ReadOnly = true;
            this.tbResultBase64.Size = new System.Drawing.Size(157, 56);
            this.tbResultBase64.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hash Result Base64";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Maximum = 45;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(74, 16);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(297, 17);
            this.toolStripStatusLabel1.Text = "Log: ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 246);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbResultBase64);
            this.Controls.Add(this.tbResultHex);
            this.Controls.Add(this.mtbKey);
            this.Controls.Add(this.tbMsg);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hash Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.MaskedTextBox mtbKey;
        private System.Windows.Forms.TextBox tbResultHex;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbResultBase64;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

