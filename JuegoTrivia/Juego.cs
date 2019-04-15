using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Timers;

namespace JuegoTrivia
{
    public partial class Juego : Form
    {
        IngresoNombre frm2;
        private int contador;
        public SQLiteConnection con;
        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Respuesta> respuestas = new List<Respuesta>();
        List<Label> labels = new List<Label>();
        private Pregunta preguntaActual;
        private Respuesta respuestaCorrecta;
        Random rand = new Random();


        public Juego(IngresoNombre frmi)
        {
            InitializeComponent();
            frm2 = frmi;
            label1.Text = frm2.gamer.Nombre;
            label2.Text = frm2.gamer.Vidas.ToString();
            label3.Text = frm2.gamer.Puntaje.ToString();



        }

        private void Juego_Load(object sender, EventArgs e)
        {
            contador = 30;
            reloj.Text = contador.ToString();
            timer1.Start();
            crearPreguntas();
            preguntaActual = preguntas[frm2.gamer.ContadorPreguntas];
            pregunta.Text = preguntaActual.Texto;
            crearRespuestas();
            labels.Add(respuesta1);
            labels.Add(respuesta2);
            labels.Add(respuesta3);
            labels.Add(respuesta4);

            int[] indices = new int[4];
            for (int i = 0; i < 4; i++)
            {
                indices[i] = i;
            }

            for (int i = 0; i < 4; i++)
            {
                int a = rand.Next(0, 4);
                int cont = 0;

                if (a == indices[i])
                {
                    cont++;
                }

                if (cont == 0)
                {

                    indices[i] = a;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int x = 3; x >= 0; x--)
                {
                    Label temp = labels[indices[x]];
                    labels[indices[x]] = labels[i];
                    labels[i] = temp;

                }
            }
            crearBotones(labels[0]);
            crearBotones(labels[1]);
            crearBotones(labels[2]);
            crearBotones(labels[3]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador = contador - 1;
                reloj.Text = contador.ToString();
            }
            else
            {
                timer1.Stop();
                reloj.Text = 0.ToString();
                MessageBox.Show("No acertaste la respuesta.", "¡Se terminó el tiempo!");
                EsIncorrecta();
                terminoJuego();
            }
        }

        public void EsCorrecta()
        {
            frm2.gamer.ContadorPreguntas++;
            frm2.gamer.ActualizarPuntaje();
            terminoJuego();
            pregunta.Text = preguntas[frm2.gamer.ContadorPreguntas].Texto;
            label3.Text = frm2.gamer.Puntaje.ToString();
            preguntaActual = preguntas[frm2.gamer.ContadorPreguntas];
            crearRespuestas();
            crearBotones(labels[0]);
            crearBotones(labels[1]);
            crearBotones(labels[2]);
            crearBotones(labels[3]);
            contador = 30;
            

        }
        public void EsIncorrecta()
        {
            frm2.gamer.ContadorPreguntas++;
            frm2.gamer.ActualizarVidas();
            terminoJuego();
            pregunta.Text = preguntas[frm2.gamer.ContadorPreguntas].Texto;
            label2.Text = frm2.gamer.Vidas.ToString();
            preguntaActual = preguntas[frm2.gamer.ContadorPreguntas];
            crearRespuestas();
            crearBotones(labels[0]);
            crearBotones(labels[1]);
            crearBotones(labels[2]);
            crearBotones(labels[3]);
            contador = 30;
            
            //mostrar respuesta correcta
        }
        public void crearPreguntas()
        {
            try
            {
                con = new SQLiteConnection(@"Data Source=C:\Users\Nuevo Usuario\Desktop\JuegoTrivia\Preguntas.sqlite;Version=3;");
                con.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            string sql = "select id, pregunta, id_respuesta from Preguntas";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pregunta p = new Pregunta((Int64)reader["id"], reader["pregunta"].ToString(), (Int64)reader["id_respuesta"]);
                preguntas.Add(p);

            }
            //mezclar

            int largo = preguntas.Count();
            int[] indices = new int[largo];
            for (int i = 0; i < largo; i++)
            {
                indices[i] = i;
            }

            for (int i = 0; i < largo; i++)
            {
                int a = rand.Next(0, largo);
                int cont = 0;

                if (a == indices[i])
                {
                    cont++;
                }

                if (cont == 0)
                {

                    indices[i] = a;
                }
            }
            for (int i = 0; i < largo; i++)
            {
                for (int x = 0; x < largo; x++)
                {
                    Pregunta temp = preguntas[i];
                    preguntas[i] = preguntas[indices[x]];
                    preguntas[indices[x]] = temp;

                }
            }

        }
        public void crearRespuestas()
        {
            try
            {
                con = new SQLiteConnection(@"Data Source=C:\Users\Nuevo Usuario\Desktop\JuegoTrivia\Preguntas.sqlite;Version=3;");
                con.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            string sql = "select id, id_pregunta, respuesta from Respuestas";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Respuesta r = new Respuesta((Int64)reader["id"], (Int64)reader["id_pregunta"], reader["respuesta"].ToString());
                respuestas.Add(r);
            }

            int largo = respuestas.Count();
            int[] indices = new int[largo];
            for (int i = 0; i < largo; i++)
            {
                indices[i] = i;
            }

            for (int i = 0; i < largo; i++)
            {
                int a = rand.Next(0, largo);
                int cont = 0;

                if (a == indices[i])
                {
                    cont++;
                }

                if (cont == 0)
                {

                    indices[i] = a;
                }
            }
            for (int i = 0; i < largo; i++)
            {
                for (int x = largo-1; x >=0; x--)
                {
                    Respuesta temp = respuestas[indices[x]];
                    respuestas[indices[x]] = respuestas[i];
                    respuestas[i] = temp;

                }
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta.Texto == respuesta1.Text)
            {
                MessageBox.Show("¡Es Correcta!");
                EsCorrecta();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                EsIncorrecta();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta.Texto == respuesta2.Text)
            {
                MessageBox.Show("¡Es Correcta!");
                EsCorrecta();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                EsIncorrecta();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta.Texto == respuesta3.Text)
            {
                MessageBox.Show("¡Es Correcta!");
                EsCorrecta();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                EsIncorrecta();
            }

        }

        private void b4_Click(object sender, EventArgs e)
        {

            if (respuestaCorrecta.Texto == respuesta4.Text)
            {
                MessageBox.Show("¡Es Correcta!");
                EsCorrecta();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                EsIncorrecta();
            }
        }
        public void crearBotones(Label l)
        {

            int largo = respuestas.Count();
            for (int i = 0; i < largo; i++)
            {

                    if (respuestas[i].Id == preguntaActual.RespuestaVerdadera)
                    {
                        respuestaCorrecta = respuestas[i];
                    }

                    if (labels[0] == null && respuestas[i].IdPregunta == preguntaActual.Id)
                    {
                        l.Text = respuestas[i].Texto;
                    }
                    if (respuestas[i].IdPregunta == preguntaActual.Id
                    && labels[0].Text != respuestas[i].Texto
                    && labels[1].Text != respuestas[i].Texto
                    && labels[2].Text != respuestas[i].Texto
                    && labels[3].Text != respuestas[i].Texto)
                    {
                        l.Text = respuestas[i].Texto;
                    }
                    
            }

         }
        public void terminoJuego()
        {
            MenuInicial frm1 = new MenuInicial();
            if (frm2.gamer.Vidas == 0)
            {
                MessageBox.Show("¡Perdiste! Tu puntaje final es: "+frm2.gamer.Puntaje.ToString());
                timer1.Stop();
                frm2.guardarJugador();
                this.Hide();
                frm1.Show();
            }
            if (frm2.gamer.ContadorPreguntas == preguntas.Count())
            {
                MessageBox.Show("¡Ganaste! Tu puntaje final es: " + frm2.gamer.Puntaje.ToString());
                timer1.Stop();
                frm2.guardarJugador();
                this.Hide();
                frm1.Show();
            }
            
        }
        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm2.guardarJugador();
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            /*else
            {
                Application.Exit();
            }*/
        }



    }
}
