﻿using System;

namespace Practica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeño ensayo ...

            Comparable primerNumero, segundoNumero;

            primerNumero = new Numero(2);

            segundoNumero = new Numero(6);

            Console.WriteLine(primerNumero.sosMenor(segundoNumero));

            // Una pequeña pila 📚

            // Pila pila = new Pila();

            //pila.apilar(primerNumero);

            //pila.apilar(segundoNumero);

            //// Código genérico 🖖🏼

            //Console.WriteLine("¡Probando la pila!");

            //Console.WriteLine(pila.cuantos());

            //Console.WriteLine(pila.minimo().ToString());

            //Console.WriteLine(pila.maximo().ToString());

            //Comparable tercerNumero = new Numero(2); // Compara por valor, no por referencia 👁

            //Console.WriteLine(pila.contiene(tercerNumero));

            // Probando las funciones ... 🥨

            // 🔴 EJERCICIO 7

            //Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();

            //llenar(pila);

            //llenar(cola);

            //informar(pila);

            //informar(cola);

            // 🔴 EJERCICIO 9

            //Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();

            //Coleccionable coleccionMultiple = new ColeccionMultiple((Pila)pila, (Cola)cola);

            //llenar(pila);

            //llenar(cola);

            //informar(pila);

            //informar(cola);

            //informar(coleccionMultiple);

            // 🔴 EJERCICIO 13 🐣

            Coleccionable pila = new Pila();

            Coleccionable cola = new Cola();

            ColeccionMultiple multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);

            llenarPersonas(pila);

            llenarPersonas(cola);

            informarPersonas(multiple);

            // EJERCICIO 17 🥕

            Coleccionable pilaAlumnos = new Pila();

            Coleccionable colaAlumnos = new Cola();

            ColeccionMultiple alumnos = new ColeccionMultiple((Pila)pilaAlumnos, (Cola)colaAlumnos);

            llenarAlumnos(pilaAlumnos);

            llenarAlumnos(colaAlumnos);

            informarAlumnos(alumnos);

        }

        // EJERCICIO 5 🛸

        /// <summary>
        /// Agrega 20 comparables elegidos al azar al coleccionable dado.
        /// </summary>
        /// <param name="coleccionable">Coleccionable</param>
        private static void llenar(Coleccionable coleccionable) 
        {
            Random rd = new Random();

            for (int i = 0; i < 20; i++)
            {
                coleccionable.agregar(new Numero(rd.Next(1, 100)));
            }
        }

        // EJERCICIO 6 🛸

        /// <summary>
        /// Imprime por consola la cantidad de elementos que tiene el coleccionable dado, el elemento 
        /// mínimo, el máximo y si contiene, o no, como elemento un valor leído por teclado.
        /// Precondiciones:
        /// ◽ El coleccionable dado no debe ser vacío.
        /// </summary>
        /// <param name="coleccionable">Coleccionable</param>
        private static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"¿Cuántos? {coleccionable.cuantos()}");

            Console.WriteLine($"Máximo: {coleccionable.maximo()}");

            Console.WriteLine($"Mínimo: {coleccionable.minimo()}");

            Console.WriteLine("Ingrese un valor: ");

            if (coleccionable.contiene(new Numero(int.Parse(Console.ReadLine()))))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }

        public static void informarPersonas(Coleccionable coleccionable)
        {
            Console.WriteLine($"¿Cuántos? {coleccionable.cuantos()}");

            Console.WriteLine($"Máximo: {coleccionable.maximo()}");

            Console.WriteLine($"Mínimo: {coleccionable.minimo()}");

            Console.WriteLine("Ingrese un valor: ");

            if (coleccionable.contiene(new Persona("NN",int.Parse(Console.ReadLine()))))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }

        public static void informarAlumnos(Coleccionable coleccionable)
        {
            Console.WriteLine($"¿Cuántos? {coleccionable.cuantos()}");

            Console.WriteLine($"Máximo: {coleccionable.maximo()}");

            Console.WriteLine($"Mínimo: {coleccionable.minimo()}");

            Console.WriteLine("Ingrese un valor: ");

            if (coleccionable.contiene(new Alumno("NN", int.Parse(Console.ReadLine()), 321, 9.6)))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }

        // EJERCICIO 12 🖖🏼

        /// <summary>
        /// Agrega 20 personas al azar al coleccionable dado.
        /// </summary>
        /// <param name="personas">Coleccionable -- [Persona]</param>
        private static void llenarPersonas(Coleccionable personas)
        {
            string[] strNombresReales = { "Pepe", "Luis", "María", "Paola", "Fernanda", "Gilberto", "Sanjuana", "MaríaJosé",
            "Irma", "Francisco", "Mario", "Ángela", "Fabiola", "Pablo", "Sofía", "Armando", "Homero", "Pepe", "José" , "Josefina" };

            Random rand = new Random(); 
            
            for (int i = 0; i < 20; i++)
            {
                personas.agregar(new Persona(strNombresReales[rand.Next(20)], rand.Next(100, 1000)));
            }
        }

        // EJERCICIO 16 👽

        /// <summary>
        /// Agrega al coleccionable dado 20 alumnos elegidos al azar. 
        /// </summary>
        /// <param name="alumnos">Coleccionable de elementos de tipo Alumno</param>
        private static void llenarAlumnos(Coleccionable alumnos) 
        {
            string[] strNombresReales = { "Pepe", "Luis", "María", "Paola", "Fernanda", "Gilberto", "Sanjuana", "MaríaJosé",
            "Irma", "Francisco", "Mario", "Ángela", "Fabiola", "Pablo", "Sofía", "Armando", "Homero", "Pepe", "José" , "Josefina" };

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                alumnos.agregar(new Alumno(strNombresReales[rand.Next(20)], rand.Next(100,1000), rand.Next(100), rand.NextDouble()*10));
            }

        }
    }
}
