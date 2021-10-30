/*
 * ITN114-A25-4: Array 2
 * Sir Rodulfo L. Dorado, Jr., MSc.
 * Sherry Eunice T. Cunanan, BSIT, 4th Year
 * October 30, 2021
 */

using System;

namespace array2 {
    class Program {
        
        public static void Main()  {
            
            int i,n;
            int[] a= new int[100];
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  ---------------------------------------------------------");
            Console.WriteLine("   ARRAY 2: READ AND DISPLAY ARRAY ELEMENTS IN REVERSE ORDER");
            Console.WriteLine("  ----------------------------------------------------------");
            Console.ResetColor();
            
            while (true) {

                Console.Write("\nInput the number of elements to store in the array: ");
                n = int.Parse(Console.ReadLine());   
                
                Console.Write("\nThe elements in the array are:\n",n);
                for(i=0;i<n;i++) {
                    
                    Console.Write("element - {0} : ",i);
                    a[i] = int.Parse(Console.ReadLine());
                }
                
                Console.Write("\nThe values stored in the array are: \n");
                for(i=0;i<n;i++) {
                    
                    Console.Write("{0} ",a[i]);
                }
                
                Console.Write("\n\nReverse Order:\n");
                for(i=n-1;i>=0;i--) {
                    
                    Console.Write("{0} ",a[i]);
                }
                
                Console.Write("\n\n");
            }
        }
    }
}