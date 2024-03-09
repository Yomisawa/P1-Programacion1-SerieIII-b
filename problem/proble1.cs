using System;


namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al generador de correos!");
            Console.Write("Ingresa tu correo electrónico de dominio Gmail: ");
            string inputEmail = Console.ReadLine();

            if (inputEmail.EndsWith("@gmail.com"))
            {
                // Reemplazar el dominio "gmail.com" por "miumg.edu.gt"
                string newEmail = inputEmail.Replace("@gmail.com", "@miumg.edu.gt");
                Console.WriteLine("Tu nuevo correo es" + newEmail);
            }
            else
            {
                Console.WriteLine("El correo ingresado no es de dominio Gmail.");
            } Console.Read();
        }
    }
}
