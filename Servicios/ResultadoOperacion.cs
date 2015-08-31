namespace Servicios
{
    public enum Resultado
    {
        ok=1,
        Error=2
    }

    public class ResultadoOperacion
    {
        public string Mensaje { get; set; }
        public Resultado Resultado { get; set; }
    }
}