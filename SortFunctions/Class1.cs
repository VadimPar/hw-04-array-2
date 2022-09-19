namespace SortFunctions
{
    public class SortFunctions
    {
        //1
        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i + 1 < arr.Length; i++)
            {
                for (int j = 0; j + 1 < arr.Length - i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        //2
        public static void CocktailSort(int[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped == true)
            {

                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
        }
        //3
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        //4
        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;

            for (int k = n / 2; k > 0; k /= 2)
            {
                for (int i = k; i < n; i += 1)
                {
                    int temp = arr[i];

                    int j;
                    for (j = i; j >= k && arr[j - k] > temp; j -= k)
                        arr[j] = arr[j - k];

                    arr[j] = temp;
                }
            }
        }
        //5
        public static void SelectionSort(int[] arr)
        {
            int index;
            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                    }
                }
                if (arr[index] == arr[i])
                    continue;
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }

        public static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}