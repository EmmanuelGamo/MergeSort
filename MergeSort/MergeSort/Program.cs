using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
       
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            mergeSort(Numbers, 0, Numbers.Length - 1);
            Console.Write("\n Sorted Using Merge Sort: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        
        static public void mergeSort(int[] Numbers, int x, int y)
        {
            if (x < y)
            {
                int q = (x + y) / 2;
                mergeSort(Numbers, x, q);
                mergeSort(Numbers, q + 1, y);
                merge(Numbers, x, q, y);
            }
        }
        static public void merge(int[] Numbers, int x, int q, int y)
        {
            int i, j, k;
            int n1 = q - x + 1;
            int n2 = y - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = Numbers[x + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = Numbers[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = x;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    Numbers[k] = L[i];
                    i++;
                }
                else
                {
                    Numbers[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                Numbers[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                Numbers[k] = R[j];
                j++;
                k++;
            }
        }
        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }
    }
}