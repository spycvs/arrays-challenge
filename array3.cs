/*
 * ITN114-A25-4: Array 3
 * Sir Rodulfo L. Dorado, Jr., MSc.
 * Sherry Eunice T. Cunanan, BSIT, 4th Year
 * October 30, 2021
 */

using System;

namespace array3 {
    class Program {
        public static void Main() {
    
            int[] a= new int[100];
            int i, n, sum=0;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  -------------------------------");
            Console.WriteLine("   ARRAY 3: SUM OF ARRAY ELEMENTS");
            Console.WriteLine("  ---------------------------------");
            Console.ResetColor();
            
            while (true) {

            Console.Write("\nInput the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());
            
            Console.Write("\nInput {0} elements in the array: \n", n);
            for(i=0;i<n;i++) {
                
                Console.Write("element - {0} : ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            
            for(i=0; i<n; i++) {
                sum += a[i];
            }
            
            Console.Write("\nSum result of array elements: {0}\n\n", sum);
            }
        }
    }
}