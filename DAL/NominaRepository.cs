using Entity;

namespace DAL
{
    public class NominaRepository
    {
        public List<Docente> Docentes { get; set; }
        public decimal NominaTotal { get; set; }

        public NominaRepository()
        {
            Docentes = new List<Docente>();
        }

        public decimal ObtenerNomina()
        {
            return NominaTotal;
        }

        public void AgregarDocente(Docente docente)
        {
            Docentes.Add(docente);
        }

        public void CalcularNominaTotal()
        {
            NominaTotal = 0;
            foreach (Docente docente in Docentes)
            {
                NominaTotal += docente.Salario;
            }
        }

        

    }
}