using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Constantes;
using BLL.Enums;

namespace BLL.Helpers
{
    public class SeccionIIHelper
    {

        public int ObtenerPuntos(Categorias categorias)
        {
            if(Categorias.Instructor == categorias)
            {
                return Punto.Instructor;
            }

            if (Categorias.Asistente == categorias)
            {
                return Punto.Asistente;
            }

            if (Categorias.Asociado == categorias)
            {
                return Punto.Asociado;
            }

            return Punto.Titular;
        }
    }
}
