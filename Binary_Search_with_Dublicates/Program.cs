using System;
using System.Linq;

namespace Binary_Search_with_Dublicates
{
    internal class Program
    {      
        static int FisrtOccurence(int[] arr, int low, int high, int key)
        {
            if (high < low)
                return -1;
            int mid = low + ((high - low) / 2);
        
            if (arr[mid] == key)
            {               
                int lowest = FisrtOccurence(arr, 0, mid - 1, arr[mid]);
                if (lowest == -1)
                    return mid;
                else
                    return lowest;
            }
                               
            if (arr[mid] > key)
                return FisrtOccurence(arr, low, mid - 1, key);
            else
                return FisrtOccurence(arr, mid + 1, high, key);
        }
        static void Main(string[] args)
        {          
            // for inputs array
            int n = int.Parse(Console.ReadLine());
            string inputs = Console.ReadLine();
            var arr = inputs.Split(' ').Select(i => int.Parse(i)).ToArray();
         
            // for search array
            int x = int.Parse(Console.ReadLine());
            string inputs2 = Console.ReadLine();
            var searchArr = inputs2.Split(' ').Select(i => int.Parse(i)).ToArray();    

            int[] results = new int[x];
            for (int i = 0; i < searchArr.Length; i++)
            {
                results[i] = FisrtOccurence(arr, 0, arr.Length - 1, searchArr[i]);
            }
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }          
        }
    }
}