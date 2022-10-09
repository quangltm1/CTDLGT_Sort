using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CTDL_GT_TH_02;

namespace CTDLGT_TH_02
{
    class Program
    {
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.WriteLine("TIM KIEM TUAN TU");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.KiemTraKT(ref k);
            obj.Nhap();
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimTuanTu(x);
            if (kq == -1)
            {
                Console.WriteLine("->Khong ton tai {0}!", x);
            }
            else
                Console.WriteLine("->Co {0} tai vi tri {1} ", x, kq);


        }
        static void TestTimNhiPhan()
        {
            int k, x, kq;
            Console.WriteLine("TIM KIEM NHI PHAN");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.KiemTraKT(ref k);
            obj.Nhap();
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();
            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimNhiPhan(x);
            if (kq == -1)
            {
                Console.WriteLine("->Khong ton tai {0}!", x);
            }
            else
                Console.WriteLine("->Co {0} tai vi tri {1} ", x, kq);
        }

        static void InterSort()
        {
            int k, x, kq;
            Console.WriteLine("INTERCHANGE SORT");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.InterSort(k);
            obj.Xuat();
            
        }

        static void BubbleSort()
        {
            int k, x, kq;
            Console.WriteLine("BUBBLE SORT");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.BubbleSort(k);
            obj.Xuat();

        }

        static void SelectionSort()
        {
            int k, x, kq;
            Console.WriteLine("SELECTION SORT");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.SelectionSort(k);
            obj.Xuat();

        }

        static void InsertionSort()
        {
            int k, x, kq;
            Console.WriteLine("INSERTION SORT");
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.InsertionSort(k);
            obj.Xuat();
        }

        static void QuickSort()
        {
            int k, x, kq;
            Console.WriteLine("QUICK SORT");
            Console.Write("Nhap so luong mang: \n");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.set(0, k - 1);
            obj.QuickSort(0, k-1);
            obj.Xuat();

        }

        static void HeapSort()
        {
            int k, x, kq;
            Console.WriteLine("HEAP SORT");
            Console.Write("Nhap so luong mang: \n");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.Nhap();
            Console.WriteLine("Cac phan tu chua sap xep:\n");
            obj.Xuat();
            Console.WriteLine("\nSau khi sap xep:");
            obj.set(0, k - 1);
            obj.sort();
            obj.HeapSort(0, k - 1);
            obj.Xuat();
        }
        static void Main(string[] args)
        {
            //TestTimNhiPhan();
            //TestTimTuanTu();
            //InterSort();
            //BubbleSort();
            //SelectionSort();
            //InsertionSort();
            //QuickSort();
            HeapSort();
        }
    }
}