using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Persona persona = new Persona();
            persona.Nombres = "Carlos Adriel";
            persona.Apellidos = "Cabrera Ricalde";
            persona.AsignarNombresCompletos();
            



            Triangulo triangulo = new Triangulo();
            triangulo.Base = 4;
            triangulo.Altura = 5;
            Console.WriteLine(triangulo.CalcularArea());



            Console.WriteLine(persona.NombresCompletos);
            Console.WriteLine("Hola Mundo");
            Console.Read();
        }
    }
}
