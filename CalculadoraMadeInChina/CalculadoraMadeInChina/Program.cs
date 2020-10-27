using System;

namespace CalculadoraMadeInChina
{
    class Program
    {

        public static int ManageAddSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled += number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintAddSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return 0;                                                            
                    case 2:
                        System.Console.Clear();
                        return 2;
                       
                }
            }

        }

        public static int ManageSubSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintSubHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled -= number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintSubSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return 0;
                    case 2:
                        System.Console.Clear();
                        return 2;

                }
            }

        }

        public static int ManageMultSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintMultHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled *= number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintMultSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return 0;
                    case 2:
                        System.Console.Clear();
                        return 2;

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
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    System.Console.Clear();
                    return;    
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    System.Console.Clear();
                    int submenu_option = ManageAddSubmenu(result);
                    if (submenu_option == 0)
                        return;

                }

            }

        }

        public static void ManageSubMenu()
        {

            while (true)
            {
                UserInterface.PrintSubHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer númro: ");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo númro: ");
                int result = number1 - number2;
                System.Console.WriteLine("El resultado es: " + result);
                UserInterface.PrintSubSubmenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    System.Console.Clear();
                    return;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    System.Console.Clear();
                    int submenu_option = ManageSubSubmenu(result);
                    if (submenu_option == 0)
                        return;

                }

            }

        }

        public static void ManageMultMenu()
        {

            while (true)
            {
                UserInterface.PrintMultHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer númro: ");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo númro: ");
                int result = number1 * number2;
                System.Console.WriteLine("El resultado es: " + result);
                UserInterface.PrintMultSubmenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    System.Console.Clear();
                    return;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    System.Console.Clear();
                    int submenu_option = ManageMultSubmenu(result);
                    if (submenu_option == 0)
                        return;

                }

            }

        }

        public static void ManageMainMenu()
                
        {
            bool finished = false;

            while ( finished == false )
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption();

                switch(option)
                {

                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine(" Opción no valida");
                        break;
                    case 1:
                        System.Console.Clear();
                        ManageAddMenu();
                            break;
                    case 2:
                        System.Console.Clear();
                        ManageSubMenu();
                        break;
                    case 3:
                        System.Console.Clear();
                        ManageMultMenu();
                            break;
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
