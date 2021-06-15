using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Agenda_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[15, 5];
            char OP = 's';
            int op;

            while (OP == 's')
            {
                mat[0, 0] = "Nombre";
                mat[0, 1] = "Apellido";
                mat[0, 2] = "Direccion";
                mat[0, 3] = "Telefono";
                mat[0, 4] = "Correo";

                Console.Clear();
                Console.WriteLine("Qué Desea realizar:\n 1.Ingresar Contacto\n 2.Mostrar Contactos\n 3.Buscar");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Direccion, Telefono, Correo\n");
                    for (int c = 0; c < 5; c++)
                    {
                        for (int f = 1; f < 15; f++)
                        {
                            Console.Write("Ingrese Nota [Valor:" + (f) + ", Dato:" + (c + 1) + "]: ");

                            mat[f, c] = Console.ReadLine();
                        }
                    }
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nDatos de los Contactos: ");
                    for (int c = 0; c < 5; c++)
                    {
                        for (int f = 0; f < 15; f++)
                        {
                            Console.WriteLine(mat[f, c] + " ");
                        }
                    }
                }

                if (op == 3)
                {
                    int m, l;
                    Console.Clear();
                    Console.WriteLine("Seleccione El Número de Contacto que Desea Buscar:\n");
                    m = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("El Contacto que buscaba es: " + mat[m, 0] + " " + mat[m, 1] + " " + mat[m, 2] + " " + mat[m, 3] + " " + mat[m, 4]);
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Desea Regresar al Menú Principal [s/n]");
                OP = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
