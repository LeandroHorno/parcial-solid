using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        private static void Main(string[] args)
        {

            TrenRepository trenRepository = new TrenRepository();
            AvionRepository avionRepository = new AvionRepository();    
            Avion avion1 = new Avion();
            avion1._nombre = "AVION 01";
            avion1._velocidadActual = 0;
            avion1._velocidadMaxima = 100;
            avion1._alturaActual = 0;
            avion1._alturaMaxima = 100;

            Avion avion2 = new Avion();
            avion2._nombre = "AVION 02";
            avion2._velocidadActual = 0;
            avion2._velocidadMaxima = 100;
            avion2._alturaActual = 0;
            avion2._alturaMaxima = 100;
           

            Tren tren1 = new Tren();
            tren1._nombre = "TREN 01";
            tren1._velocidadActual = 0;
            tren1._velocidadMaxima = 100;

            Console.WriteLine("Inicio del viaje :)");

            avion1.Volar(10);
            avionRepository.guardar(avion1);

            avionRepository.guardar(avion2);
            avion2.Volar(10);

            tren1.Acelerar(10);
            trenRepository.guardar(tren1);
            Console.WriteLine("Fin del viaje :)");
        }
    }
}