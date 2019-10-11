using System;

namespace AlgorithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int m = (1 + 6) / 2;
            int[] arr = new int[] { 0,1,2,3,4,5,6,7,8,9,12,13};
            int r = BinarySearch(arr, 0, arr.Length - 1, 5);
            Console.WriteLine(r);
            Console.WriteLine("-----------");
            int[] arr2 = new int[] {1,5,9,2,11,4,51,0,3,33,6 };
            int[] arr3 = SelectSort(arr2);
            foreach(var s in arr3)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        static int BinarySearch(int[] arr,int low,int high,int key)
        {
            int mid = (low + high) / 2;
            if (low > high)
                return -1;
            else
            {
                if (arr[mid] == key)
                    return mid;
                else if(arr[mid]>key)
                {
                    return BinarySearch(arr, low, mid - 1, key);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, high, key);
                }
            }
        }

        static int[] SelectSort(int[] arr)
        {
            int temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                int minVal = arr[i];
                int minIndex = i;

                for(int j=i+1;j<arr.Length;j++)
                {
                    if(minVal>arr[j])
                    {
                        minVal = arr[j];
                        minIndex = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return arr;
        }


    }
}
