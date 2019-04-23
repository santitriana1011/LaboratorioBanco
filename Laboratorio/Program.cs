using System;

namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ a su Banco BBVA");

            var pago = 17000000;
            var mensualidad = pago / 12;
            double interesdias = 0.02;
            var retraso = mensualidad + (mensualidad * interesdias / 100);
            var descontando = pago - mensualidad;
            var descontandointeres = pago - retraso;
            DateTime consigna;

            Console.WriteLine($"Digite la Fecha de hoy: dia/mes/año");
            consigna = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"La fecha es: {consigna} ");
            Console.WriteLine($"Usted Debe Consignar: {mensualidad}");


            Console.WriteLine($"Si usted se retraso en el pago, ahora debe consignar: {retraso}");

            Console.WriteLine($"Ahora usted debe: {descontando}");

            Console.WriteLine($"Si usted no pago a tiempo entonces debe: {descontandointeres} ");





            Console.ReadLine();

        }
    }
}
