
namespace Aplicacion_de_prueba_serial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Diseñopuerto = new System.Windows.Forms.Label();
            this.BotonConectar = new System.Windows.Forms.Button();
            this.BotonDesconectar = new System.Windows.Forms.Button();
            this.CmBoxLista = new System.Windows.Forms.ComboBox();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.TxBxDatoRecibido = new System.Windows.Forms.TextBox();
            this.TxBxEnviado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Diseñopuerto
            // 
            this.Diseñopuerto.AutoSize = true;
            this.Diseñopuerto.Location = new System.Drawing.Point(12, 9);
            this.Diseñopuerto.Name = "Diseñopuerto";
            this.Diseñopuerto.Size = new System.Drawing.Size(0, 13);
            this.Diseñopuerto.TabIndex = 0;
            // 
            // BotonConectar
            // 
            this.BotonConectar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonConectar.Location = new System.Drawing.Point(174, 23);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(103, 23);
            this.BotonConectar.TabIndex = 1;
            this.BotonConectar.Text = "Conectar";
            this.BotonConectar.UseVisualStyleBackColor = false;
            this.BotonConectar.Click += new System.EventHandler(this.BotonConectar_Click);
            // 
            // BotonDesconectar
            // 
            this.BotonDesconectar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonDesconectar.Location = new System.Drawing.Point(283, 23);
            this.BotonDesconectar.Name = "BotonDesconectar";
            this.BotonDesconectar.Size = new System.Drawing.Size(105, 23);
            this.BotonDesconectar.TabIndex = 2;
            this.BotonDesconectar.Text = "Desconectar";
            this.BotonDesconectar.UseVisualStyleBackColor = false;
            this.BotonDesconectar.Click += new System.EventHandler(this.BotonDesconectar_Click);
            // 
            // CmBoxLista
            // 
            this.CmBoxLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmBoxLista.FormattingEnabled = true;
            this.CmBoxLista.Location = new System.Drawing.Point(3, 25);
            this.CmBoxLista.Name = "CmBoxLista";
            this.CmBoxLista.Size = new System.Drawing.Size(165, 21);
            this.CmBoxLista.TabIndex = 4;
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // TxBxDatoRecibido
            // 
            this.TxBxDatoRecibido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxBxDatoRecibido.Location = new System.Drawing.Point(15, 88);
            this.TxBxDatoRecibido.Multiline = true;
            this.TxBxDatoRecibido.Name = "TxBxDatoRecibido";
            this.TxBxDatoRecibido.Size = new System.Drawing.Size(151, 81);
            this.TxBxDatoRecibido.TabIndex = 6;
            // 
            // TxBxEnviado
            // 
            this.TxBxEnviado.Location = new System.Drawing.Point(220, 88);
            this.TxBxEnviado.Multiline = true;
            this.TxBxEnviado.Name = "TxBxEnviado";
            this.TxBxEnviado.Size = new System.Drawing.Size(154, 81);
            this.TxBxEnviado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enviado";
            // 
            // boton_enviar
            // 
            this.boton_enviar.Location = new System.Drawing.Point(245, 175);
            this.boton_enviar.Name = "boton_enviar";
            this.boton_enviar.Size = new System.Drawing.Size(107, 23);
            this.boton_enviar.TabIndex = 10;
            this.boton_enviar.Text = "Enviar";
            this.boton_enviar.UseVisualStyleBackColor = true;
            this.boton_enviar.Click += new System.EventHandler(this.boton_enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recibido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_enviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxBxEnviado);
            this.Controls.Add(this.TxBxDatoRecibido);
            this.Controls.Add(this.CmBoxLista);
            this.Controls.Add(this.BotonDesconectar);
            this.Controls.Add(this.BotonConectar);
            this.Controls.Add(this.Diseñopuerto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Diseñopuerto;
        private System.Windows.Forms.Button BotonConectar;
        private System.Windows.Forms.Button BotonDesconectar;
        private System.Windows.Forms.ComboBox CmBoxLista;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.TextBox TxBxDatoRecibido;
        private System.Windows.Forms.TextBox TxBxEnviado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_enviar;
        private System.Windows.Forms.Label label1;
    }
}

