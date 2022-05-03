using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_de_prueba_serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Desctivamos la transmicion de datos entre hilos
            //Agregamos imagen 
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerPuertos();
            BotonConectar.Enabled = true;
            BotonDesconectar.Enabled = false;
        }
        
        public void ObtenerPuertos()
        {
            string[] ListaPuertos = System.IO.Ports.SerialPort.GetPortNames(); //Retorna arreglo string que se llame lista piuertos
            CmBoxLista.DataSource = ListaPuertos; //Sacamos la informacion 
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
            }

        }
        private void BotonRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerPuertos();
        }

        //Funcion de evento para conectar el ´Puerto serie que te aparezca en la ventana
        private void BotonConectar_Click(object sender, EventArgs e)
        {
            if (!PuertoSerie.IsOpen)
            {
                //Coenctamos el nombre del puerto seleccionado en el combo box  (Osea que aparezca el puerto serie en el seleccionador del combo box [COM3])
                PuertoSerie.PortName = CmBoxLista.SelectedItem.ToString(); 
                //Abrimos el puerto serie
                PuertoSerie.Open();
                //Damos opciones de conectar o desconectar, 
                BotonConectar.Enabled = false;
                BotonDesconectar.Enabled = true;
            }
            
        }
        //Funcion de evento para descoenctar el ´Puerto serie que te aparezca en la ventana
        private void BotonDesconectar_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
                //Cerramos el puerto serie
                PuertoSerie.Close();
                //Damos opciones de conectar o desconectar, 
                BotonConectar.Enabled = true;
                BotonDesconectar.Enabled = false;
            }
        }

        //Manipulamos el Hardwere de nuestro equipo
        private void PuertoSerie_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Guardamos lo recibido en el Puerto serie para que se lea en la texbox
            if (PuertoSerie.IsOpen)
            {
                string datos_puerto = PuertoSerie.ReadLine();
                TxBxDatoRecibido.Text = datos_puerto;
            }
        }

        //Funcion de eventoi para el boton enviar
        private void boton_enviar_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
                string datos_enviar = TxBxEnviado.Text;
                PuertoSerie.WriteLine(datos_enviar);
                TxBxEnviado.Text = "";
            }
        }
    }
}
