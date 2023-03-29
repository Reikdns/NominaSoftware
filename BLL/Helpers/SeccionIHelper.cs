using BLL.Constantes;
using BLL.Enums;

namespace BLL.Helpers
{
    public class SeccionIHelper
    {
        public int Puntos { get; set; }
        public int PuntosPregrado { get; set; }
        public int PuntosPosgrado { get; set; }
        public int PuntosEspecializacion { get; set; }
        public int PuntosMaestria { get; set; }
        public int PuntosDoctorado { get; set; }
        public bool EsMedicinaOMusica { get; set; }
        public int AniosAcademicosCursados { get; set; }
        public int NoClinicosProgramasCursados { get; set; }
        public int MaestriasProgramasCursados { get; set; }
        public int DoctoradoPtogramasCursados { get; set; }

        public void CalcularPuntosPorTitulosDePregrado(Titulos? titulo)
        {
            if (titulo == Titulos.Medicina_Musica)
            {
                PuntosPregrado += Punto.PregradoMedicinaHumanaComposicionMusical;
                EsMedicinaOMusica = true;
            }
            else if (titulo == Titulos.OtraArea)
            {
                PuntosPregrado += Punto.Pregrado;
                EsMedicinaOMusica = false;
            }
        }

        public void CalcularPuntosPorTitulosDePosgrado(int aniosCursados, int noClinicas, int maestrias, int doctorado)
        {
            if (EsMedicinaOMusica)
            {
                PuntosEspecializacion += aniosCursados * Punto.MedicinaAnio > 75 ? 75 : aniosCursados * Punto.MedicinaAnio;
            }
            else
            {
                PuntosEspecializacion += noClinicas > 2 ? noClinicas * Punto.EspecializacionTipoI * 2 : Punto.EspecializacionTipoI;
            }

            PuntosPosgrado += PuntosEspecializacion;

            if (maestrias == 1)
            {
                PuntosMaestria += Punto.MagisterTipoI;
            }
            else if (maestrias > 2)
            {
                PuntosMaestria += Punto.MagisterTipoII;
            }

            PuntosPosgrado += PuntosMaestria;


            if (PuntosEspecializacion + PuntosMaestria >= 60)
            {
                PuntosPosgrado = 60;
            }

            if (doctorado == 1)
            {
                PuntosDoctorado += maestrias == 0 ? Punto.DoctoradoTipoII : Punto.DoctoradoTipoI;
            }
            else if (doctorado > 2)
            {
                PuntosDoctorado += maestrias == 0 ? Punto.DoctoradoTipoIII : Punto.DoctoradoTipoII;
            }

            PuntosPosgrado += PuntosDoctorado;

            if (PuntosPosgrado + PuntosDoctorado > 140)
            {
                PuntosPosgrado = 140;
            }
        }

        public void Reset()
        {
            PuntosPregrado = 0;
            PuntosDoctorado = 0;
            PuntosEspecializacion = 0;
            PuntosMaestria = 0;
            PuntosPosgrado = 0;
        }

        public int ObtenerPuntos()
        {
            int totalPuntos = PuntosPosgrado + PuntosPregrado;
            Reset();
            return totalPuntos;
        }
    }
}
