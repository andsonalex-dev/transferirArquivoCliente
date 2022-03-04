namespace TransferirArquivoCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPortaHost = new System.Windows.Forms.NumericUpDown();
            this.txtArquivo = new System.Windows.Forms.LinkLabel();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente para compartilhamento com servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip do servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porta do servidor";
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(19, 97);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(155, 20);
            this.txtEnderecoIP.TabIndex = 3;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPortaHost
            // 
            this.txtPortaHost.Location = new System.Drawing.Point(186, 96);
            this.txtPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPortaHost.Name = "txtPortaHost";
            this.txtPortaHost.Size = new System.Drawing.Size(84, 20);
            this.txtPortaHost.TabIndex = 4;
            this.txtPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtArquivo
            // 
            this.txtArquivo.AutoSize = true;
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(16, 139);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(187, 16);
            this.txtArquivo.TabIndex = 5;
            this.txtArquivo.TabStop = true;
            this.txtArquivo.Text = "Selecionar arquivo para envio";
            this.txtArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArquivo_LinkClicked);
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarArquivo.Location = new System.Drawing.Point(16, 158);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarArquivo.TabIndex = 6;
            this.btnEnviarArquivo.Text = "Enviar";
            this.btnEnviarArquivo.UseVisualStyleBackColor = false;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Yellow;
            this.labelStatus.Location = new System.Drawing.Point(14, 230);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(414, 183);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtPortaHost);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Transferir Arquivo Web Socket";
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.NumericUpDown txtPortaHost;
        private System.Windows.Forms.LinkLabel txtArquivo;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.Label labelStatus;
    }
}

