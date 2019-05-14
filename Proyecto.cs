﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Delegados
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();
        public  string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        
        public List<Proyecto> AgregarProyecto()
        {
            Console.WriteLine($"Escriba y para ingresar");
            var res = Console.ReadLine();
            while (res=="y")
            {
                Console.WriteLine($"Escriba el nombre del proyecto");
                var nom = Console.ReadLine();
                Console.WriteLine($"Escriba el codigo del proyecto");
                var cod = Console.ReadLine();

                var miProyecto = new Proyecto();
                {
                    Nombre = nom;
                    Codigo = int.Parse(cod);
                };

                proyectos.Add(miProyecto);
                Console.WriteLine($"Escriba y para ingresar");
                res=Console.ReadLine();
            }
            
            return proyectos;
        }

        

        public List<Proyecto> AgregarProyecto2()
        {
            
            var proys = new List<Proyecto>()
            {
                new Proyecto()
            {
                Nombre = "Bancaria",
                Codigo = 23,
                Area = "Comercio",
                Duracion = 15
            },
            new Proyecto()
            {
                Nombre = "Mercadeo",
                Codigo = 21,
                Area = "Talento humano",
                Duracion = 10
            },
            new Proyecto()
            {
                Nombre = "Atendicon",
                Codigo = 7,
                Area = "AIPI",
                Duracion = 11
            },
             new Proyecto()
             {
                 Nombre = "Contabilidad",
                 Codigo = 23,
                 Area = "Comercio",
                 Duracion = 26
             },
            new Proyecto()
            {
                Nombre = "Gestion Bancaria",
                Codigo = 23,
                Area = "Talento humano",
                Duracion = 8
            },
            new Proyecto()
            {
                Nombre = "ADSI",
                Codigo = 24,
                Area = "Sistemas",
                Duracion = 16
            }

         };
            proyectos = proys;
            return proyectos;

            
        }

        public void Listar(List<Proyecto> proyectos)
        {
            foreach (var item in proyectos)
            {
                Console.WriteLine($"los proyectos son {item.Nombre} el codigo es {item.Codigo } el area es {item.Area} y su duracion es de {item.Duracion}");
                
            }
        }

       
    }
}
