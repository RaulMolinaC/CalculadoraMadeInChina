    class UserInterface
    { 
        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.DarkBlue;
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine(" Calculadora Made in China ");
            System.Console.WriteLine(" ----------------------------------- ");
            System.Console.ResetColor();
            System.Console.WriteLine(" 1) Sumar una serie de números ");
            System.Console.WriteLine(" 2) Restar una serie de números ");
            System.Console.WriteLine(" 3) Multiplicar ");
            System.Console.WriteLine(" 4) Dividir ");
            System.Console.WriteLine(" 5) Raices ");
            System.Console.WriteLine(" 6) Números primos ");
            System.Console.WriteLine(" 7) Sumatorios ");
            System.Console.WriteLine(" 0) Salir de la aplicación ");

        }
     
        public static void PrintAddHeader()
         {
            System.Console.WriteLine(" Suma de números ");

         }

         public static void PrintSubHeader()
          {
            System.Console.WriteLine(" Resta de números ");

          }

        public static void PrintAddSubmenu()
        {
            System.Console.WriteLine("0) Salir al menú principal");
            System.Console.WriteLine("1) Sumar otro número");
            System.Console.WriteLine("2) Comenzar nueva suma");
        }
                       

        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;   
                //Conectar una base de datos
                //Hacer una consulta
                //Hacer una modificación
                //Commit

            }
            catch (System.Exception e)
            {
                return -1;
                //rollback
            }       
                finally
            {
                //Cerrar conexión con la base de datos
            }

            //int result = System.Int32.Parse(option);

        }

       public static int ReadMenuOption(int MinMenuOption, int MaxMenuOption)
        { 
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= MinMenuOption && option <= MaxMenuOption) 
                   return option;
                else
                    System.Console.WriteLine("Opción duera de rango ");
            }   
    
        }

    }
