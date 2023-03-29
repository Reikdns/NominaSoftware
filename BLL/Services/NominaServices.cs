using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Helpers;
using BLL.Enums;
using Entity;

namespace BLL.Services
{
    public class NominaServices
    {
        public NominaRepository NominaRepository { get; set; }
        private SeccionIHelper seccionIHelper;
        private SeccionIIIHelper seccionIIIHelper;

        private SeccionIIHelper seccionIIHelper;

        public NominaServices()
        {
            NominaRepository = new NominaRepository();
            seccionIHelper = new SeccionIHelper();
            seccionIIHelper = new SeccionIIHelper();
            seccionIIIHelper = new SeccionIIIHelper();

        }

        public decimal ObtenerNomina()
        {
            return NominaRepository.ObtenerNomina();
        }

        public void AgregarDocente(Docente docente)
        {
            NominaRepository.AgregarDocente(docente);
        }
        
        public void CalcularNomina()
        {
            NominaRepository.CalcularNominaTotal();
        }

        public void CalcularPuntosCalcularPuntosPorTitulosDePregrado(Titulos titulos)
        {
            seccionIHelper.CalcularPuntosPorTitulosDePregrado(titulos);
        }

        public void CalcularPuntosCalcularPuntosPorTitulosDePosgrado(int aniosCursados, int noClinicas, int maestrias, int doctorado)
        {
            seccionIHelper.CalcularPuntosPorTitulosDePosgrado(aniosCursados, noClinicas, maestrias, doctorado);
        }

        public int ObtenerPuntosSeccionIII(Categorias categorias, int experienciaInvestigativa, int experienciaDocente, int experienciaCargosDireccion, int experienciaNoDocente)
        {
            return seccionIIIHelper.CalcularPuntos(categorias, experienciaInvestigativa, experienciaDocente, experienciaCargosDireccion, experienciaNoDocente);
        }

        public int ObtenerPuntosSeccionII(Categorias categorias)
        {
            return seccionIIHelper.ObtenerPuntos(categorias);
        }

        public int ObtenerPuntosSeccionI()
        {
            return seccionIHelper.ObtenerPuntos();
        }

        public List<Docente> ObtenerDocentes()
        {
            return NominaRepository.Docentes;
        }
    }
}
