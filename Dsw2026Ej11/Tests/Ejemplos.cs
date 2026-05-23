using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Martin Cirio", 10);
        Alumno alumno2 = new Alumno(2, "Charles Leclerc", 9);
        Alumno alumno3 = new Alumno(3, "Charlotte Caniggia", 7);


        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3); 

        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno.Nombre); 
        }

        Alumno alumnoBuscado = casoList.BuscarAlumnoPorNombre("Charles Leclerc"); 

        if(alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado.Nombre); 
        }

        Alumno alumnoNoExiste = casoList.BuscarAlumnoPorNombre("Emma Watson"); 
        if (alumnoNoExiste != null)
        {
            Console.WriteLine(alumnoNoExiste.Nombre); 
        }
        else
        {
            Console.WriteLine("No existe"); 
        }

        casoList.EliminarAlumno(alumno2); 

        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno.Nombre); 
        }

        casoList.EliminarAlumnoPorPosicion(0); 

        foreach (Alumno alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine(alumno.Nombre); 
        }





    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Martin Cirio", 10);
        Alumno alumno2 = new Alumno(2, "Charles Leclerc", 9);
        Alumno alumno3 = new Alumno(3, "Charlotte Caniggia", 7);

        casoDictionary.AgregarAlumno(1, alumno1);
        casoDictionary.AgregarAlumno(2, alumno2);
        casoDictionary.AgregarAlumno(3, alumno3); 

        foreach (var alumno in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine(alumno.Value); 
        }

        Alumno alumnoBuscado = casoDictionary.BuscarAlumno(2); 
        
        if (alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado); 
        }

        Alumno alumnoNoExiste = casoDictionary.BuscarAlumno(10); 

        if (alumnoNoExiste != null)
        {
            Console.WriteLine(alumnoNoExiste); 
        }
        else
        {
            Console.WriteLine("No existe"); 
        }


        casoDictionary.ElimianrAlumno(2); 


        foreach (var alumno in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine(alumno.Value); 
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine(casoLinq.GetTotalPrecios);

        Console.WriteLine(casoLinq.GetPromedioPrecios());

        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro);

        }
         
        foreach (String libro in casoLinq.GetLibros())
            {
                Console.WriteLine(libro); 
            }

        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine(casoLinq.GetMenorPrecio()); 

        foreach (Libro libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro); 
        }


        foreach (Libro libro in casoLinq.GetOrdenadosDescendente())
        {
            Console.WriteLine(libro); 
        }
        

    }
}
