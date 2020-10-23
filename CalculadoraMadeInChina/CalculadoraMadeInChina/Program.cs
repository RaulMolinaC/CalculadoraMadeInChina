using System;

namespace CalculadoraMadeInChina
{
    class Program
    {

        public static void ManageAddMenu()
        {

            while (true)
            {
                UserInterface.PrintAddMenu();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer númro: ");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo númro: ");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es: " + result);

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
