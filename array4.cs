/*
 * ITN114-A25-4: Array 4
 * Sir Rodulfo L. Dorado, Jr., MSc.
 * Sherry Eunice T. Cunanan, BSIT, 4th Year
 * October 30, 2021
 */

using System;

namespace array4 {
    class Program {
        public static void Main() {
            
        int[] a = new int[100];
        int[] f = new int[100];
        int[] s = new int[100];
        
        int i, n;
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  ------------------------------------");
        Console.WriteLine("   ARRAY 4: COPYING OF ARRAY ELEMENTS");
        Console.WriteLine("  --------------------------------------");
        Console.ResetColor();
            
            Console.Write("\nInput the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());
            
            Console.Write("\nInput {0} elements in the array: \n", n);
            for (i = 0; i < n; i++) {
                Console.Write("element - {0} : ", i);
                f[i] = int.Parse(Console.ReadLine());
            }
            
            for (i = 0; i < n; i++) {
                s[i] = f[i];
            }
            
            Console.WriteLine("\nFirst array elements:");
            for (i = 0; i < n; i++) {
                Console.Write(f[i]+"  ");
            }
            
            Console.WriteLine("\n\nCopied array elements:");
            for (i = 0; i < n; i++) {
                Console.Write(s[i]+"  ");
            }
            
            Console.ReadLine();
        }
    }
}