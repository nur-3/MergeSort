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
            
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int eleman_sayısı = int.Parse(Console.ReadLine());
            
            int[] dizi = new int[eleman_sayısı];
            Random rand = new Random();

            for (int i = 0; i < eleman_sayısı; i++)
            {
                dizi[i] = rand.Next() % 100;
            }

            
            Console.WriteLine("\nDizi\n");

            for (int i = 0; i < eleman_sayısı; i++)
            {
                Console.Write(dizi[i]);
                Console.Write(" ");
                
            }

            Console.WriteLine("\ndizinin sıralanmış hali:");

            SortMerge(dizi,0,eleman_sayısı-1 );

            for (int i = 0; i < eleman_sayısı; i++)
            {
                Console.Write(dizi[i]);
                Console.Write(" ");
                

            }Console.ReadLine();

        }

           static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
 
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
 
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
 
            while (left <= eol)
                temp[pos++] = numbers[left++];
 
            while (mid <= right)
                temp[pos++] = numbers[mid++];
 
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
 
        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
 
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
 
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

    
        }
    }

