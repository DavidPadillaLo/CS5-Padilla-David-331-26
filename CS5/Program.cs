using System;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 
            // Sintaxis While:
            // Inicializacion;
            // whila(expresion)
            // {
            //      Bloque de instrucciones
            //      Iterdor: instruccion que permite repetir o finalizar el ciclo
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            // Variable de control: m
            int m = 1; // Inicializacion
            while(m <= 3) // O while(m < 4)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}"); 
                m += 1; // Iterador
            }
            // Ejercitacion
            // 1. Definir un cilo para imprimir tu nombre cinco veces Nota: utilizar el operador <.
            m = 1;
            string nombre = "Davi Padilla";
            while (m < 6)
            {
                Console.WriteLine($"Nombre del almuno: {nombre}");
                m += 1;
            }
            // b. Ciclo descendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while (i <= 18)
            {
            Console.WriteLine($"i: {i}");
            i += 3;
            }
            // d. Decrementos
            // Ejercitacion
            // 1. Definir un ciclo para imprimir "331" 8 veces. Notas define un cilo descendente con decrementos de 2 unidades.
            m = 16;
            while (m >= 2)
            {
                Console.WriteLine("331");
                m -= 2;
            }
            // Activida 1: Ciclo infinito
            // 1. definir un ciclo infinito ascendente
            // 2. Definir un ciclo infinito descendente
            // Nota: utilizar el operador de diferencia
            m = 0;
            while (m >= 0)
            {
                Console.WriteLine($"m: {m}");
                m += 1;
            }
            m = 0;
            while (m != 1)
            {
                Console.WriteLine($"m: {m}");
                m -= 1;
            }
        }
    }
}