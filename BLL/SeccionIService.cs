using BLL.Constantes;
using BLL.Enums;
namespace BLL
{
    public class SeccionIService
    {
        public int Puntos { get; set; }
        public bool EsMedicinaOMusica { get; set; }

        public void CalcularPuntosPorTitulosDePregrado(Titulos titulo)
        {
            if(titulo == Titulos.Medicina_Musica)
            {
                Puntos += Punto.PregradoMedicinaHumanaComposicionMusical;
                EsMedicinaOMusica = true;
                return;
            }

            Puntos += Punto.Pregrado;
        }

        public void CalcularPuntosPorTitulosDePosgrado(int? AniosCursados)
        {
            if(EsMedicinaOMusica)
            {
                
            }
        }

    }
}