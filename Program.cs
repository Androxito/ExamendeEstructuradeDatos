
namespace ExamendeEstructuradeDatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Ejercicios ejercicios= new Ejercicios();

            Console.WriteLine("Ingrese un numero");
            int numeroI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numeroF =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ejercicios.Intervalo(numeroI,numeroF));
            

         
        }
    }
}