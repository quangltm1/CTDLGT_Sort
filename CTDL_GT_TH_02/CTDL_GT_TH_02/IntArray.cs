using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT_TH_02
{
    class IntArray
    {
        private int[] arr { get; set; }
        private int k { get; set; }
        private int x { get; set; }
        private int a;
        private int b;
        private int left { get;set; }
        private int right { get; set; }
        


        public IntArray() { }
        public IntArray(int k)
        {
            this.arr = arr;
            arr = new int[k];
            
        }

        public IntArray(int[] arr)
        {
            this.arr = arr;
        }
        

        public IntArray(IntArray obj) { }


        public bool KiemTraKT(ref int k)
        {
            while (k < 1 || k > 200)
            {

                Console.WriteLine("Nhap lai kich thuoc mang: ");
                k = int.Parse(Console.ReadLine());

            }
            return true;
        }
        public void Nhap()
        {
            for (int i = 0; i< arr.Length; i++)
            {
                Console.Write("arr[" + i + "]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }


        public int TimTuanTu(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int TimNhiPhan(int x)
        {
            int left , right ,mid; left = 0; right = arr.Length - 1;

            do
            {
                mid = (left + right)/2;
                if (arr[mid] == x)
                {
                    return mid;
                }else if(arr[mid] < x)
                {
                    left = mid + 1;
                }else if (arr[mid] > x)
                {
                    right = mid - 1;
                }
            } while (left <= right);
            return -1;
        }

       

        
        public void InterSort(int k)
        {

            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            

        }

        public void BubbleSort (int k )
        {
            for(int i = 0; i < k - 1; i++)
            {
                for(int j = i+1; j < k; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public void SelectionSort(int k)
        {
            for (int i = 0; i < k - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < k; j++)
                    if (arr[min] > arr[j])
                        min = j;
                swap(ref arr[i],ref arr[min]);
            }
        }

        public void InsertionSort(int k)
        {
            for (int i = 1; i < k; i++)
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

        public void set(int left, int right)
        {
            this.left = left;
            this.right = right;
        }

        private static int Partition(int[] arr, int left, int right)
        {
            
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        public void QuickSort(int left, int right)
        {
            this.left = left;
            this.right = right;
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort( left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort( pivot + 1, right);
                }
            }

        }

        public void sort()
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                HeapSort( arr.Length, i);

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                HeapSort( i, 0);
            }
        }

        public void HeapSort( int N, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < N && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < N && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                HeapSort( N, largest);
            }
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
              a = b;
            b= temp;
        }

    }

    
}
