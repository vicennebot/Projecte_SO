using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PARCHIS_BUENO
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Barcelona_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Posicion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);
            
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

                if (Barcelona.Checked)
                {
                    string ciudad = Convert.ToString(textBox1.Text);
                    string mensaje = "1/" + ciudad;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("En esta ciudad han ganado los siguientes jugadores: " + mensaje);
                }
                if(Posicion.Checked)
                {
                    string username = Convert.ToString(textBox2.Text);
                    string mensaje = "2/" + username;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("El jugador " + username + " está en la posición: " + mensaje);


                }
                else
                {
                    int idpartida = Convert.ToInt32(textBox2.Text);
                    string mensaje = "3/" + idpartida;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("El ganador de la partida " + idpartida + " es: " + mensaje);

                }
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            catch(SocketException ex)
            {
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }


        }
    }
}
