using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegados
{
    class Program
    {
        private static IEnumerable<object> proyDuraciones;

        static void Main(string[] args)
        {
            //Func<double, double, double> raiz = CalcularRaiz;
            //Func<double, double, double> potencia = (x, y) => { return Math.Pow(x, y); };

            //Console.WriteLine($"la raiz es: { potencia(6, 3)}");
            //Console.WriteLine($"la raiz es: {raiz(6, 3)}");

            Proyecto pro = new Proyecto();
            //pro.AgregarProyecto();
            var proy = pro.AgregarProyecto2();
            var Listar = pro.proyectos;


            Console.WriteLine("*******Duracion mayores a 6 y menos de 12********");
            var proyMayor = pro.proyectos.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            pro.Listar(proyMayor);



            Console.WriteLine("******Proyectos que empiecen por b*******");
            var proyectosB = from p in pro.proyectos
                             where (p.Nombre.StartsWith("B"))
                             select p;
            pro.Listar(proyectosB.ToList());


            Console.WriteLine("******obtener los proyectos cuyo codigo sea multiplo de 7******");
            var proyPrimo = pro.proyectos.Where(x => x.Codigo % 7 == 0).ToList();
            pro.Listar(proyPrimo);

            Console.WriteLine("obtener todos los proyectos que tengan una duracion inferior a 6 y 10 y mayor a 10");
            var proyDuracion = pro.proyectos.GroupBy(x =>
             {
                 if (x.Duracion < 6)
                 {
                     return "son menores a 6";

                 } else if (x.Duracion >= 10 && x.Duracion < 10)
                 {
                     return "Entre 10 y menores a 10";

                 }
                 else
                 {
                     return "son mayores a 10";
                 }

             }
            );
            foreach (var proyDuraciones in proyDuracion)
            {
                Console.WriteLine("Grupo de proyectos " + proyDuraciones.Key + "------cantidad-----" + proyDuraciones.Count());
                foreach (var item in proyDuraciones)
                {
                    Console.WriteLine("El proyecto" + item.Nombre +
                        "\r\n" + "Duracion Proyecto:" + item.Duracion);
                }
            }
            Console.WriteLine("Obtener el promedio de la diracionde los proyectos");
            var proPro = pro.proyectos.Average(x => x.Duracion);
            Console.WriteLine("El promedio de los proyectos es :" + proPro);


            Console.WriteLine("obtener el nombre del proyecto con mas duracion");
            var dato = pro.proyectos.Max(y => y.Duracion);
            var pory3 = pro.proyectos.Where(x => x.Duracion ==dato).Select(x => x.Nombre).FirstOrDefault();
            Console.WriteLine($"El proyecto con mas duraciones {pory3}");

            // Ejercicio 7

            Console.WriteLine("seleccionar el nombre y el area del proyecto con duracion mayor a 6");
            var datos = pro.proyectos.Max(y => y.Duracion);
            var are = pro.proyectos.Max(z => z.Area);
            var pory2 = pro.proyectos.Where(x => x.Duracion == datos || z = > z.Area==are).Select(x => x.Nombre  ).FirstOrDefault();
            Console.WriteLine($"El proyecto con mas duraciones {pory2}");





            Console.ReadLine();
        }
        //static double CalcularRaiz(double num1, double num2)
        //{
        //    var operacion = Math.Pow(num1, num2);
        //    return operacion;
        //}
    }
}
