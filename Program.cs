using System;

namespace Trabajo_Final
{
    public class Calcular_Prestamo
    {
        private double Monto;

        private double Interes;
        private double Capital;

        private double Interes_Anual;

        private double Dinero_Prestamo;

        private double Interes_Mensual;

        private int Numero_orden = 1;

        private double Plazo;
        private double Capacidad_Endudamiento;
        private int sueldo;
        DateTime fecha = DateTime.Now;

        public void Entrada()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("*******************************- SISTEMA CALCULADORA DE PRÉSTAMOS -**********************************");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("\nIntroduce el Monto a solicitar:");
            Dinero_Prestamo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce su Tasa Anual:");
            Interes_Anual = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce el Plazo (Meses):");
            Plazo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce sus ingresos (sueldo):");
            sueldo = int.Parse(Console.ReadLine());

            Console.Clear();
        }


        public void Operacion_Interes_Mensual()
        {
            Interes_Mensual = (Interes_Anual / 1200);
        }

        public void Calculo_de_Cuota_Mensual(int uno = 1)
        {
            Monto = Interes_Mensual + uno;
            Monto = (double)Math.Pow(Monto, Plazo);
            Monto = Monto - uno;
            Monto = Interes_Mensual / Monto;
            Monto = Interes_Mensual + Monto;
            Monto = Dinero_Prestamo * Monto;



        }
        public void Calculo_Endeudamiento()
        {
            Capacidad_Endudamiento = Monto * 100 / sueldo;

        }
        public void CicloWhile(int f = 1)
        {

            while (f <= Plazo)
            {
                Console.Write("\t{0}\t", Numero_orden);


                Console.Write("{0}\t", Math.Round(Monto, 2));


                Interes = Interes_Mensual * Dinero_Prestamo;
                Console.Write("\t{0}\t", Math.Round(Interes, 2));


                Capital = Monto - Interes;
                Console.Write(" \t{0}\t", Math.Round(Capital, 2));


                Dinero_Prestamo = Dinero_Prestamo - (Capital);

                if (Dinero_Prestamo >= 1)
                {

                    Console.Write(" \t{0}    ", Math.Round(Dinero_Prestamo, 2));
                }
                else
                {
                    Console.Write(" \t{0} \t   ", Dinero_Prestamo = 0);
                }


                fecha = fecha.AddDays(30);
                Console.Write("\t {0}", fecha.ToString("dd-MMMM-yyyy"));


                Numero_orden = Numero_orden + 1;
                Console.WriteLine();
                Console.WriteLine("*****************************************************************************************************");

                f += 1;
            }
            
            Console.WriteLine();



        }

        public void Resultados()
        {
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("********************************************- Detalles -*********************************************");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Monto del Préstamo en RD$: RD$ {0}", Dinero_Prestamo);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Tasa de Porcentaje Anual %: {0}%", Interes_Anual);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Plazo: {0} Meses", Plazo);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Valor de Cuota: RD$ {0}", Math.Round(Monto, 2));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Capacidad de endeudamiento: {0}% de sus ingresos mensuales. ", Math.Round(Capacidad_Endudamiento, 2));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************************");

            Console.Write("\tPago");
            Console.Write("\t Cuota");
            Console.Write("\t\tInterés");
            Console.Write("\t\tCapital ");
            Console.Write("\tBalance ");
            Console.Write("\t  Fecha de Pago");



            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*****************************************************************************************************");

        }


        static void Main(string[] args)
        {
            //Comando para cambiar el formato de número, de coma ',' a punto '.'.

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            Calcular_Prestamo ejecucion = new Calcular_Prestamo();
            ejecucion.Entrada();
            ejecucion.Operacion_Interes_Mensual();
            ejecucion.Calculo_de_Cuota_Mensual();
            ejecucion.Calculo_Endeudamiento();
            ejecucion.Resultados();
            ejecucion.CicloWhile();


        }
    }
}

