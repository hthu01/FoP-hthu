using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Nhap vao chuong trinh ban muon thuc hien.");
            Console.WriteLine("0. Thoat khoi chuong trinh.");
            Console.WriteLine("1. Chuong trinh tim ra so lon nhat trong cac so da cho.");
            Console.WriteLine("2. Chuong trinh tinh giai thua cua mot so.");
            Console.WriteLine("3. Chuong trinh kiem tra mot so co phai so nguyen to hay khong.");
            Console.WriteLine("4. Chuong trinh in ra tat ca cac so nguyen to nho hon mot so N và N so nguyen to dau tien.");
            Console.WriteLine("5. Chuong trinh kiem tra so hoan hao va in ra so hoan hao nho hon 1000.");
            Console.WriteLine("6. Chuong trinh kiem tra mot chuoi co phai la chuoi pangram khong.");
            int n=Convert.ToInt32(Console.ReadLine());
            bool stop = false;
            switch (n)
            {
                case 0: { Console.WriteLine("Xin chao tam biet.");stop = true; break; }
                case 1:
                    {
                        Maxof3(3, 4, 5);
                        Maxs(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18);
                        break;
                    } 
                case 2:
                    {
                        Console.Write("Nhap vao mot so ban muon tinh giai thua.");
                        int num=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Factorial(num));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Nhap vao mot so ban muon kiem tra phai so nguyen to khong: ");
                        int num= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Isprime(num));
                        break;
                    }
                case 4:
                    {
                        Console.Write("Nhap vao so N:");
                        long num= Convert.ToInt32(Console.ReadLine());
                        Prime(num); break;
                    }
                case 5:
                    {
                        Console.Write("Nhap vao so ban muon kiem tra phai so hoan hao khong: ");
                        int num=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Perfect(num));
                        PrintPerfect();
                        break;
                    } 
                case 6:
                    {
                        Console.Write("Nhap vao chuoi ban muon kiem tra: ");
                        string s=Console.ReadLine();
                        Console.WriteLine(Ispangram(s)); break;
                    }         
            }
            if (!stop) { goto start; }
        }
        static int Maxof3(int x, int y, int z)
        {
            int max = x;
            if (y > max) { max = y; }
            if (z > max) { max = z; }
            return max;
        }
        //fix theo hinh
        static int Maxs(int a, params int[] b)
        {
            int max = a;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max) { max = b[i]; }
            }
            return max;
        }
        static int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static bool Isprime(int n)
        {
            if ((n == 2) || (n == 3))
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return false;  }
            }
            return true;
        }
        static void Prime(long n)
        {
            bool[] isprime = new bool[1000001];
            for (int i = 2; i <= 1000000; i++)
            {
                isprime[i] = true;
            }
            isprime[1] = false; isprime[0] = false;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    isprime[i * j] = false;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (isprime[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            int d = 0;
            for (int i = 2; i <= 1000000; i++)
            {
                if (isprime[i] == true)
                {
                    Console.Write(i + " ");
                    d++;
                }
                if (d == n) { break; }
            }
        }
        static bool Perfect(int num)
        {
            int d = 1;
            for (int i=2;i<num;i++)
            {
                if (num%i==0) { d+=i; }
            }    
            if (num==d) { return true; }
            else { return false; }
        }
        static void PrintPerfect()
        {
            for (int i=0;i<1000;i++)
            {
                if (Perfect(i)) { Console.Write(i + " "); }
            }    
        }
        static bool Ispangram(string s)
        {
            string alp = " ";
            for (int i='a';i<='z';i++)
                { alp += (char)i; }
            s=s.ToLower();
            foreach (char c in alp)
            {
                if (!s.Contains(c))
                {
                    return false;
                }    
            }
            return true;
        }
        
    }
}
