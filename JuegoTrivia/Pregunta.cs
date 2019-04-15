using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class Pregunta
    {
        private Int64 id;
        private String texto;
        private Int64 respuestaVerdadera;
        public Pregunta(Int64 i, String t, Int64 resp)
        {
            id = i;
            texto = t;
            respuestaVerdadera = resp;
        }
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        public Int64 RespuestaVerdadera
        {
            get { return respuestaVerdadera; }
            set { respuestaVerdadera = value; }
        }

    }
}
