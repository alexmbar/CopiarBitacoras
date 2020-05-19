using System;

namespace CopiarBitacoras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Today;
            string hoyAño = fechaHoy.ToString("yyyy_MM_dd");
            string hoyDia = fechaHoy.ToString("dd_MM_yyyy");

            //Inicio
            Console.WriteLine("Bueno dias Sr Martinez");
            Console.WriteLine(hoyAño);

            //Bitacoras diarias
            Metodos m1 = new Metodos();
            m1.origenNombre="FormatoActividades.xlsx";
            m1.destinoNombre="Lista de Actividades " + hoyDia + ".xlsx";
            m1.origen=@"C:\Users\alejandro.martinez\Documents\Bitacoras\Actividades";
            m1.destino=@"C:\Users\alejandro.martinez\Documents\Bitacoras\Actividades";
            m1.Copiar();            

            //PulseWay
            Metodos m2 = new Metodos();
            m2.origenNombre="FormatoPulseway.xlsx";
            m2.destinoNombre="ReportePulseway " + hoyDia + ".xlsx";
            m2.origen=@"C:\Users\alejandro.martinez\Documents\Bitacoras\PulseWay";
            m2.destino=@"C:\Users\alejandro.martinez\Documents\Bitacoras\PulseWay";
            m2.Copiar();    

            //Respaldo Diario
            Metodos m3 = new Metodos();
            m3.origenNombre="FormatoRespaldos.xlsx";
            m3.destinoNombre="A12AX05 Bitacora de Respaldos_" + hoyAño + ".xlsx";
            m3.origen=@"C:\Users\alejandro.martinez\Documents\Bitacoras\Respaldos diarios";
            m3.destino=@"C:\Users\alejandro.martinez\Documents\Bitacoras\Respaldos diarios";
            m3.Copiar();    

            // Espera a usuario
            //Console.ReadLine();
        }
    }
}
