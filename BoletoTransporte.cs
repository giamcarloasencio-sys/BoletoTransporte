using System;

namespace BoletoTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA DE BOLETOS DE TRANSPORTE =====");
            Console.Write("\nNombre del pasajero: ");
            string nombre = Console.ReadLine();

            // ----- Elegir destino -----
            // Mostramos la lista de destinos con su distancia en kilometros
            // para que el usuario pueda escoger uno

            Console.WriteLine("\nDestinos disponibles:");
            Console.WriteLine("1. San Pedro de Macoris (70 km)");
            Console.WriteLine("2. La Romana (115 km)");
            Console.WriteLine("3. Santiago (155 km)");
            Console.WriteLine("4. Punta Cana (190 km)");
            Console.WriteLine("5. Puerto Plata (210 km)");

            int opcionDestino = LeerOpcion("Elija un destino (1-5): ", 1, 5);

            string destino = "";
            double distancia = 0;

            switch (opcionDestino)
            {
                case 1:
                    destino = "San Pedro de Macoris";
                    distancia = 70;
                    break;
                case 2:
                    destino = "La Romana";
                    distancia = 115;
                    break;
                case 3:
                    destino = "Santiago";
                    distancia = 155;
                    break;
                case 4:
                    destino = "Punta Cana";
                    distancia = 190;
                    break;
                case 5:
                    destino = "Puerto Plata";
                    distancia = 210;
                    break;
            }

            //* ----- Elegir tipo de transporte -----
            //Mostramos los tipos de transporte con su costo por kilometro
            //y su velocidad promedio, que son los datos que necesitamos
            //para calcular el precio y el tiempo.

            Console.WriteLine("\nTipos de transporte:");
            Console.WriteLine("1. Autobus   (RD$ 3.50 por km, 60 km/h)");
            Console.WriteLine("2. Minibus   (RD$ 4.50 por km, 70 km/h)");
            Console.WriteLine("3. Taxi      (RD$ 25.00 por km, 80 km/h)");

            int opcionTransporte = LeerOpcion("Elija el transporte (1-3): ", 1, 3);

            string transporte = "";
            double costoPorKm = 0;
            double velocidad = 0;

            switch (opcionTransporte)
            {
                case 1:
                    transporte = "Autobus";
                    costoPorKm = 3.50;
                    velocidad = 60;
                    break;
                case 2:
                    transporte = "Minibus";
                    costoPorKm = 4.50;
                    velocidad = 70;
                    break;
                case 3:
                    transporte = "Taxi";
                    costoPorKm = 25.00;
                    velocidad = 80;
                    break;
            }

            // ----- Calculos -----
            double precio = distancia * costoPorKm;
            double tiempoHoras = distancia / velocidad;

            int horas = (int)tiempoHoras;
            int minutos = (int)Math.Round((tiempoHoras - horas) * 60);
            if (minutos == 60)
            {
                horas++;
                minutos = 0;
            }

            // ----- Mostrar el boleto -----
            // Creamos un numero de boleto aleatorio de 4 digitos para que
            // cada boleto se vea diferente

            Random rnd = new Random();
            int numeroBoleto = rnd.Next(1000, 9999);

            Console.WriteLine("\n\n==========================================");
            Console.WriteLine("        ~~|BOLETO DE TRANSPORTE|~~");
            Console.WriteLine("==========================================");
            Console.WriteLine("Boleto No.:    " + numeroBoleto);
            Console.WriteLine("Fecha:         " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("Pasajero:      " + nombre);
            Console.WriteLine("Destino:       " + destino);
            Console.WriteLine("Transporte:    " + transporte);
            Console.WriteLine("Distancia:     " + distancia + " km");
            Console.WriteLine("Tiempo:        " + horas + " h " + minutos + " min");
            Console.WriteLine("Precio:        RD$ " + precio.ToString("N2"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    |Gracias por viajar con nosotros|");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        // Metodo para leer una opcion y validar que sea correcta
        static int LeerOpcion(string mensaje, int min, int max)
        {
            int opcion;
            bool valido;

            do
            {
                Console.Write(mensaje);
                valido = int.TryParse(Console.ReadLine(), out opcion);

                if (!valido || opcion < min || opcion > max)
                {
                    Console.WriteLine("Opcion invalida, intente de nuevo.");
                    valido = false;
                }
            } while (!valido);

            return opcion;
        }
    }
}