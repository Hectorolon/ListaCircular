using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCirculares
{
    class Ruta
    {
        public string _nombre { get; set; }
        public int _horaInicio { get; set; }
        public int _horaFin { get; set; }

        public Ruta _siguiente { get; set; }

        public Ruta(string nombre, int horaInicio, int horaFin)
        {
            _nombre = nombre;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
        }

        public override string ToString()
        {
            return "Base: " + _nombre + Environment.NewLine +
            "Hora Inicio: " + _horaInicio + Environment.NewLine +
            "Hora Fin: " + _horaFin + Environment.NewLine;
        }
    }
}
