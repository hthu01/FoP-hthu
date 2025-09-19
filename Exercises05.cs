using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exrcises05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[1000];
            Random random = new Random();
            Console.Write("Nhap vao so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i] = random.Next(1, 101));
                Console.Write(" ");
            }
            Console.WriteLine("Trung binh gia tri cua mang la: " + average(num,n));
            Console.Write("Nhap gia tri cu the ban muon tim: ");
            int sv = Convert.ToInt32(Console.ReadLine());
            if (svalue(num,n, sv) == -1)
            {
                Console.WriteLine("Khong tim thay so do.");
            }
            else
            {
                Console.WriteLine($"So {sv} nam tai vi tri {svalue(num,n, sv)+1} cua mang.");
            }
            mm(num, n  );
            Console.Write("Dao nguoc mang so nguyen do: ");
            Reversed(num,n);
            Console.WriteLine();
            Console.Write("Gia tri trung lap trong mang la: ");
            Dup(num, n);
            Console.WriteLine();
            Console.Write("Xoa cac gia tri trung lap do: ");
            Del2(num, n);
            Console.WriteLine();
            Console.WriteLine("Hay nhap vao 10 so nguyen:");
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tam;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        tam = ints[i];
                        ints[i] = ints[j];
                        ints[j] = tam;
                    }
                }
            }
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            
            string sen = Console.ReadLine();
            string word = Console.ReadLine();
            sw(sen, word);

        }
        /// <summary>
        /// Tinh trung binh cac gia tri trong mang
        /// </summary>
        /// <param name="a">la mang cac gia tri</param>
        /// <returns> Gia tri trung binh cua cac gia tri co trong mang</returns>
        static double average(int[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            double av = sum / n;
            return av;
        }

        /// <summary>
        /// Kiểm tra xem một mảng có chứa một giá trị cụ thể hay không.
        /// </summary>
        /// <param name="a">la mang chua gia tri</param>
        /// <param name="b">la gia tri dac biet</param>
        /// <returns></returns>
        static int svalue(int[] a, int n, int b)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b) { return i; }
            }
            return -1;
        }
        /// <summary>
        /// Xóa một phần tử cụ thể khỏi mảng.
        /// </summary>
        /// <param name="a">là mảng chứa các giá trị</param>
        /// <param name="b">là giá trị đặc biệt</param>
        static void del(int[] a, int n, int b)
        {
            int[] ne = new int[n];
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] != b)
                {
                    ne[pos] = a[i];
                    pos++;
                }
            }
            foreach (int i in ne)
            {
                Console.Write(i + " ");
            }
        }
        /// <summary>
        /// Tìm giá trị lớn nhất và nhỏ nhất trong mảng.
        /// </summary>
        /// <param name="a">là mảng chứa các giá trị</param>
        static void mm(int[] a, int n)
        {
            int max = -1, min = 99999;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max) { max = a[i]; }
                if (a[i] < min) { min = a[i]; }
            }
            Console.WriteLine($"Max cua day la: {max}\nMin cua day la: {min}");
        }
        /// <summary>
        /// Đảo ngược một mảng các giá trị số nguyên.
        /// </summary>
        /// <param name="a">là mảng chứa các giá trị</param>
        static void Reversed(int[] a, int n)
        {
            int[] ne = new int[n];
            int pos = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                ne[pos] = a[i];
                pos++;
            }
            foreach (int i in ne)
            { Console.Write(i + " "); }
        }
        /// <summary>
        /// Tìm các giá trị trùng lặp trong một mảng.
        /// </summary>
        /// <param name="a">là mảng chứa các giá trị</param>
        static void Dup(int[] a, int n)
        {
            int[] s = new int[101];
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                s[a[i]]++;
            }
            for (int i = 0; i < 101; i++)
            {
                if (s[i] > 2)
                {
                    Console.Write(i + " ");
                    check = true;
                }
            }
            if (!check) { Console.Write("Khong co so nao trung lap."); }
        }
        /// <summary>
        /// Xóa các phần tử trùng lặp khỏi một mảng.
        /// </summary>
        /// <param name="a">là mảng chứa các giá trị</param>
        static void Del2(int[] a, int n)
        {
            int[] s = new int[1001];
            for (int i = 0; i < n; i++)
            {
                s[a[i]]++;
            }
            int[] ne = new int[n];
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[a[i]] > 0)
                {
                    ne[pos] = a[i];
                    pos++;
                    s[a[i]] = 0;
                }
            }
            for (int i = 0; i < pos; i++)
            {
                Console.Write(ne[i] + " ");
            }
        }
        /// <summary>
        /// kiem tra lieu tu do co trong cau khong
        /// </summary>
        /// <param name="sen">la mot cau duoc nhap tu ban phim</param>
        /// <param name="word">la mot tu duoc nhap tu ban phim</param>
        static void sw(string sen, string word)
        {
            bool check = false;
            string tam = "";
            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i] != ' ')
                {
                    tam =tam+ sen[i];
                }
                else
                {
                    if (tam.ToLower() == word.ToLower())
                    {
                        check = true;
                        break;
                    }
                    else tam = "";
                }    
            }
            if (tam.ToLower() == word.ToLower())
            {
                check = true;
            } 
            if (check) 
            { Console.WriteLine($"Co tu {word} trong {sen}."); }
            else
            {
                Console.WriteLine($"Khong co tu {word} trong {sen}.");
            }
        }
    }
}
