namespace SortFunctions;
internal class Program
{
    enum sortedAlgorithms
    {
       Bubble,
       Cocktail,
       Insertion,
       Shell,
       Selection,
    }
    private static void Main(string[] args)
    {
        var rand = new Random();
        int size = rand.Next(20);
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-20, 20);
        }

        Console.WriteLine("Select sort algorithm:\n1.Buble sort.\n2.Cocktail sort.\n3.Insertion sort.\n4.Shell sort.\n5.Selection sort.\n");
        string select;
        select = Console.ReadLine();
        byte select2 = byte.Parse(select);
        Console.WriteLine("Source array: ");
        SortFunctions.Show(arr);
        Console.WriteLine();
        switch (select2)
        {
            case 1:
                {
                    SortFunctions.BubbleSort(arr);
                    break;
                }
            case 2:
                {
                    SortFunctions.CocktailSort(arr);
                    break;
                }
            case 3:
                {
                    SortFunctions.InsertionSort(arr);
                    break;
                }
            case 4:
                {
                    SortFunctions.ShellSort(arr);
                    break;
                }
            case 5:
                {
                    SortFunctions.SelectionSort(arr);
                    break;
                }
            default:
                {
                    Console.WriteLine("Wrong select!");
                    break;
                }
        }

        sortedAlgorithms algorithm = (sortedAlgorithms)Enum.GetValues(typeof(sortedAlgorithms)).GetValue(select2-1);
        Console.WriteLine($"Sorted array by {algorithm}: ");
        SortFunctions.Show(arr);
    }
}