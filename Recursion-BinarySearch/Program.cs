using System;

namespace Recursion_BinarySearch
{
    /* Simple Binary Search - Finding a key from a sorted array
     * Result : Will tell at which index the key was present at , if it is present.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary search!");
            int[] sortedArray = new int[10] {2,5,7,12,34,45,67,78,89,100};
            
            // Case 1 - key present int the array
            int key1 = 78 ;
            Console.WriteLine("Binary search, key : "+ key1 + "\nKey Present or not :" +BinarySearch(sortedArray, key1, 0, (sortedArray.Length-1)));

            Console.WriteLine(Environment.NewLine);
            // Case 2 - key not present in the array
            int key2 = 30;
            Console.WriteLine("Binary search, key : " + key2 + "\nKey Present or not :" + BinarySearch(sortedArray, key2, 0, (sortedArray.Length - 1)));

        }
        static object BinarySearch(int[] sortedArray,int key,int min , int max) 
        {
            if (min > max)
            {
                return "Key cannot be found . Min is greater than max";
            }
            else if (min == max)
            {
                return "Key not present";
            }
            else
            {
                int midpoint = min + (max - min) / 2;
                Console.WriteLine("Midpoint  :" + midpoint);

                if (sortedArray[midpoint] < key)
                {
                    min = midpoint + 1;
                    Console.WriteLine("min : " + min);
                    Console.WriteLine("max : " + max);
                    return BinarySearch(sortedArray, key, min, max);

                }
                else if (sortedArray[midpoint] > key)
                {
                    max = midpoint - 1;
                    Console.WriteLine("min : " + min);
                    Console.WriteLine("max : " + max);
                    return BinarySearch(sortedArray, key, min, max);
                }
                else if (sortedArray[midpoint] == key)
                {
                    
                    return "Key present at " + (midpoint + 1) ;
                }
                
                else
                {
                    return "Key not present";
                }
                    
            }

        }
    }
}
