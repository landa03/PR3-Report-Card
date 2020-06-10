using System;

namespace PR3_Report_Card
{
    class Estudents
    {
        public void AddStudent()
        {
            string Name = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine($"el estudiante {Name} fue agregado");
        }
        Queue Materia = new Queue();
        public void AddMateria()
        {
            Materias materia1 = new Materias();
            Materia.Enqueue(materia1);
            materia1.Nombre();
            materia1.CalificasionTotal();
            
        }
    }
}
