/*
 * ITN114-A25-4: Array 1
 * Sir Rodulfo L. Dorado, Jr., MSc.
 * Sherry Eunice T. Cunanan, BSIT, 4th Year
 * October 30, 2021
 */

using System;

namespace array1 {
    class Program {
        
        public static void Main()  {
            
            int[] a = new int[10];
            int i;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  ---------------------------------------");
            Console.WriteLine("   ARRAY 1: STORE AND PRINT ARRAY ELEMENTS");
            Console.WriteLine("  ----------------------------------------");
            Console.ResetColor();
            
            while (true) {
                
            Console.Write("\nInput 10 elements in the array :\n");
            for(i=0; i<10; i++) {  
                
                Console.Write("element - {0} : ",i);
                a[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("\nElements in array are: ");
            for(i=0; i<10; i++) {  
                
                Console.Write("{0}  ", a[i]);
            }
            
            Console.Write("\n");
            
            }
        }
    }
}