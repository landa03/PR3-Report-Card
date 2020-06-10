using System;
using System.Collections.Generic;

namespace PR3_Report_Card
{
    class Menu
    {
        /*

        ¡Bienvenido a la nevería!

        1) Ingreso de estudiante (incluye agregar materias y califas)
        2) borrar estudiante
        3) exportar
        4) Borrar info

        9) Salir

        Selecciona una opción:
        > 1
        [enter]

        */

        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 9}); // esto jenera una nueva serie de opciones
        List<int> selectRutaOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 9});
        List<int> selectFlaborOptions = new List<int>(new int[] {1, 9});

        private string tipoCono = "";
        private string tipoSabor = "";
        
        //voy a agregar los objetos
        Estudents si = new Estudents();
        Queue names = new Queue();
        Queue rauts = new Queue();
        Queue namesMemory = new Queue();
        Queue rautsMemory = new Queue();

        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("¡Bienvenido a la estacion de camiones!");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() { // esto es lo que te dice la consola
            System.Console.WriteLine("1) Ingreso de estudiante");
            System.Console.WriteLine("2) Agregar materia");
            System.Console.WriteLine("3) Borrar estudiante");
            System.Console.WriteLine("4) Exportar (no espero que funcione)");
            System.Console.WriteLine("5) Borrar estudiante de su existencia");
            System.Console.WriteLine("6) Camiones en la estacion");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("¡Gracias por su visita! ¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            //aqui se interpreta un valur adquirido, en este caso dado por el usuario
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput); // convierto a entro el valor dado por el usuario
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } 
                catch (System.Exception) 
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

       

        private void DisplaySelectConeMessage() {/*es la funcion de dar un mensaje*/
            System.Console.WriteLine("Indique su ruta");
            System.Console.WriteLine();
        }

        private void DisplaySelectConeOptions() {/*es la funsion de dar un mensaje*/
            System.Console.WriteLine("1) A");
            System.Console.WriteLine("2) B");
            System.Console.WriteLine("3) E");
            System.Console.WriteLine("4) D");
            System.Console.WriteLine("5) E");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }

        public void SelectConeType() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplaySelectConeMessage();
                DisplaySelectConeOptions();
                System.Console.WriteLine($"Ruta seleccionada: {tipoCono}");

                selectedOption = RequestOption(selectRutaOptions);

                switch (selectedOption)  
                { // estas son las opciones reales
                    case 1: 
                        string nombre = Convert.ToString(Console.ReadLine());
                        tipoCono = "A";
                        //names.Enqueue(nombre);
                        //rauts.Enqueue("A");
                        //namesMemory.Enqueue(nombre);
                        //rautsMemory.Enqueue("A");
                        break;
                    case 2: 
                        nombre = Convert.ToString(Console.ReadLine());
                        tipoCono = "B";
                        //names.Enqueue(nombre);
                        //rauts.Enqueue("B");
                        //namesMemory.Enqueue(nombre);
                        //rautsMemory.Enqueue("B");
                        break;
                     case 3: 
                        nombre = Convert.ToString(Console.ReadLine());
                        tipoCono = "C";
                        //names.Enqueue(nombre);
                        //rauts.Enqueue("C");
                        //namesMemory.Enqueue(nombre);
                        //rautsMemory.Enqueue("C");
                        break;
                     case 4: 
                        nombre = Convert.ToString(Console.ReadLine());
                        tipoCono = "D";
                        //names.Enqueue(nombre);
                        //rauts.Enqueue("D");
                        //namesMemory.Enqueue(nombre);
                        //rautsMemory.Enqueue("D");
                        break;
                     case 5: 
                        nombre = Convert.ToString(Console.ReadLine());
                        tipoCono = "E";
                        //names.Enqueue(nombre);
                        //rauts.Enqueue("E");
                        //namesMemory.Enqueue(nombre);
                        //rautsMemory.Enqueue("E");
                        break;
                } //el break se sale de este switch
            }
        }

        private void DisplaySelectFlaborMessage() {/*es la funcion de dar un mensaje*/
            System.Console.WriteLine("Selecciona un sabor");
            System.Console.WriteLine();
        }

        private void DisplaySelectFlaborOptions() {/*es la funsion de dar un mensaje*/
            System.Console.WriteLine("1) Confirmar");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Volver");
        }

        private void SelectFlaborType() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                DisplaySelectFlaborMessage();
                DisplaySelectFlaborOptions();
                System.Console.WriteLine($"Tipo de Cono seleccionado: {tipoSabor}");

                selectedOption = RequestOption(selectFlaborOptions);

                switch (selectedOption)
                {
                    case 1: 
                        names.Dequeue();
                        rauts.Dequeue();
                        System.Console.WriteLine(names.Front()); 
                        break;
                } //el break se sale de este switch
            }
        }
        
        private void Pay() {
            //\n es salto de línea
            System.Console.WriteLine("Tu pedido es el siguiente:\n");
            System.Console.WriteLine($"tipoCono => {tipoCono}");
            System.Console.WriteLine($"tipoSabor => {tipoSabor}");

            System.Console.WriteLine("\n!Gracias por tu compra!");
        }

        public void Display() {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION) {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                /*aqui se empiesa a ejecutar la interaccion*/
                switch (selectedOption) 
                {
                    case 1: //llegada de camion
                        si.AddStudent();
                        
                        break;
                    case 2: //salida de camion
                        si.AddMateria();
                        break;
                    case 3: //data de camiones
                        
                        break;
                    case 4: //
                        
                        break;
                    case 5: //camiones actuales
                        
                        //selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                    // default:
                }
            }

            

            DisplayByeMessage();

        }
       
    }
}
// TODO que borre la info (sin ideas de solucion)