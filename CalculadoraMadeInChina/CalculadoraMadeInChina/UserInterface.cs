    class UserInterface
    {
        public static void PrintMainMenu()
        {
           
            System.Console.WriteLine(" Calculadora Made in China ");
            System.Console.WriteLine(" 1) Sumar una serie de números ");
            System.Console.WriteLine(" 2) Restar una serie de números ");
            System.Console.WriteLine(" 3) Multiplicar ");
            System.Console.WriteLine(" 4) Dividir ");
            System.Console.WriteLine(" 5) Raices ");
            System.Console.WriteLine(" 6) Números primos ");
            System.Console.WriteLine(" 7) Sumatorios ");
            System.Console.WriteLine(" 0) Salir de la aplicación ");

        }

        public static int ReadOption()
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

    }
