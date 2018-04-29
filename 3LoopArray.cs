/*Arrays: Create and initialize in a single line 
an array with the following values: 1, 1, 2, 3, 5, 8. 
Then loop through the array and print out each value.*/                                                                                                             using System;                                                      namespace LoopArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] x = {1, 1, 2, 3, 5, 8};
            foreach (int i in x) {
            
            Console.WriteLine(i);
            
          }
    }
}