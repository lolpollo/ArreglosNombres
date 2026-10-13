namespace ArreglosNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            for (int contador = 0; contador < nombres.Length; contador++)
            {
                Console.WriteLine("Introduzca un nombre : ");
                nombres[contador] = Console.ReadLine();
            }

            Console.WriteLine("los nombres  son: ");

            for (int contador = 0; contador < nombres.Length; contador++)
            {
                Console.WriteLine($"{contador} .-  {nombres[contador]}");
            }



        }
    }
}
