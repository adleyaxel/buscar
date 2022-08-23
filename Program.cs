using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // de mayor a menor
            int[] maxNombres = new int[7]{6000,4065,650,501,201,100,15};
            int cont;
            int[ ] ordenarNombres = new int[7];

           
              for(int i = 0; i < 7-1;i++)
              {
                  // i = 1
                 
                 

                if (maxNombres[i] < maxNombres[i+1])
                {
                    cont = maxNombres[i];
                   
                    maxNombres[i]= maxNombres[i+1];
                    maxNombres[i + 1] = cont;
                    if (maxNombres[1] > maxNombres[0])
                    {
                        cont = maxNombres[0];

                        maxNombres[0] = maxNombres[1];
                        maxNombres[1] = cont;
                       
                    }   
                }
               
                 
                }
            for(int i = 0; i < 7;i++)
            {
                Console.WriteLine(maxNombres[i]);
            }
               
               
             
        }
    }
           
         
}
