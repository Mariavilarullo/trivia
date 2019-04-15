using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace JuegoTrivia
{
     public class Jugador
    {
        private String nombre;
        private Double puntaje;
        private Int16 vidas;
        public SQLiteConnection con;
        private int contadorPreguntas=0; //se accede con getter y setter
        public Jugador(String prmNombre)
        {
            Nombre = prmNombre;
            Puntaje = 0;
            Vidas = 3;

        }

        public void ActualizarVidas()
        {
            Vidas--;
        }

        public void ActualizarPuntaje()
        {
            Puntaje += 50;
        }
        public int ContadorPreguntas
        {
            get { return contadorPreguntas; }
            set { contadorPreguntas = value; }
        }
       


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Double Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        public Int16 Vidas
        {
            get { return vidas; }
            set { vidas = value; }
        }


    }
}
