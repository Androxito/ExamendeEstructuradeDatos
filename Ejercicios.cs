using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamendeEstructuradeDatos
{
    public class Ejercicios
    {   
        
       public void TablasdeMultiplicar(int numero,int multiplicado)
        {
            Console.WriteLine("Ingresa un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la tabla de multiplicar del numero");
            Tabla(numero, multiplicado +1);
        }
        public void Tabla(int numero,int multiplicado)
        {
            if(multiplicado <= 10)
            {
                Console.WriteLine($"{numero} x {multiplicado} = {numero * multiplicado}");
                Tabla(numero,multiplicado +1);
            }
        }
        
        public void Intervalo(int numeroI, int numeroF)
        {
            Console.WriteLine("Introduce el primer número del intervalo:");
            numeroI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número del intervalo:");
            numeroF = Convert.ToInt32(Console.ReadLine());

            if (numeroI <= numeroF)
            {
                for (int i = numeroI; i <= numeroF; i++)
                {
                    Console.WriteLine($"la secuencia de los números es {i}");
                }
            }
            else
            {
                for (int i = numeroI; i >= numeroF; i--)
                {
                    Console.WriteLine($"la secuencia de los números es {i}");
                }
            }
        }




       
        
    }













}





   
    







