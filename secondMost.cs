using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
/*
namespace ConsoleApp1
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            // Test input
            List<int> listResult = new List<int>();
            List<int> listPos = new List<int>(); 
            
            int[] numbers = { 72, 93, 72, 83, 98, 72, 44, 25, 53, 43, 98, 81, 98, 98};
            Console.WriteLine("numero di volte che ho il valore:"+SecondMost.secondMost(numbers, listResult, listPos ));
            Console.WriteLine(listResult);
        }
    }

        class SecondMost {
        public static int secondMost(int[] a, List<int> ListaResult, List<int> ListaPos) {
            
            int result = 0;
            int appo=0;
            int idx = 0;
            

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == a[idx]){
                        appo =a[j];    
                        result ++;
                    }
                }
                
                if (!ListaPos.Contains(appo)){
                    ListaPos.Add(appo);
                    ListaResult.Add(result);
                }
                result=0;
                idx++ ;
            }
            
            
            //ListaResult.Sort();
            //ListaResult.Reverse();
            int max = ListaResult.Max();
            int indexMax = ListaResult.IndexOf(max);

            int idxSecondo = ListaResult.IndexOf(max-1);
            
            if (idxSecondo > -1){
                result = ListaPos[idxSecondo];
            }
            else{
                result = ListaPos[indexMax];;
            }
            

            return result;
            
        }

    }
     
}
*/

/*
// reverse for

            int result=0;
            int appo = numbers.Length;
            List<int> numbers2 = new List<int>();

            for (int i = appo - 1; i >= 0 ; i--)
            {
                numbers2.Add(numbers[i]);
                
            }  

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);    
            }
            

            return result;

*/

/*

********************* SHIFT - FIFO ***********************************************
class Test{
        public static int FunctionTest(int[] numbers)
    {
        int[] Shift = new int[numbers.Length];
        while (true)
        {
            // Effettua la rotazione a destra
            Shift[0] = numbers[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Shift[i + 1] = numbers[i];
            }

            foreach (var item in Shift)
            {
                Console.WriteLine(item);
            }

            // Per evitare il ciclo infinito, aggiungiamo una condizione di uscita
            break;
    }

     return 0; // Restituisce un valore arbitrario
    }
    }
*/