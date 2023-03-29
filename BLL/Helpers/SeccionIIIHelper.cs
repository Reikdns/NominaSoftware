using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Constantes;
using BLL.Enums;

namespace BLL.Helpers
{
    public class SeccionIIIHelper
    {
        public int Puntos { get; set; }

        public int CalcularPuntos(Categorias categorias, int experienciaInvestigativa, int experienciaDocente, int experienciaCargosDireccion, int experienciaNoDocente)
        {
            if (experienciaInvestigativa != 0)
            {
                int puntosInvestigacion = ObtenerPuntoPorCategoria(categorias) * experienciaInvestigativa;
                Puntos += puntosInvestigacion > 20 ? 20 : puntosInvestigacion;
            }

            if (experienciaDocente != 0)
            {
                int puntosDocente = ObtenerPuntoPorCategoria(categorias) * experienciaDocente;
                Puntos += puntosDocente > 45 ? 45 : puntosDocente;
            }

            if (experienciaCargosDireccion != 0)
            {
                int puntosDireccion = ObtenerPuntoPorCategoria(categorias) * experienciaCargosDireccion;
                Puntos += puntosDireccion > 90 ? 90 : puntosDireccion;
            }

            if (experienciaNoDocente != 0)
            {
                int puntosNoDocente = ObtenerPuntoPorCategoria(categorias) * experienciaNoDocente;
                Puntos += puntosNoDocente > 120 ? 120 : puntosNoDocente;
            }

            int puntos = Puntos;
            Puntos = 0;
            return puntos;
        }

        private int ObtenerPuntoPorCategoria(Categorias categorias)
        {
            switch (categorias)
            {
                case Categorias.Instructor:
                    return Punto.InstructorExp;

                case Categorias.Asistente:
                    return Punto.Asistente;

                case Categorias.Asociado:
                    return Punto.Asociado;

                case Categorias.Titular:
                    return Punto.Titular;

                default:
                    return 0;
            }
        }
    }
}
