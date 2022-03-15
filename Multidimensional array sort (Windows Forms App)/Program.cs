using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // can be an Input from user, and change their size
            int[,] arr = { {9, 5, 1},             
                           {6, 4, 8},
                           {3, 2, 7} };
            int[, ] temp = new int[3, 3];

            int max;
            

            // Sort code
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        

                        for (int h = 0; h < arr.GetLength(1); h++)
                        {
                            /* 
                               sorting condition 
                               if sorting Ascending ↑ --> (<)
                               if sorting Descending ↓ --> (>)
                            */
                            if (arr[i, j] < arr[k, h])
                            {
                                // swapping 
                                max = arr[i, j];
                                arr[i, j] = arr[k, h];
                                arr[k, h] = max;
                            }
                        }
                        
                    }
                    
                    
                    
                }
                
            }



            // print sorted array 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++ )
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine("");
            }

        }
    }
}
