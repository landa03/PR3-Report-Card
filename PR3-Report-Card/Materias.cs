using System;

namespace PR3_Report_Card
{
    class Materias
    {
        public void Nombre()
        {
            System.Console.WriteLine("cual es el nombre de la materia");
            string nombre = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine($"que calificasion se saco en {nombre}?");
        }
        public float Calificasion1()
        {
            System.Console.WriteLine("iserte la primer calificacion");
            float calificasion1 = Convert.ToInt32(Console.ReadLine());
            return calificasion1; 
        }
        public float Calificasion2()
        {
            System.Console.WriteLine("inserte la segunda calificasion");
            float calificasion2 = Convert.ToInt32(Console.ReadLine());
            return calificasion2;
        }
        public float Calificasion3()
        {
            System.Console.WriteLine("inserte la tercera calificasion");
            float calificasion3 = Convert.ToInt32(Console.ReadLine());
            return calificasion3;
        }
        public void CalificasionTotal()
        {
            float calificasiontotal = (Calificasion1() + Calificasion2() + Calificasion3())/3;
            System.Console.WriteLine(calificasiontotal);
        }
    }
}
