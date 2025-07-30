using System;

namespace POE
{
    internal class Contra
    {
        public static void Password()
        {
            string contraseñaCorrecta = "1234";
            int intentos = 0;
            bool accesoConcedido = false;

            while (intentos < 3)
            {
                Console.Write("Ingrese la contraseña: ");
                string input = Console.ReadLine();

                if (input == contraseñaCorrecta)
                {
                    accesoConcedido = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                    intentos++;
                }
            }

            if (accesoConcedido)
                Console.WriteLine("Acceso concedido.");
            else
                Console.WriteLine("Acceso denegado.");
        }
    }
}
