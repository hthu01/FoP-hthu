using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //printarr();
            // sumof2();
            subof2();
            Mul();
            //chuyenvi();
            //sumcphu();
            //sumrc();
            //lotr();
            uptr();
            //Dinhthuc();
            //sparse();
            //equal();
            dvi();
            sole();
            removedup();
            //rm();
            am();
            ten();
            lt();
            gap();
            tong();
            tt();
            tichtrc();
            min();

        }
        static void printarr()
        {
            int[,] a = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(1, 101);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void sumof2()
        {
            Console.Write("Nhap vao size cua ma tran(<5):");
            int s = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] b = new int[s, s];
            int[,] a = new int[s, s];
            int[,] sum = new int[s, s];
            Console.WriteLine("Nhap vao ma tran 1:");
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    a[i, j] = rand.Next(1, 101);
                    b[i, j] = rand.Next(1, 101);
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void subof2()
        {
            Console.Write("Nhap vao size cua ma tran(<5):");
            int s = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] b = new int[s, s];
            int[,] a = new int[s, s];
            int[,] sub = new int[s, s];
            Console.WriteLine("Nhap vao ma tran 1:");
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    a[i, j] = rand.Next(1, 101);
                    b[i, j] = rand.Next(1, 101);
                    sub[i, j] = a[i, j] - b[i, j];
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(sub[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Mul()
        {
            int n;
            Console.Write("Nhập số hàng và số cột của ma trận vuông: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] maTran1 = new int[n, n];
            int[,] maTran2 = new int[n, n];
            int[,] ketQua = new int[n, n];

            Console.WriteLine("Nhập các phần tử cho ma trận thứ nhất:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phần tử [{i},{j}] : ");
                    maTran1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Nhập các phần tử cho ma trận thứ hai:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phần tử [{i},{j}] : ");
                    maTran2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ketQua[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        ketQua[i, j] += maTran1[i, k] * maTran2[k, j];
                    }
                }
            }
        }
        static void chuyenvi()
        {
            Console.WriteLine("Nhap vao so cot va so hang cua ma tran: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            int[,] b = new int[col, row];
            Random ran = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = ran.Next(1, 101);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void sumcphu()
        {
            Console.Write("Nhap vao size:");
            int s = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int d = s - 1, c = 0;
            int[,] a = new int[s, s];
            Random ran = new Random();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    a[i, j] = ran.Next(1, 101);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                sum = sum + a[d, c];
                c++; d--;
            }
            Console.WriteLine($"Tong duong cheo phu la: {sum}");
        }
        static void sumrc()
        {
            Console.Write("Nhap vao size:");
            int s = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[s, s];
            int[] sumr = new int[s];
            int[] sumc = new int[s];
            Random ran = new Random();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    a[i, j] = ran.Next(1, 101);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    sumr[i] += a[i, j];
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    sumc[j] += a[i, j];
                }
            }
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine($"Tong hang {i + 1} la: {sumr[i]}.");
            }
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine($"Tong cot {i + 1} la: {sumc[i]}.");
            }
        }
        static void lotr()
        {
            Console.Write("Nhap vao size:");
            int s = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[s, s];
            Random ran = new Random();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    a[i, j] = ran.Next(1, 101);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    if (j < i)
                    {
                        a[i, j] = 0; ;
                    }
                }
            }
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void uptr()
        {
            Console.Write("Nhập kích thước của ma trận vuông: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] maTran = new int[n, n];
            Console.WriteLine("Nhập các phần tử cho ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phần tử [{i},{j}] : ");
                    maTran[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        maTran[i, j] = 0;
                    }
                }
            }
        }
        static void Dinhthuc()
        {
            int[,] a = new int[3, 3];
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt16(Console.ReadLine());
                    // Console.Write(a[i, j] + " ");
                }
                //Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int det;
            det = a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] + a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] - a[1, 2] * a[2, 1];
            Console.WriteLine(det);
        }
        static void sparse()
        {
            Console.WriteLine("Nhap vao so cot va so hang cua ma tran: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int num = row * col / 2;
            int count = 0;
            bool check = true;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0) { count++; }
                    if (count > num) { check = false; break; }
                }
                if (!check) { break; }
            }
            if (check) { Console.WriteLine("Day la ma tran day dac."); } else Console.WriteLine("Day la ma tran thua thot");
        }
        static void equal()
        {
            Console.Write("Nhap vao hang va cot cua ma tran 1");
            int row1 = Convert.ToInt32(Console.ReadLine()), col1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row1, col1];
            Console.Write("Nhap vao hang va cot cua ma tran 2");
            int row2 = Convert.ToInt32(Console.ReadLine()), col2 = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[row2, col2];
            if ((row1 != row2) || (col1 != col2))
            {
                Console.WriteLine("Bye");
            }
            Random random = new Random();
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    a[i, j] = random.Next(1, 101);
                    b[i, j] = random.Next(1, 101);
                }
            }
            bool check = true;
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    if (a[i, j] != b[i, j]) { check = false; break; }
                }
                if (!check) { break; }
            }
            if (check) { Console.WriteLine("Bang nhau"); } else { Console.WriteLine("Ko bang"); }
        }
        static void dvi()
        {
            Console.Write("Nhập kích thước của ma trận vuông (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] maTran = new int[n, n];

            Console.WriteLine("Nhập các phần tử cho ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phần tử [{i},{j}] : ");
                    maTran[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            bool laDonVi = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && maTran[i, j] != 1)
                        laDonVi = false;
                    if (i != j && maTran[i, j] != 0)
                        laDonVi = false;
                }
            }
            if (laDonVi)
                Console.WriteLine(" Ma trận là ma trận đơn vị.");
            else
                Console.WriteLine("Ma trận KHÔNG phải là ma trận đơn vị.");

        }
        static void sole()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử cho mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử [{i}] : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n Các số lẻ trong mảng là:");
            foreach (int x in arr)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
        static void removedup()
        {
            Console.WriteLine("Nhap vao do dai:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {

                        for (int k = j; k < n - 1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        n--;
                        i--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            { Console.WriteLine(a[i] + " "); }

        }
        static void rm()
        {
            Console.WriteLine("Nhap vao do dai:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = (int)a[0];

            for (int j = 1; j < n - 1; j++)
            {
                for (int i = j + 1; i < n; i++)
                {
                    if (a[i] == a[j]) { a[i] = -1; }
                }
            }
            // int[] b = new int[n];
            /*int v = 0;
            for (int i = 0; i < n; i++)
            {
                
                if (a[i] != -1)
                {
                    b[v] = a[i];
                    v++;
                }
            }*/
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != -1)
                {
                    Console.WriteLine(a[i] + " ");
                }
            }
        }
        static void ten()
        {
            int[] arr = { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };

            Console.WriteLine("Mảng ban đầu:");
            foreach (int x in arr) Console.WriteLine(x);

            int missing = 0;
            for (int i = 10; i <= 20; i++)
            {
                if (!arr.Contains(i))
                {
                    missing = i;
                    break;
                }
            }

            Console.WriteLine($" Số bị thiếu trong khoảng 10-20 là: {missing}");
        }
        static void am()
        {
            int[] arr = { -10, -11, -12, -13, -14, 15, 16, 17 };

            Console.WriteLine("Mảng ban đầu:");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine();

      
            var negatives = arr.Where(x => x < 0).OrderBy(x => x).ToList();

            if (negatives.Count >= 2)
            {
                int sum = negatives[0] + negatives[1];
                Console.WriteLine($" Tổng 2 số âm nhỏ nhất là: {sum}");
            }
            else
            {
                Console.WriteLine("Không có đủ 2 số âm trong mảng!");
            }
        }
        static void lt()
        {
            int[] arr = { -1, -2, -3, 0, 1, 4, 3, 2 };

            Console.WriteLine("Mảng ban đầu:");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            bool consecutive = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                {
                    consecutive = false;
                    break;
                }
            }

            Console.WriteLine($" Mảng có phải dãy liên tiếp không? {consecutive}");
        }
        static void gap()
        {
            int[] arr = { 7, 5, 8, 9, 11, 23, 18 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            int minGap = int.MaxValue;

            for (int i = 1; i < arr.Length; i++)
            {
                int gap = arr[i] - arr[i - 1];
                if (gap < minGap) minGap = gap;
            }

            Console.WriteLine($" Khoảng cách nhỏ nhất giữa các số là: {minGap}");
        }
        static void tt()
        {
            int[] arr = { 7, 5, 85, 9, 11, 23, 18 };
            string digit = "1";

            Console.WriteLine("Mảng ban đầu:");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine();

            bool present = false;
            foreach (int x in arr)
            {
                if (x.ToString().Contains(digit))
                {
                    present = true;
                    break;
                }
            }

            Console.WriteLine(present ? "Có chứa chữ số trong mảng" : "Không có!");
        }
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void tong()
        {
            int[] arr = { 7, 5, 85, 9, 11, 23, 18 };
            int sum = 0;

            foreach (int x in arr)
            {
                if (IsPrime(x)) sum += x;
            }

            Console.WriteLine($"👉 Tổng các số nguyên tố trong mảng là: {sum}");
        }
        static void min()
        {
            int[] arr = { -1, -2, 0, 1, 3, 4, 5, 6 };

            int missing = 1;
            while (arr.Contains(missing))
            {
                missing++;
            }

            Console.WriteLine($"Số dương nhỏ nhất chưa có trong mảng là: {missing}");
        }
        static void tichtrc()
        {
            int[] arr = { 10, 18, 39, 75, 100 };
            int target = 180;
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] == target)
                    {
                        Console.WriteLine($"👉 Cặp số: {arr[i]}, {arr[j]}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy cặp số nào thỏa điều kiện.");
            }
        }
    }
}
