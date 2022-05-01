using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Juego
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;

        delegate void DelegadoParaEscribir(string mensaje);

        public Form1()
        {
            InitializeComponent();
            psswd.PasswordChar = '*';
            psswd.MaxLength = 20;
            password.PasswordChar = '*';
            password.MaxLength = 20;
            Cpassword.PasswordChar = '*';
            Cpassword.MaxLength = 20;

            //CheckForIllegalCrossThreadCalls = false;
        }
        public void PonConectados(string conectados)
        {
            ListaConectados.Text = conectados;
        }
        private void AtenderServidor()
        {
            while (true)
            {
                // Recibimos la respuesta del servidor
                byte[] msg2 = new byte[100];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('-');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje = trozos[1].Split('\0')[0];

                //if (codigo < 6)
                //{
                //    MessageBox.Show(mensaje);
                //}

                //else if (codigo == 6)
                //{
                //    ListaConectados.Text = mensaje;
                //}
                switch (codigo)
                {
                    case 1:
                        MessageBox.Show(mensaje);
                        break;

                    case 2:
                        MessageBox.Show(mensaje);
                        break;

                    case 3:
                        MessageBox.Show(mensaje);
                        break;

                    case 4:
                        MessageBox.Show(mensaje);
                        break;

                    case 5:
                        MessageBox.Show(mensaje);
                        break;

                    case 6: //Recibimos notificación

                        //ListaConectados.Text = mensaje;
                        DelegadoParaEscribir delegado = new DelegadoParaEscribir(PonConectados);
                        ListaConectados.Invoke(delegado, new object[] {mensaje});
                        break;
                }
            }
        }
        int logged = 0;
          

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (logged == 0)
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                //IPAddress direc = IPAddress.Parse("192.168.56.102");
                //IPEndPoint ipep = new IPEndPoint(direc, 9067);
                IPAddress direc = IPAddress.Parse("147.83.117.22");
                IPEndPoint ipep = new IPEndPoint(direc, 50004);


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.LightGreen;
                    //MessageBox.Show("Conectado");


                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }

                

                logged = 1;
            }
            if (password.Text == Cpassword.Text)
            {
                string mensaje = "1/" + username.Text + "/" + password.Text;
                // Enviamos al servidor el nombre del usuario, la contraseña y la confirmación de la contraseña
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                ////Recibimos la respuesta del servidor
                //byte[] msg2 = new byte[80];
                //server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //MessageBox.Show(mensaje);

            }
            else
            {
                MessageBox.Show("Passwords doesn't match");
            }

            groupBox3.Visible = true;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            if (logged == 0)
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPEndPoint ipep = new IPEndPoint(direc, 9068);


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.LightGreen;
                    MessageBox.Show("Conectado");


                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }

                //pongo en marcha el thread que atenderá los mensajes del servidor
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();

                logged = 1;
            }
            string mensaje = "2/" + user.Text + "/" + psswd.Text;
            // Enviamos al servidor el nombre el user y la contraseña
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            ////Recibimos la respuesta del servidor
            //byte[] msg2 = new byte[80];
            //server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //MessageBox.Show(mensaje);

            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button1.Visible = true;

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            
            //Petición para saber que jugador tiene más kills
            if (maskills.Checked)
            {
                string mensaje = "3/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                //byte[] msg2 = new byte[100];
                //server.Receive(msg2);
                ////mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                ////MessageBox.Show(mensaje);

                //string[] trozos = Encoding.ASCII.GetString(msg2).Split('-');
                //int codigo = Convert.ToInt32(trozos[0]);
                //mensaje = trozos[1].Split('\0')[0];
                //MessageBox.Show(mensaje);

            }
            //Petición para saber que jugador ha jugado más partidas
            else if (maspartidas.Checked)
            {
                string mensaje = "4/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                ////Recibimos la respuesta del servidor
                //byte[] msg2 = new byte[80];
                //server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //MessageBox.Show(mensaje);
            }
            //Petición para saber que jugador ha ganado más partidas
            else if (masganadas.Checked)
            {
                string mensaje = "5/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                ////Recibimos la respuesta del servidor
                //byte[] msg2 = new byte[80];
                //server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //MessageBox.Show(mensaje);
            }
            //else if (conectados.Checked)
            //{
            //    string mensaje = "6/";
            //    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            //    server.Send(msg);

            //    //Recibimos la respuesta del servidor
            //    byte[] msg2 = new byte[80];
            //    server.Receive(msg2);
            //    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //    MessageBox.Show(mensaje);
            //}
            //else if(true){
            //    //Notificación

            //}
        }

        private void masganadas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void conectados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mensaje de desconexión
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

            groupBox1.Visible = false;
            groupBox3.Visible = true;
            button1.Visible = false;
            logged = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void psswd_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
