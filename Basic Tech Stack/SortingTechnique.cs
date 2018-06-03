using System;

namespace Basic_Tech_Stack
{
    internal class SortingTechnique
    {
        /// <summary>
        ///  A function to implement bubble sort,
        ///  that works by repeatedly swapping the adjacent elements if they are in wrong order. 
        /// </summary>
        public static void BubbleSort()
        {

            try
            {

                Console.WriteLine("Enter the size of array");
                int intSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the array elements");
                int[] arr = new int[intSize];
                for (int i = 0; i < intSize; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Array elements Before sorting :");

                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < intSize - 1; i++)
                {
                    // Last i elements are already in place
                    for (int j = 0; j < intSize - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Array elements after Sorting: ");
                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }


        }

        /// <summary>
        /// A function to implement Quick Sort
        ///  QuickSort is a Divide and Conquer algorithm. 
        ///  It picks an element as pivot and partitions the given array around the picked pivot.
        /// </summary>
        public static void QuickSort()
        {
            try
            {

                Console.WriteLine("Enter the size of array");
                int intSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the array elements");
                int[] arr = new int[intSize];
                for (int i = 0; i < intSize; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Array elements Before sorting :");

                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Qsort(arr, 0, intSize - 1);
                Console.WriteLine("Array elements after Sorting: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }




        }
        public static void Qsort(int[] arr, int low, int high)
        {
            try
            {

                if (low < high)
                {
                    /* par is partitioning index, arr[par] is now at right place */
                    int par = Partition(arr, low, high);

                    // Separately sort elements before
                    // partition and after partition
                    Qsort(arr, low, par - 1);
                    Qsort(arr, par + 1, high);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }

        }
        private static int Partition(int[] arr, int low, int high)
        {

            
                int pivot = arr[high]; //index
                int i = low - 1; //Index of Smaller Element

                for (int j = low; j < high; j++)
                {
                    // If current element is smaller than or equal to pivot
                    if (arr[j] < pivot)
                    {
                        i++; // increment index of smaller element
                        int temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;
                    }

                }
                //Swap two elements 
                int temp = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp;
                return i + 1;
            
            
                
            


        }

        /// <summary>
        /// Function to Sort an array using Insertion Sort
        /// </summary>
        private static void InsertionSort()
        {
            try
            {

                Console.WriteLine("Enter the size of array");
                int intSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the array elements");
                int[] arr = new int[intSize];
                for (int i = 0; i < intSize; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Array elements Before sorting :");

                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                for (int i = 1; i < intSize; i++)
                {
                    int key = arr[i];
                    int j = i - 1;


                    /* Move elements of arr[0..i-1], that are  greater than key, to one position ahead
                        of their current position */
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;

                    }
                    arr[j + 1] = key;
                }
                Console.WriteLine("Array elements after Sorting: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }

        }

        /// <summary>
        /// The selection sort algorithm sorts an array by repeatedly finding the minimum element 
        /// from unsorted part and putting it at the beginning.
        /// </summary>
        private static void SelectionSort()
        {
            try
            {

                Console.WriteLine("Enter the size of array");
                int intSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the array elements");
                int[] arr = new int[intSize];
                for (int i = 0; i < intSize; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Array elements Before sorting :");

                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < intSize - 1; i++)
                {
                    // Find the minimum element in unsorted array
                    int min = i;
                    for (int j = i + 1; j < intSize; j++)
                    {
                        if (arr[j] < arr[min])
                        {
                            min = j;
                        }

                    }
                    // Swap the found minimum element with the first element
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;

                }
                Console.WriteLine("Array elements after Sorting: ");
                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }

        }

        /// <summary>
        /// Merge Sort is a Divide and Conquer algorithm. 
        /// It divides input array in two halves, calls itself for the two halves and then merges the two sorted halves.
        /// </summary>
        private static void MergeSort()
        {
            try
            {

                Console.WriteLine("Enter the size of array");
                int intSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the array elements");
                int[] arr = new int[intSize];
                for (int i = 0; i < intSize; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Array elements Before sorting :");

                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                Msort(arr, 0, intSize - 1);

                Console.WriteLine("Array elements after Sorting: ");
                for (int i = 0; i < intSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }

        }

        /// <summary>
        ///  low is for left index and high is right index of the sub-array of arr to be sorted
        /// </summary>
       
        private static void Msort(int[] arr, int low, int high)
        {
            try
            {

                if (low < high)
                {


                    int mid = (low + high) / 2;

                    // Sort first and second halves
                    Msort(arr, low, mid);
                    Msort(arr, mid + 1, high);

                    MergeSort(arr, low, mid, high);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }

        private static void MergeSort(int[] arr, int l, int m, int r)
        {
            try
            {

                int n1 = m - l + 1;
                int n2 = r - m;

                /* Create temp arrays */
                int[] L = new int[n1];
                int[] R = new int[n2];

                /*Copy data to temp arrays*/
                for (int ii = 0; ii < n1; ++ii)
                {
                    L[ii] = arr[l + ii];
                }
                for (int jj = 0; jj < n2; ++jj)
                {
                    R[jj] = arr[m + 1 + jj];
                }

                /* Merge the temp arrays */

                // Initial indexes of first and second subarrays
                int i = 0, j = 0;

                // Initial index of merged subarry array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                /* Copy remaining elements of L[] if any */
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                /* Copy remaining elements of R[] if any */
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }
        public SortingTechnique()
        {
            try
            {
                string strMyChoice = "y";

                while (strMyChoice == "y" || strMyChoice == "Y" || strMyChoice == "yes" || strMyChoice == "YES" || strMyChoice == "Yes")
                {
                    Console.WriteLine("----------------------");

                    Console.WriteLine("1. BubbleSort");
                    Console.WriteLine("2. QuickSort ");
                    Console.WriteLine("3. Insertion Sort");
                    Console.WriteLine("4. Selection Sort");
                    Console.WriteLine("5. Merge Sort");
                    Console.WriteLine("----------------------");

                    Console.WriteLine();



                    Console.WriteLine("Enter your choice");
                    int intChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------");

                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("........bubble Sort..........");
                            BubbleSort();

                            break;

                        case 2:
                            Console.WriteLine("........Quick Sort..........");

                            QuickSort();
                            break;
                        case 3:
                            Console.WriteLine("........Insertion Sort..........");

                            InsertionSort();
                            break;
                        case 4:
                            Console.WriteLine("........Selection Sort..........");

                            SelectionSort();
                            break;
                        case 5:
                            Console.WriteLine("........Merge Sort.........");

                            MergeSort();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!!! Enter correct choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue doing Sorting  (y/n)");
                    strMyChoice = Console.ReadLine();



                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }
    }
}