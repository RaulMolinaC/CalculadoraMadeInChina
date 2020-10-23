using System;

namespace CalculadoraMadeInChina
{
    class Program
    {

        public static void ManageAddSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled += number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintAddHeader();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;

                }
            }

        }


        public static void ManageAddMenu()
        {

            while (true)
            {
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer númro: ");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo númro: ");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es: " + result);
                UserInterface.PrintAddSubmenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                {
                    return;    
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    ManageAddSubmenu(result);
                }



            }

        }

        public static void ManageMainMenu()
                
        {
            bool finished = false;

            while ( finished == false )
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();

                switch(option)
                {

                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine(" Opción no valida");
                        break;
                    case 1:
                        ManageAddMenu();
                            break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        break;
                    case 0:
                        finished = true;
                        break;

                }               


            }
            System.Console.WriteLine("Fin del menú pricipal");
        }

        static void Main(string[] args)
        {
            ManageMainMenu();
        }


    }
}
