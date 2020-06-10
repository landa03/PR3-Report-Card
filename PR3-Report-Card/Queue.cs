using System;
using System.Collections.Generic;

namespace PR3_Report_Card
{
    class Queue
    {
        private List<Materias> elements = new List<Materias>();

        //Enqueue
        public void Enqueue(Materias elementToEnqueue)
        {
            elements.Add(elementToEnqueue);
            System.Console.WriteLine($"Enqueue({elementToEnqueue})");
        }

        //Dequeue
        public Materias Dequeue()
        {
            Materias firstElement = elements[0];

            elements.RemoveAt(0);

            return firstElement;
        }

        //Front
        public Materias? Front()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            Materias firstElement = elements[0];

            return firstElement;
        }

        //Rear
        public Materias? Rear()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int lastPosition = elements.Count - 1;

            return elements[lastPosition];
        }

        //print queue
        public void Print()
        {
            foreach (Materias truk in elements)
            {
                System.Console.WriteLine(truk);
            }
        }
        public void DequeueAll()
        {
            foreach (Materias truk in elements)
            {
                Dequeue();
            }
        }
        

        
    }
}
