using System;
using System.Collections.Generic;
using Biblioteca_de_Alejandría;
internal class Program
{
    private static void Main(string[] args)
    {
        // Menu:
        List<Libro> listaLibros = new List<Libro>();
        while (true)
        {
            Console.WriteLine("~~~~ Biblioteca Alejandría ~~~~");
            Console.WriteLine("Seleccione las opciones:");
            Console.WriteLine("1. Biblioteca de Libro \n" +
                "2. Agregar libro \n" +
                "3. Buscar libro \n" +
                "4. Salir \n");

            int menu = int.Parse(Console.ReadLine());

            // Interfas:
            if (menu == 1)
            {
                if (listaLibros.Count == 0) 
                {
                    Console.WriteLine("No hay libros disponibles");
                } else
                {
                    Console.WriteLine("Lista de libros:");

                    foreach (Libro libro in listaLibros)
                    {
                        Console.WriteLine($"Titulo: {libro.Titulo}");
                        Console.WriteLine($"Autor: {libro.Autor}");
                        Console.WriteLine($"Año: {libro.Año}");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                    }
                }
            }
            else if (menu == 2)
            {
                while (true) 
                {
                    Console.WriteLine("Quieres agregar un libro?: ");
                    Console.WriteLine("1. Nuevo libro \n" +
                        "2. Salir al menu");

                    int agregar = int.Parse(Console.ReadLine());

                    if (agregar == 1) 
                    {
                        Libro libro = new Libro();

                        Console.WriteLine("Titulo del libro: ");
                        libro.Titulo = Console.ReadLine();

                        Console.WriteLine("Autor del libro: ");
                        libro.Autor = Console.ReadLine();

                        Console.WriteLine("Genero del libro: ");
                        libro.Genero = Console.ReadLine();

                        Console.WriteLine("Año del libro: ");
                        libro.Año = int.Parse(Console.ReadLine());

                        Console.WriteLine("Paginas del libro: ");
                        libro.Paginas = int.Parse(Console.ReadLine());

                        listaLibros.Add(libro);

                        Console.WriteLine("Libro registrado correctamente");

                    } else if (agregar == 2) {

                        break;

                    } else
                        Console.WriteLine("Seleccione una de las 2 opciones");
                }
            }
            else if (menu == 3)
            {
                Console.WriteLine("Ingrese el titulo a buscar:");
                string buscar = Console.ReadLine();

                bool encontrado = false;

                foreach (Libro libro in listaLibros)
                {
                    if (libro.Titulo.ToLower() == buscar.ToLower())
                    {
                        Console.WriteLine($"Titulo: {libro.Titulo}");
                        Console.WriteLine($"Autor: {libro.Autor}");
                        Console.WriteLine($"Año: {libro.Año}");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Libro no encontrado");
                }
            }
            else if (menu == 4)
            {
                Console.WriteLine("Saliendo del programa...");
                return;
            }
            else
                Console.WriteLine("Seleccione uno de las 4 opciones");
        }
    }
}