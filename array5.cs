/*
 * ITN114-A25-4: Array 5
 * Sir Rodulfo L. Dorado, Jr., MSc.
 * Sherry Eunice T. Cunanan, BSIT, 4th Year
 * October 30, 2021
 */

using System;

namespace array5 {
    class Program {
        static void Main() {   
            
        int[] a = new int[100];
        int i, d, n, count = 0;
 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  -------------------------------------------------");
        Console.WriteLine("   ARRAY 4: FINDING DUPLICATE ELEMENTS IN AN ARRAY");
        Console.WriteLine("  ------------------------------------------------");
        Console.ResetColor();
            
        Console.Write("\nInput the number of elements to be stored in the array: ");
        n = int.Parse(Console.ReadLine());
            
        Console.Write("\nInput {0} elements in the array: \n", n);

        for (i = 0; i < n; i++) {
            Console.Write("element - {0} : ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
 
        for (i = 0; i < n; i++) {
            for (d = i + 1; d < n; d++) {
                if (a[i] == a[d]) {
                    count++;
                    break;
                }
            }
        }
 
        Console.WriteLine("\nNumber of duplicate elements found: {0}" , count);
        Console.ReadLine();
        
        }
    }
}