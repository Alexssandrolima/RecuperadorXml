namespace RecuperadorXML
{
    partial class FormPrincipal
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
            this.buttonDownloadXml = new System.Windows.Forms.Button();
            this.buttonNovaConsulta = new System.Windows.Forms.Button();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.textBoxChaveNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDigitarCaptcha = new System.Windows.Forms.TextBox();
            this.labelDigitarDados = new System.Windows.Forms.Label();
            this.buttonTratarXml = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDownloadXml
            // 
            this.buttonDownloadXml.Location = new System.Drawing.Point(220, 112);
            this.buttonDownloadXml.Name = "buttonDownloadXml";
            this.buttonDownloadXml.Size = new System.Drawing.Size(207, 23);
            this.buttonDownloadXml.TabIndex = 0;
            this.buttonDownloadXml.Text = "Download XML";
            this.buttonDownloadXml.UseVisualStyleBackColor = true;
            this.buttonDownloadXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNovaConsulta
            // 
            this.buttonNovaConsulta.Location = new System.Drawing.Point(12, 112);
            this.buttonNovaConsulta.Name = "buttonNovaConsulta";
            this.buttonNovaConsulta.Size = new System.Drawing.Size(202, 23);
            this.buttonNovaConsulta.TabIndex = 1;
            this.buttonNovaConsulta.Text = "Nova Consulta";
            this.buttonNovaConsulta.UseVisualStyleBackColor = true;
            this.buttonNovaConsulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(12, 50);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(181, 50);
            this.pictureBoxCaptcha.TabIndex = 4;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // textBoxChaveNota
            // 
            this.textBoxChaveNota.Location = new System.Drawing.Point(12, 22);
            this.textBoxChaveNota.Name = "textBoxChaveNota";
            this.textBoxChaveNota.Size = new System.Drawing.Size(415, 20);
            this.textBoxChaveNota.TabIndex = 5;
            this.textBoxChaveNota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número da nota ";
            // 
            // textBoxDigitarCaptcha
            // 
            this.textBoxDigitarCaptcha.Location = new System.Drawing.Point(237, 50);
            this.textBoxDigitarCaptcha.Name = "textBoxDigitarCaptcha";
            this.textBoxDigitarCaptcha.Size = new System.Drawing.Size(184, 20);
            this.textBoxDigitarCaptcha.TabIndex = 7;
            this.textBoxDigitarCaptcha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelDigitarDados
            // 
            this.labelDigitarDados.AutoSize = true;
            this.labelDigitarDados.Location = new System.Drawing.Point(273, 87);
            this.labelDigitarDados.Name = "labelDigitarDados";
            this.labelDigitarDados.Size = new System.Drawing.Size(107, 13);
            this.labelDigitarDados.TabIndex = 8;
            this.labelDigitarDados.Text = "Digite o valor ao lado";
            // 
            // buttonTratarXml
            // 
            this.buttonTratarXml.Location = new System.Drawing.Point(433, 22);
            this.buttonTratarXml.Name = "buttonTratarXml";
            this.buttonTratarXml.Size = new System.Drawing.Size(115, 113);
            this.buttonTratarXml.TabIndex = 9;
            this.buttonTratarXml.Text = "Tratar XML";
            this.buttonTratarXml.UseVisualStyleBackColor = true;
            this.buttonTratarXml.Click += new System.EventHandler(this.button3_Click);
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(9999, 141);
            this.page.MinimumSize = new System.Drawing.Size(20, 20);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(20, 20);
            this.page.TabIndex = 2;
            this.page.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Load_Captcha);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 139);
            this.Controls.Add(this.buttonTratarXml);
            this.Controls.Add(this.labelDigitarDados);
            this.Controls.Add(this.textBoxDigitarCaptcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChaveNota);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.page);
            this.Controls.Add(this.buttonNovaConsulta);
            this.Controls.Add(this.buttonDownloadXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "Recuperador nf-e";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownloadXml;
        private System.Windows.Forms.Button buttonNovaConsulta;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.TextBox textBoxChaveNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDigitarCaptcha;
        private System.Windows.Forms.Label labelDigitarDados;
        private System.Windows.Forms.Button buttonTratarXml;
        private System.Windows.Forms.WebBrowser page;
    }
}

