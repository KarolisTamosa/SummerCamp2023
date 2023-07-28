namespace Entidades
{
    // public - visible en todo el proyecto
    // private - Solo los miembros de la misma clase pueden acceder al tipo
    // protected - 
    // Internal - Solo es visible dentro del proyecto
    public class Empleado
    {

        public enum Nivel
        {
            normal,
            bueno,
            excelente
        }
        private Nivel nivel;

        public void FijarNivel(Nivel nivel){
            this.nivel = nivel;
        }
        public Empleado()
        {
        }

        public Empleado(string nombre, double salario, DateTime fechaAlta, bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }
        public string? Nombre { get; set; }
        public double Salario { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public bool Alta { get; set; }
    }
}
