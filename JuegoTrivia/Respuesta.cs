using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class Respuesta
    {
        private Int64 id;
        private Int64 idPregunta;
        private String texto;
        public Respuesta(Int64 i, Int64 ip, String t)
        {
            id = i;
            idPregunta = ip;
            texto = t;
        }
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }
        public Int64 IdPregunta
        {
            get { return idPregunta; }
            set { idPregunta = value; }
        }
        public String Texto
        {
            get { return texto; }
            set { texto = value; }
        }
    }
}
