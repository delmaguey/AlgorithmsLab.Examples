namespace Sorting;


public static class QuickSort
{
    public static void Sort(int[] arr, int low, int high)
    {
        // Validate if array is null or with just one element, in that case, there's nothing to sort
        if( arr ==null || arr.Length == 0)
            return;

        // If the array has just two elements, swap them if they are unsorted.
        if (arr.Length == 2 && arr[0] > arr[1])
            Swap(arr, low, high);

        if (low < high)
        {
            // pivotIndex is the index where the pivot ends up
            int pivotIndex = Partition(arr, low, high);

            // Recursively sort elements before and after partition
            Sort(arr, low, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, high);
        }
        
    }

    public static int Partition(int[] arr, int low, int high)
    {
        // Selecting last element as pivot
        int pivot = arr[high];
        int i = low - 1;

        for (int j=low; j < high; j++)
        {
            // if the item is smaller than or equal to pivot, swap them
            if(arr[j]<=pivot)
            {
                i++;
                Swap(arr,i,j);
            }
        }

        // Swap the pivot element with the element at index i+1
        Swap(arr,i+1, high);
        return i+1;
    }


    private static void Swap(int[] arr,int a, int b)
    {
        int tmp = arr[a];
        arr[a] = arr[b];
        arr[b] = tmp;
    }
}