using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {   //array anonimo para crear los empleados
            var persona = new[]
            {
                new { nombre = "Vanessa", sueldo = 890 },
                new { nombre = "Saul", sueldo = 789 },
                new { nombre = "Karen", sueldo = 567 },
                new { nombre = "Paul", sueldo = 3049 },
                new { nombre = "Carlos", sueldo = 983 }
            };
            foreach (var i in persona)
            {
                int meses = i.sueldo * 3;
                    Console.WriteLine("Este es el nombre del empleado: " + i.nombre + " , Este es el sueldo:  " + i.sueldo + "$");
                Console.WriteLine("este es el sueldo de 3 meses de trabajo: " + meses + "$");
            }
        }//este es la clase para crear los empleados 
        class empleado
        {     // aqui el construtor 
            public empleado(string nombre, int sueldo)
            {
                this.nombre = nombre;
                this.sueldo = sueldo;
            }
            public string nombre;
            public int sueldo;
        }
    }
}
