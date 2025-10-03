using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                // Bài 1: Nhập và in chuỗi
                Console.Write("Nhập chuỗi: ");
                string s1 = Console.ReadLine();
                Console.WriteLine("Chuỗi bạn nhập là: " + s1);

                // Bài 2: Độ dài chuỗi 
                Console.Write("Nhập chuỗi: ");
                string s2 = Console.ReadLine();
                int len = 0;
                foreach (char c in s2) len++;
                Console.WriteLine("Độ dài chuỗi: " + len);

                // Bài 3: In từng ký tự
                Console.Write("Nhập chuỗi: ");
                string s3 = Console.ReadLine();
                foreach (char c in s3) Console.Write(c + " ");
                Console.WriteLine();

                // Bài 4: In ngược chuỗi
                Console.Write("Nhập chuỗi: ");
                string s4 = Console.ReadLine();
                for (int i = s4.Length - 1; i >= 0; i--) Console.Write(s4[i]);
                Console.WriteLine();

                // Bài 5: Đếm số từ
                Console.Write("Nhập chuỗi: ");
                string s5 = Console.ReadLine().Trim();
                int words = 0; bool trongTu = false;
                foreach (char c in s5)
                {
                    if (c != ' ' && !trongTu) { words++; trongTu = true; }
                    else if (c == ' ') trongTu = false;
                }
                Console.WriteLine("Số từ: " + words);

                // Bài 6: So sánh 2 chuỗi
                Console.Write("Chuỗi 1: ");
                string a6 = Console.ReadLine();
                Console.Write("Chuỗi 2: ");
                string b6 = Console.ReadLine();
                bool same = true;
                if (a6.Length != b6.Length) same = false;
                else
                    for (int i = 0; i < a6.Length; i++)
                        if (a6[i] != b6[i]) { same = false; break; }
                Console.WriteLine(same ? "Giống nhau" : "Khác nhau");

                // Bài 7: Đếm chữ cái, số, ký tự đặc biệt
                Console.Write("Nhập chuỗi: ");
                string s7 = Console.ReadLine();
                int alpha = 0, digit = 0, special = 0;
                foreach (char c in s7)
                {
                    if (char.IsLetter(c)) alpha++;
                    else if (char.IsDigit(c)) digit++;
                    else special++;
                }
                Console.WriteLine($"Chữ: {alpha}, Số: {digit}, Ký tự khác: {special}");

                // Bài 8: Copy chuỗi
                Console.Write("Nhập chuỗi: ");
                string s8 = Console.ReadLine();
                string copy = "";
                foreach (char c in s8) copy += c;
                Console.WriteLine("Copy: " + copy);

                // Bài 9: Đếm nguyên âm & phụ âm
                Console.Write("Nhập chuỗi: ");
                string s9 = Console.ReadLine().ToLower();
                int vowel = 0, cons = 0;
                foreach (char c in s9)
                {
                    if ("aeiou".Contains(c)) vowel++;
                    else if (char.IsLetter(c)) cons++;
                }
                Console.WriteLine($"Nguyên âm: {vowel}, Phụ âm: {cons}");

                // Bài 10: Ký tự xuất hiện nhiều nhất
                Console.Write("Nhập chuỗi: ");
                string s10 = Console.ReadLine().ToLower();
                char maxChar = ' '; int maxCount = 0;
                for (int i = 0; i < s10.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < s10.Length; j++)
                        if (s10[i] == s10[j]) count++;
                    if (count > maxCount) { maxCount = count; maxChar = s10[i]; }
                }
                Console.WriteLine($"Ký tự '{maxChar}' xuất hiện {maxCount} lần");

                // Bài 11: Sắp xếp ký tự trong chuỗi
                Console.Write("Nhập chuỗi: ");
                string s11 = Console.ReadLine().Replace(" ", "");
                char[] arr11 = s11.ToCharArray();
                Array.Sort(arr11);
                Console.WriteLine("Sau sắp xếp: " + string.Join(" ", arr11));

                // Bài 12: Sắp xếp nhiều chuỗi (bubble sort)
                Console.Write("Nhập số chuỗi: ");
                int n12 = int.Parse(Console.ReadLine());
                string[] arr12 = new string[n12];
                for (int i = 0; i < n12; i++) arr12[i] = Console.ReadLine();
                for (int i = 0; i < n12 - 1; i++)
                    for (int j = 0; j < n12 - i - 1; j++)
                        if (arr12[j].CompareTo(arr12[j + 1]) > 0)
                        {
                            string tmp = arr12[j]; arr12[j] = arr12[j + 1]; arr12[j + 1] = tmp;
                        }
                Console.WriteLine("Sau sắp xếp:");
                foreach (string str in arr12) Console.WriteLine(str);

                // Bài 13: Trích chuỗi con
                Console.Write("Chuỗi: ");
                string s13 = Console.ReadLine();
                Console.Write("Vị trí bắt đầu: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Độ dài: ");
                int length = int.Parse(Console.ReadLine());
                string sub = "";
                for (int i = start; i < start + length && i < s13.Length; i++) sub += s13[i];
                Console.WriteLine("Chuỗi con: " + sub);

                // Bài 14: Kiểm tra substring có tồn tại
                Console.Write("Chuỗi: ");
                string s14 = Console.ReadLine();
                Console.Write("Chuỗi con: ");
                string sub14 = Console.ReadLine();
                Console.WriteLine(s14.Contains(sub14) ? "Có tồn tại" : "Không có");

                // Bài 15: Đổi hoa <-> thường
                Console.Write("Nhập chuỗi: ");
                string s15 = Console.ReadLine();
                string rs15 = "";
                foreach (char c in s15)
                {
                    if (char.IsUpper(c)) rs15 += char.ToLower(c);
                    else if (char.IsLower(c)) rs15 += char.ToUpper(c);
                    else rs15 += c;
                }
                Console.WriteLine("Sau đổi: " + rs15);

                // Bài 16: Kiểm tra user/pass
                Console.Write("Username: ");
                string u = Console.ReadLine();
                Console.Write("Password: ");
                string p = Console.ReadLine();
                if (u == "abcd" && p == "1234") Console.WriteLine("Đăng nhập thành công");
                else Console.WriteLine("Sai tài khoản/mật khẩu");

                // Bài 17: Tìm vị trí substring
                Console.Write("Chuỗi: ");
                string s17 = Console.ReadLine();
                Console.Write("Substring: ");
                string sub17 = Console.ReadLine();
                int pos = s17.IndexOf(sub17);
                Console.WriteLine(pos >= 0 ? "Vị trí: " + pos : "Không tìm thấy");

                // Bài 18: Kiểm tra ký tự hoa/thường
                Console.Write("Nhập ký tự: ");
                char c18 = Console.ReadLine()[0];
                if (!char.IsLetter(c18)) Console.WriteLine("Không phải chữ");
                else if (char.IsUpper(c18)) Console.WriteLine("Chữ hoa");
                else Console.WriteLine("Chữ thường");

                // Bài 19: Đếm số lần xuất hiện substring
                Console.Write("Chuỗi: ");
                string s19 = Console.ReadLine();
                Console.Write("Substring: ");
                string sub19 = Console.ReadLine();
                int count19 = 0, idx = 0;
                while ((idx = s19.IndexOf(sub19, idx)) != -1)
                {
                    count19++; idx += sub19.Length;
                }
                Console.WriteLine("Xuất hiện: " + count19);

                // Bài 20: Chèn chuỗi con vào trước 1 ký tự
                Console.Write("Chuỗi: ");
                string s20 = Console.ReadLine();
                Console.Write("Ký tự cần tìm: ");
                string target20 = Console.ReadLine();
                Console.Write("Chuỗi cần chèn: ");
                string insert20 = Console.ReadLine();
                int pos20 = s20.IndexOf(target20);
                if (pos20 >= 0)
                    Console.WriteLine(s20.Insert(pos20, insert20 + " "));
                else
                    Console.WriteLine("Không tìm thấy ký tự");
            // Bài 21: So sánh 2 substring
            string str1 = "computer", str2 = "system";
            string sub1 = str1.Substring(2, 2); // "mp"
            string sub2 = str2.Substring(0, 2); // "sy"
            if (sub1.CompareTo(sub2) < 0) Console.WriteLine(sub1 + " < " + sub2);
            else if (sub1.CompareTo(sub2) > 0) Console.WriteLine(sub1 + " > " + sub2);
            else Console.WriteLine(sub1 + " = " + sub2);

            // Bài 22: So sánh chuỗi, có phân biệt hoa/thường
            string s22a = "COMPUTER", s22b = "computer";
            Console.WriteLine("Ignore case: " + (s22a.ToLower() == s22b.ToLower()));
            Console.WriteLine("Honor case: " + (s22a == s22b));

            // Bài 23: So sánh chuỗi (bỏ qua hoa/thường)
            string s23a = "COMPUTER", s23b = "computer";
            Console.WriteLine("So sánh thường: " + string.Equals(s23a, s23b, StringComparison.OrdinalIgnoreCase));

            // Bài 24: So sánh họ tên theo tên cuối
            string name1 = "Michel Jhonson";
            string name2 = "John Peterson";
            string last1 = name1.Split(' ')[1];
            string last2 = name2.Split(' ')[1];
            if (last1.CompareTo(last2) < 0) Console.WriteLine(name1 + ", " + name2);
            else Console.WriteLine(name2 + ", " + name1);

            // Bài 25: So sánh nhiều kiểu 
            string s25a = "encyclopedia", s25b = "ENCYCLOPEDIA";
            Console.WriteLine("Ignore case: " + s25a.Equals(s25b, StringComparison.OrdinalIgnoreCase));

            // Bài 26: So sánh dùng ToUpper/ToLower
            string s26a = "QRS", s26b = "qrs";
            Console.WriteLine("So sánh thường: " + (s26a.ToUpper() == s26b.ToUpper()));

            // Bài 27: Culture khác nhau 
            Console.WriteLine("Trong tiếng Anh: 'c' < 'd'");

            // Bài 28: 3 cách so sánh
            string s28a = "sister", s28b = "Sister";
            Console.WriteLine(s28a.CompareTo(s28b));
            Console.WriteLine(s28a.Equals(s28b, StringComparison.OrdinalIgnoreCase));

            // Bài 29: So sánh chữ I các dạng 
            Console.WriteLine("i < I");

            // Bài 30: So sánh Ordinal
            char c30a = 'y', c30b = 'Y';
            Console.WriteLine("CompareOrdinal: " + (c30a.CompareTo(c30b)));

            // Bài 31: So sánh Ordinal 2 chuỗi khác hoa/thường
            string s31a = "JAVA", s31b = "python";
            Console.WriteLine(s31a.CompareTo(s31b) < 0 ? "JAVA < python" : "JAVA > python");

            // Bài 32: So sánh với nhiều loại
            Console.WriteLine("So sánh 'some text' với '123': >0");

            // Bài 33: So sánh instance
            string s33a = "abc", s33b = "abc";
            Console.WriteLine(s33a.CompareTo(s33b));

            // Bài 34: Nối 3 object
            object o1 = "abc", o2 = 123, o3 = true;
            Console.WriteLine(string.Concat(o1, o2, o3));

            // Bài 35: Nối danh sách tham số
            Console.WriteLine(string.Concat("abcd", "efgh", "ijkl"));

            // Bài 36: Nối 3 chuỗi
            string part1 = "Don't count your chickens, ";
            string part2 = "before the eggs, ";
            string part3 = "have hatched.";
            Console.WriteLine(part1 + part2 + part3);

            // Bài 37: Nối mảng chuỗi
            string[] arr37 = { "hello", "welcome", "to", "C#", "Sharp" };
            Console.WriteLine(string.Join(" ", arr37));

            // Bài 38: Kiểm tra substring có tồn tại
            string s38 = "Kill two birds with one stone";
            Console.WriteLine(s38.Contains("birds"));

            // Bài 39: Copy chuỗi
            string s39a = "JAVA", s39b = string.Copy(s39a);
            Console.WriteLine("s1 = " + s39a + ", s2 = " + s39b);

            // Bài 40: CopyTo (chỉ minh họa cơ bản)
            string s40 = "w3resource CSharp Tutorial";
            char[] chs = new char[20];
            s40.CopyTo(0, chs, 0, 9);
            Console.WriteLine(chs);
            // Bài 41: Kiểm tra chuỗi có kết thúc bằng dấu chấm
            string[] arr41 = { "Actions speak louder than words", "Hello!", "Python.", "PHP.", "random" };
            foreach (string s in arr41)
                Console.WriteLine($"'{s}' kết thúc bằng '.' ? {s.EndsWith(".")}");

            // Bài 42: Kiểm tra chuỗi kết thúc bằng substring
            string s42 = "abcXYZ";
            Console.WriteLine(s42.EndsWith("XYZ"));

            // Bài 43: Kiểm tra chuỗi kết thúc bằng chuỗi khác
            string s43 = "xyzPQR";
            Console.WriteLine(s43.EndsWith("PQR"));

            // Bài 44: Tìm substring Palindrome dài nhất 
            string s44 = "bananas";
            string longest = "";
            for (int i = 0; i < s44.Length; i++)
            {
                for (int j = i; j < s44.Length; j++)
                {
                    string sub44 = s44.Substring(i, j - i + 1);
                    if (IsPalindrome(sub44) && sub.Length > longest.Length)
                        longest = sub44;
                }
            }
            Console.WriteLine("Palindrome dài nhất: " + longest);

            // Bài 45: Đảo ngược chuỗi và in hoa
            string s45 = "java";
            char[] arr45 = s45.ToUpper().ToCharArray();
            Array.Reverse(arr45);
            Console.WriteLine(new string(arr45));

            // Bài 46: Xóa ký tự trùng
            string s46 = "aaaaaabbbbccc";
            string result46 = "";
            foreach (char c in s46)
                if (!result46.Contains(c)) result46 += c;
            Console.WriteLine("Sau xóa trùng: " + result46);

            // Bài 47: Độ dài substring dài nhất không lặp ký tự
            string s47 = "BDEFGAABEF";
            int maxLen = 0;
            for (int i = 0; i < s47.Length; i++)
            {
                string temp = "";
                for (int j = i; j < s47.Length; j++)
                {
                    if (temp.Contains(s47[j])) break;
                    temp += s47[j];
                    if (temp.Length > maxLen) maxLen = temp.Length;
                }
            }
            Console.WriteLine("Độ dài substring không lặp: " + maxLen);

            // Bài 48: Đảo ngược chữ hoa ↔ thường
            string s48 = "Python 3.0";
            string res48 = "";
            foreach (char c in s48)
            {
                if (char.IsUpper(c)) res48 += char.ToLower(c);
                else if (char.IsLower(c)) res48 += char.ToUpper(c);
                else res48 += c;
            }
            Console.WriteLine("Sau đổi: " + res48);

            // Bài 49: Lấy ký tự giữa
            string s49 = "Python";
            if (s49.Length % 2 == 0)
                Console.WriteLine("Giữa: " + s49.Substring(s49.Length / 2 - 1, 2));
            else
                Console.WriteLine("Giữa: " + s49[s49.Length / 2]);

            // Bài 50: Tìm max, min trong chuỗi số
            string s50 = "3 4 8 9 0 2 1";
            string[] nums = s50.Split(' ');
            int max50 = int.MinValue, min50 = int.MaxValue;
            foreach (string num in nums)
            {
                int n = int.Parse(num);
                if (n > max50) max50 = n;
                if (n < min50) min50 = n;
            }
            Console.WriteLine($"Max: {max50}, Min: {min50}");

            // Bài 51: Kiểm tra isogram (chuỗi không lặp chữ)
            string s51 = "Python";
            bool isIso = true;
            string seen = "";
            foreach (char c in s51.ToLower())
            {
                if (seen.Contains(c)) { isIso = false; break; }
                seen += c;
            }
            Console.WriteLine("Isogram? " + isIso);

            // Bài 52: Viết hoa chữ cái đầu mỗi từ
            string s52 = "python exercises";
            string[] words52 = s52.Split(' ');
            for (int i = 0; i < words52.Length; i++)
                if (words52[i].Length > 0)
                    words52[i] = char.ToUpper(words52[i][0]) + words52[i].Substring(1);
            Console.WriteLine(string.Join(" ", words52));

            // Bài 53: Vị trí của từ trong chuỗi
            string s53 = "The quick brown fox jumps over the lazy dog";
            string[] arr53 = s53.Split(' ');
            for (int i = 0; i < arr53.Length; i++)
                if (arr53[i] == "fox") Console.WriteLine("fox ở vị trí: " + (i + 1));

            // Bài 54: Chữ xen kẽ hoa-thường
            string s54 = "c# Exercises";
            string res54 = "";
            bool upper = true;
            foreach (char c in s54)
            {
                if (char.IsLetter(c))
                {
                    res54 += upper ? char.ToUpper(c) : char.ToLower(c);
                    upper = !upper;
                }
                else res54 += c;
            }
            Console.WriteLine(res54);

            // Bài 55: Đảo các từ có độ dài chẵn
            string s55 = "C# is used to develop web apps";
            string[] arr55 = s55.Split(' ');
            for (int i = 0; i < arr55.Length; i++)
            {
                if (arr55[i].Length % 2 == 0)
                {
                    char[] tmp = arr55[i].ToCharArray();
                    Array.Reverse(tmp);
                    arr55[i] = new string(tmp);
                }
            }
            Console.WriteLine(string.Join(" ", arr55));

            // Bài 56: Tìm đuôi chung giữa 2 chuỗi
            string a56 = "running", b56 = "ruminating";
            string common = "";
            int len56 = Math.Min(a56.Length, b56.Length);
            for (int i = 1; i <= len56; i++)
            {
                if (a56[a56.Length - i] == b56[b56.Length - i])
                    common = a56[a56.Length - i] + common;
                else break;
            }
            Console.WriteLine("Đuôi chung: " + common);

            // Bài 57: Đảo các từ có từ 3 ký tự trở lên
            string s57 = "The quick brown fox jumps";
            string[] arr57 = s57.Split(' ');
            for (int i = 0; i < arr57.Length; i++)
                if (arr57[i].Length >= 3)
                {
                    char[] tmp = arr57[i].ToCharArray();
                    Array.Reverse(tmp);
                    arr57[i] = new string(tmp);
                }
            Console.WriteLine(string.Join(" ", arr57));

            // Bài 58: Kiểm tra anagram
            string s58a = "stone", s58b = "tones";
            char[] ca = s58a.ToCharArray(); Array.Sort(ca);
            char[] cb = s58b.ToCharArray(); Array.Sort(cb);
            Console.WriteLine(new string(ca) == new string(cb));

            // Bài 59: Đảo số nguyên và cộng với số gốc
            int n59 = 456;
            string rev = "";
            foreach (char c in n59.ToString()) rev = c + rev;
            int sum59 = n59 + int.Parse(rev);
            Console.WriteLine(sum59);

            // Bài 60: Đếm ký tự lặp
            string s60 = "ppqrrsttuuu";
            int dup = 0;
            for (int i = 0; i < s60.Length; i++)
            {
                if (s60.IndexOf(s60[i]) != s60.LastIndexOf(s60[i]))
                {
                    dup++;
                    s60 = s60.Replace(s60[i].ToString(), "");
                    i = -1;
                }
            }
            Console.WriteLine("Số ký tự trùng: " + dup);

            // Bài 61: Đếm số lần từ xuất hiện trong chuỗi
            string s61 = "the quick brown fox jumps over the lazy dog";
            string[] arr61 = s61.Split(' ');
            Console.Write("Nhập từ cần đếm: ");
            string word61 = Console.ReadLine();
            int count61 = 0;
            foreach (string w in arr61)
                if (w == word61) count61++;
            Console.WriteLine($"Từ '{word61}' xuất hiện {count61} lần");

            // Bài 62: Đếm ký tự khác nhau trong chuỗi
            string s62 = "abcdabcde";
            string seen62 = "";
            foreach (char c in s62)
                if (!seen62.Contains(c)) seen62 += c;
            Console.WriteLine("Số ký tự khác nhau: " + seen62.Length);

            // Bài 63: Tìm từ dài nhất trong chuỗi
            string s63 = "Write a CSharp Sharp Program to display the longest word";
            string[] arr63 = s63.Split(' ');
            string longest63 = "";
            foreach (string w in arr63)
                if (w.Length > longest63.Length) longest63 = w;
            Console.WriteLine("Từ dài nhất: " + longest63);

            // Bài 64: Tìm từ ngắn nhất trong chuỗi
            string s64 = "Write a CSharp Sharp Program to display the longest word";
            string[] arr64 = s64.Split(' ');
            string shortest64 = arr64[0];
            foreach (string w in arr64)
                if (w.Length < shortest64.Length) shortest64 = w;
            Console.WriteLine("Từ ngắn nhất: " + shortest64);

            // Bài 65: Đếm số từ viết hoa trong chuỗi
            string s65 = "CSharp is a Programming Language";
            string[] arr65 = s65.Split(' ');
            int count65 = 0;
            foreach (string w in arr65)
                if (char.IsUpper(w[0])) count65++;
            Console.WriteLine("Số từ viết hoa: " + count65);

            // Bài 66: Loại bỏ khoảng trắng dư thừa
            string s66 = "  CSharp   Exercises   ";
            string trimmed66 = s66.Trim();
            string[] parts66 = trimmed66.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Chuỗi sau khi loại bỏ khoảng trắng: " + string.Join(" ", parts66));

            // Bài 67: Thay thế từ trong chuỗi
            string s67 = "CSharp is easy to learn";
            Console.WriteLine("Trước: " + s67);
            string replaced67 = s67.Replace("easy", "powerful");
            Console.WriteLine("Sau: " + replaced67);

            // Bài 68: Đảo ngược từng từ trong chuỗi
            string s68 = "The quick brown fox";
            string[] arr68 = s68.Split(' ');
            for (int i = 0; i < arr68.Length; i++)
            {
                char[] chars = arr68[i].ToCharArray();
                Array.Reverse(chars);
                arr68[i] = new string(chars);
            }
            Console.WriteLine("Chuỗi sau khi đảo từng từ: " + string.Join(" ", arr68));
        }

       
        static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j]) return false;
            return true;
        }
    }

}
