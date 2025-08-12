using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_01
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            start:
                Console.WriteLine("Hay chon chuong trinh ban muon thuc hien:");
                Console.WriteLine("0. Thoat khoi chuong trinh");
                Console.WriteLine("1. Tong hai so");
                Console.WriteLine("2. Doi gia tri 2 bien");
                Console.WriteLine("3. Nhan hai so thuc");
                Console.WriteLine("4. Doi feet sang met");
                Console.WriteLine("5. Doi tu do C sang do F");
                Console.WriteLine("6. Doi tu do F sang do C ");
                Console.WriteLine("7. Tim size cua kieu du lieu");
                Console.WriteLine("8. In ra gia tri ASCII cua ki tu");
                Console.WriteLine("9. Tinh dien tich hinh tron");
                Console.WriteLine("10. Tinh dien tich hinh vuong");
                Console.WriteLine("11. Doi so ngay sang so nam, thang, ngay");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0: break;
                    case 1: Ex01(); goto start;
                    case 2: Ex02(); goto start;
                    case 3: Ex03(); goto start;
                    case 4: Ex04(); goto start;
                    case 5: Ex05a(); goto start;
                    case 6: Ex05b(); goto start;
                    case 7: Ex06(); goto start;
                    case 8: Ex07(); goto start;
                    case 9: Ex08(); goto start;
                    case 10: Ex09(); goto start;
                    case 11: Ex10(); goto start;

                }
                Console.ReadKey();
            }
            static void Ex01()
            {
                int a, b, sum;
                Console.Write("Nhap vao so a: "); a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao so b: "); b = Convert.ToInt32(Console.ReadLine());
                sum = a + b;
                Console.WriteLine("Tong cua 2 so la: {0}", sum);
            }
            static void Ex02()
            {
                int a, b, c;
                Console.Write("Nhap vao so a: "); a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao so b: "); b = Convert.ToInt32(Console.ReadLine());
                c = a; a = b; b = c;
                Console.WriteLine("Sau khi doi a la {0} va b la {1}", a, b);
            }
            static void Ex03()
            {
                double a, b, m;
                Console.Write("Nhap vao so a: "); a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap vao so b: "); b = Convert.ToDouble(Console.ReadLine());
                m = a * b;
                Console.WriteLine("Tich cua hai so la: " + m);
            }
            static void Ex04()
            {
                double f, m;
                Console.Write("Nhap vao so feet muon doi: "); f = Convert.ToDouble(Console.ReadLine());
                m = f * 0.3048;
                Console.WriteLine("Doi: {0}f = {1}m", f, m);
            }
            static void Ex05a()
            {
                double c, f;
                Console.Write("Nhap vao so do C: "); c = Convert.ToDouble(Console.ReadLine());
                f = (c * 1.8) + 32;
                Console.WriteLine("Doi {0} doC = {1} doF", c, f);
            }
            static void Ex05b()
            {
                double c, f;
                Console.Write("Nhap vao so do F: "); f = Convert.ToDouble(Console.ReadLine());
                c = (f - 32) / 1.8;
                Console.WriteLine("DOi {0} doF = {1} doC", f, c);
            }
            static void Ex06()
            {
                double s;
                int d;
            start:
                Console.WriteLine("1. int       2. long      3. float");
                Console.WriteLine("4. double    5. bool      6. char");
                Console.Write("Hay chon kieu du lieu ban muon biet Size (nhap so):");
                d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1: Console.WriteLine("Size cua kieu du lieu int la: " + sizeof(int) + " byte"); break;
                    case 2: Console.WriteLine("Size cua kieu du lieu long la: " + sizeof(long) + " byte"); break;
                    case 3: Console.WriteLine("Size cua kieu du lieu float la: " + sizeof(float) + " byte"); break;
                    case 4: Console.WriteLine("Size cua kieu du lieu double la: " + sizeof(double) + " byte"); break;
                    case 5: Console.WriteLine("Size cua kieu du lieu bool la: " + sizeof(bool) + " byte"); break;
                    case 6: Console.WriteLine("Size cua kieu du lieu char la: " + sizeof(char) + " byte"); break;
                    default: Console.WriteLine("Vui long nhap lai so:"); goto start;
                }
            }
            static void Ex07()
            {
                int a;
                Console.Write("Nhap mot ki tu: ");
                a = Console.Read();
                Console.ReadLine();
                Console.WriteLine("Gia tri ASCII cua ki tu la:" + a);
            }
            static void Ex08()
            {
                double r, s;
                Console.WriteLine("Hay nhap vao ban kinh hinh tron: ");
                r = Convert.ToDouble(Console.ReadLine());
                s = r * r * 3.14;
                Console.WriteLine($"Dien tich cua hinh tron co ban kinh {r} la {s}");
            }
            static void Ex09()
            {
                long a, s;
                Console.WriteLine("Hay nhap vao canh hinh vuong: ");
                a = Convert.ToInt64(Console.ReadLine());
                s = a * a;
                Console.WriteLine($"Dien tich cua hinh vuong co canh {a} la {s}");
            }
            static void Ex10()
            {
                Console.Write("Nhap so ngay can doi sang nam, tuan, ngay:");
                int day = Convert.ToInt32(Console.ReadLine());
                int nday = day;
                int year, week, days;
                year = day / 365; day = day - (year * 365);
                week = day / 7; day = day - week * 7;
                days = day;
                Console.WriteLine($"{nday} ngay = {year} nam, {week} tuan, {days} ngay.");

            }

        }

 }

