namespace Entity
{
    public class Docente
    {
        public int Puntos { get; set; }
        public decimal Salario { get; set; }
        public string Categoria { get; set; }

        public void CalcularSalario()
        {
            Salario = 16441m * Puntos;
        }
    }
}