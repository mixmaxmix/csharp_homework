using System;


namespace quickSort
{
    public class QuickSortClass
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            long calcTime = DateTime.Now.Ticks;

            QuickSort(array, 0, array.Length - 1);

            calcTime -= DateTime.Now.Ticks;

            Console.Write(MathF.Abs(calcTime));
        }

        public static int[] GetArray()
        {
            int[] array = new int[100000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            return array;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
        }

        public static int Partition(int[] array, int left, int right)
        {
            int offset = array[left];
            int leftIndex = left + 1;
            int rightIndex = right;
            while (true)
            {
                while (leftIndex <= rightIndex && array[leftIndex] <= offset)
                {
                    leftIndex += 1;
                }

                while (rightIndex >= leftIndex && array[rightIndex] >= offset)
                {
                    rightIndex -= 1;
                }

                if (rightIndex <= leftIndex)
                {
                    break;
                }

                (array[leftIndex], array[rightIndex]) = (array[rightIndex], array[leftIndex]);
            }

            (array[left], array[rightIndex]) = (array[rightIndex], array[left]);
            return rightIndex;
        }

        public static int[] QuickSort(int[] array, int left, int right)
        {
            if (right <= left)
            {
                return array;
            }
            else
            {
                int offset = Partition(array, left, right);
                QuickSort(array, left, offset - 1);
                QuickSort(array, offset + 1, right);
            }

            return array;
        }
    }
}