
using static EjemploDelegados.inventarioMedios;

namespace EjemploDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventarioMedios = new inventarioMedios();

            var tocadiscos = new tocadiscos();

            var reproductorCds = new ReproductorCds();


            ProbarMediosDelegado probarDiscosDelegado = new ProbarMediosDelegado(tocadiscos.InsertarDisco);

            ProbarMediosDelegado probarcdsDelegado = new ProbarMediosDelegado(reproductorCds.InsertarCD);


            inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);

            inventarioMedios.ResultadoProbarMedios(probarcdsDelegado);

            InfoMedioDelegado infoMedioDelegado = new InfoMedioDelegado(tocadiscos.ObtenerCancionesDisco);

            string listaCanciones = inventarioMedios.ObtenerInformacionMedio(infoMedioDelegado, "codigoBarras123");

            Console.WriteLine(listaCanciones);
        }
    }
}