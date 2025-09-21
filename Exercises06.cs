using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercises06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex01
            //1. Create a jagged array 
            int[][] a = new int[4][]
            {
                new int[] { 1, 1,1,1,1 },
                new int[] { 2, 2},
                new int[] { 3, 3,3,3,3 },
                new int[] { 4, 4 }
            };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            //2. Create functions to implement tasks
            Random random = new Random();
            Console.Write("Nhap vao so hang: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[] col = new int[row];
            int[][] arr = new int[row][];
            for (int i = 0; i < row; i++)
            {
                Console.Write($"Nhap vao so cot thu {i + 1}: ");
                col[i] = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[col[i]];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col[i]; j++)
                {
                    arr[i][j] = random.Next(1, 101);
                }
            }
            print(arr);
            max(arr);
            Sort(arr);
            print(arr);
            PrintPrime(arr);
            Console.Write("Nhap vao so ban can tim: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Search(arr, num);

            //EX02
            //Khởi tạo mảng
            object[][][] groups = new object[3][][];
            Taomang(groups);
            bool stop=false;
            while (!stop)
            {
                Console.WriteLine("Moi ban chon ham muon thuc hien:\n\t1.In danh sach tat ca thanh vien.\n\t2. In thong tin nhan vien khi biet ID\n\t3. In thong tin nhan vien hoan thanh nhieu task nhat");
                string s = Console.ReadLine();
                int n;
                while (!int.TryParse(s, out n))
                {
                    Console.WriteLine("Vui long nhap lai chuong trinh ban muon chon. (1,2,3)");
                }
                switch (n)
                {
                    case 1: printname(groups); break;
                    case 2:
                        {
                            Console.WriteLine("Hay nhap vao ID nhan vien: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            printinfo(groups, num1);
                            break;
                        }
                    case 3:
                        {
                            highest(groups); break;
                        }
                    default: Console.WriteLine("Khong co chuong trinh nay. Hay nhap lai (1,2,3)."); break;

                }
                Console.Write("Ban co muon thuc hien tiep (co nhap 1/khong nhap 0): ");
                int so=Convert.ToInt32(Console.ReadLine());
                if (so == 0) { stop = true; }
            }
            end:
            Console.WriteLine("Xin chao tam biet!");

        }

        /// <summary>
        /// in mảng ra
        /// </summary>
        /// <param name="a">la mảng đưa vào</param>
        static void print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// tìm ra số lớn nhất hàng và số lớn nhất mảng
        /// </summary>
        /// <param name="a">là mảng đưa vào</param>
        static void max(int[][] a)
        {
            int[] maxrow = new int[a.Length];
            int maxa = a[0][0];
            for (int i = 0; i < a.Length; i++)
            {
                maxrow[i] = a[i][0];
                for (int j = 1; j < a[i].Length; j++)
                {
                    if (a[i][j] > maxrow[i]) { maxrow[i] = a[i][j]; }
                }
                Console.WriteLine($"So lon nhat cua dong {i + 1} la: {maxrow[i]}.");
                if (maxrow[i] > maxa)
                {
                    maxa = maxrow[i];
                }
            }
            Console.WriteLine($"So lon nhat cua mang la: {maxa}");
        }
        /// <summary>
        /// Sắp xếp lại theo thứ tự tăng dần trong hàng
        /// </summary>
        /// <param name="a">là mảng đưa vào</param>
        static void Sort(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Array.Sort(a[i]);
                }
            }
        }
        /// <summary>
        /// Kiểm tra coi số đó có phải số nguyên tố không
        /// </summary>
        /// <param name="n">là số kiểm tra</param>
        /// <returns></returns>
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// In ra các số nguyên tố có trong mảng
        /// </summary>
        /// <param name="a">là mảng đưa vào</param>
        static void PrintPrime(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (IsPrime(a[i][j]))
                        Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Tìm kiếm một số có trong mảng hay không
        /// </summary>
        /// <param name="a">là mảng đưa vào</param>
        /// <param name="num">là số cần tìm</param>
        static void Search(int[][] a, int num)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == num)
                        Console.WriteLine($"{num} nam o hang {i + 1} va cot {j + 1}.");
                }
            }
        }
        /// <summary>
        /// Khởi tạo mảng
        /// </summary>
        static void Taomang(object[][][] groups)
        {
            // Nhóm 1 có 5 thành viên
            groups[0] = new object[5][];
            groups[0][0] = new object[] { 101, new object[] { "Tran A", 12 } };
            groups[0][1] = new object[] { 102, new object[] { "Nguyen B", 8 } };
            groups[0][2] = new object[] { 103, new object[] { "Van C", 15 } };
            groups[0][3] = new object[] { 104, new object[] { "Pham  D", 9 } };
            groups[0][4] = new object[] { 105, new object[] { "Huynh E", 11 } };

            // Nhóm 2 có 3 thành viên
            groups[1] = new object[3][];
            groups[1][0] = new object[] { 201, new object[] { "Nguyen F", 7 } };
            groups[1][1] = new object[] { 202, new object[] { "Trinh G", 10 } };
            groups[1][2] = new object[] { 203, new object[] { "Duong H", 6 } };

            // Nhóm 3 có 6 thành viên
            groups[2] = new object[6][];
            groups[2][0] = new object[] { 301, new object[] { "Hoa I", 14 } };
            groups[2][1] = new object[] { 302, new object[] { "Vong J", 19 } };
            groups[2][2] = new object[] { 303, new object[] { "Le K", 5 } };
            groups[2][3] = new object[] { 304, new object[] { "Phan L", 16 } };
            groups[2][4] = new object[] { 305, new object[] { "Tram M", 9 } };
            groups[2][5] = new object[] { 306, new object[] { "Hoang Thi N", 13 } };
        }
        /// <summary>
        /// In ra danh sách thành viên
        /// </summary>
        /// <param name="a">Là mảng đưa vào</param>
        static void printname(object[][][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"--- Group {i + 1} ---");
                for (int j = 0; j < a[i].Length; j++)
                {
                    int id = (int)a[i][j][0];
                    object[] info = (object[])a[i][j][1];
                    string name = (string)info[0];
                    int tasks = (int)info[1];

                    Console.WriteLine($"ID: {id}, Ten: {name}, Nhiem vu: {tasks}");
                }
                Console.WriteLine();
            }
        }
         /// <summary>
        /// In ra nhân viên khi nhập ID
        /// </summary>
        /// <param name="a">là mảng đưa vào</param>
        /// <param name="num">là ID cần tìm</param>
        static void printinfo(object[][][] a, int num)
        {
            bool check = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    int id = (int)a[i][j][0];
                    if (num == id)
                    {
                        object[] info = (object[])a[i][j][1];
                        string name = (string)info[0];
                        int tasks = (int)info[1];
                        Console.WriteLine($"ID: {id}, Ten: {name}, Nhiem vu: {tasks}");
                        check = true;
                        break;
                    }
                }
                if (check) { break; }
            }
            if (!check) { Console.WriteLine("Khong co nhan vien do."); }
        }
         /// <summary>
         /// In ra nhân viên hoàn thành nhiều nhất
         /// </summary>
         /// <param name="a"> là mảng đưa vào</param>
        static void highest(object[][][] a)
        {
            int finalid=0, finaltasks=0;
            string fname="";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    int id = (int)a[i][j][0];
                    object[] info = (object[])a[i][j][1];
                    string name = (string)info[0];
                    int tasks = (int)info[1];
                    if (tasks > finaltasks) { finalid = id; finaltasks = tasks; fname = name; }
                }
            }
            Console.WriteLine($"ID: {finalid}, Ten: {fname}, Nhiem vu: {finaltasks}");

        }
    }
}

