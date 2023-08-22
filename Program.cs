using System.Collections.Specialized;

namespace BubbleSort
{
    internal class Program
    {
        public static void BubbleSort(List<char> SortList)
        { 
            for (int j=0; j < SortList.Count; j++) 
            {
                for (int i = 0; i < SortList.Count - 1; i++)
                {
                    if (SortList[i] >= SortList[i + 1])
                    {
                        char Temp = SortList[i];
                        SortList[i] = SortList[i + 1];
                        SortList[i + 1] = Temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа сортирующая строку пузырьком. Введите строку и нажмите Enter:");

            List<char> SortList = new List<char>(Console.ReadLine());

            BubbleSort(SortList);
            for (int i = 0; i < SortList.Count; i++)
            {
                Console.Write(SortList[i]);
            }
        }
    }
}