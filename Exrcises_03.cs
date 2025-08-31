using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exrcises_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            game_engine();
            Ex02();
        }

        static void game_engine()
        {
            Console.Write("Luật chơi: Cho 100$ là tiền quỹ, mỗi ván chơi thắng/thua thì được/mất 4/7/10$ theo level.");
            Console.Write("Chơi cho đến khi người chơi chọn dừng hoặc hết tiền.\n");
            /*Thống kê số ván thắng/thua, số tiền có trong quỹ
             * Luật chơi: Cho 100$ là tiền quỹ, mỗi ván chơi thắng/thua thì được/mất 4/7/10$ theo level.
             * Chơi cho đến khi thắng chơi nữa hoặc hết tiền.
             * Thống kê số ván thắng/thua, số tiền có trong quỹ.
             */
            int money = 100;
            bool stop = false;
            bool[] win = new bool[1000];
            int [] mon = new int[1000];
            int van = 0;
            do
            {
                Console.WriteLine($"Hiện tại quỹ của bạn còn {money}$");
                Console.WriteLine("\n Chào mừng bạn đến với trò chơi đoán số\n");
                Console.WriteLine("Level:\n\tKhó: 4 lần chơi\n\tTrung bình: 7 lần chơi\n\tDễ: 10 lần chơi");
                Console.Write("Bạn chọn cấp độ nào? [1-Khó ; 2-Trung bình ; 3-Dễ]: ");
                string l = Console.ReadLine();
                bool check = int.TryParse(l, out int level);
                if ((level != 1) && (level != 2) && (level != 3))
                {
                    check = false;
                }
                while (!check)
                {
                    Console.Write("Vui lòng chọn lại cấp độ bạn muốn chơi: ");
                    l = Console.ReadLine();
                    check = int.TryParse(l, out level);
                    if ((level != 1) && (level != 2) && (level != 3))
                    {
                        check = false;
                    }
                }
                int solanchoi;
                if (level == 1)
                {
                    solanchoi = 4;
                }
                else if (level == 2)
                {
                    solanchoi = 7;
                }
                else
                {
                    solanchoi = 10;
                }
                Random rnd = new Random(); // công cụ nghĩ ra số ngẫu nhiên
                int comp_num = rnd.Next(0, 100) + 1; //[1,100]
                bool is_won = false;
                // yêu cầu người dùng đoán số
                for (int i = 0; i < solanchoi; i++)
                {
                    Console.Write($"{i + 1}: Bạn đoán số mấy[1 - 100]: ");
                    string man_str = Console.ReadLine();
                    bool check2 = int.TryParse(man_str, out int man_num);
                    // so sánh kết quả
                    while (!check2)
                    {
                        Console.Write("Vui lòng nhập lại số bạn chọn: ");
                        man_str = Console.ReadLine();
                        check2 = int.TryParse(man_str, out man_num);
                    }
                    if (man_num == comp_num)
                    {
                        is_won = true;
                        Console.WriteLine("You are Genius!.");
                        money = money + solanchoi;
                        win[van] = true;
                        mon[van] = money;
                        van++;
                    }
                    else if (man_num > comp_num)
                    {
                        Console.WriteLine("Số bạn đoán lớn hơn số máy tính chọn");
                    }
                    else
                    {
                        Console.WriteLine("Số bạn đoán nhỏ hơn số máy tính chọn");
                    }
                    if (is_won) { break; }
                }
                if (!is_won)
                {
                    Console.WriteLine($"Bạn đã hết lượt đoán, số cần đoán là {comp_num}.");
                    money = money - solanchoi;
                    win[van] = false;
                    mon[van] = money;
                    van++;
                }
                // sau 1 lần chơi, hỏi người dùng có chơi nữa không
                Console.WriteLine($"Bạn hiện còn lại {money}$.");
                if (money < 4)
                {
                    Console.WriteLine("Bạn không đủ tiền để tiếp tục cuộc chơi. Xin chào tạm biệt.");
                    stop = true;
                }
                else
                {
                    Console.Write("Nhấn <c> để chơi tiếp, <k> để dừng lại? <c/k>:");
                    string t1 = Console.ReadLine();
                    if (t1.ToLower().Equals("k"))
                    {
                        Console.WriteLine("Bye, hẹn gặp lại"); stop = true;
                    }
                    else if (t1.ToLower().Equals("c"))
                    {
                        stop = false;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập lại <c/k>");
                    }
                }
            } while (!stop);
            Console.WriteLine("Kết quả thống kê:");
            Console.WriteLine($"Số tiền còn lại là {money}");
            for (int i = 0; i < van; i++)
            {
                if (win[i])
                {
                    Console.WriteLine($"Ván thứ {i + 1} thắng. So tien con lai: {mon[i]}");
                }
                else
                {
                    Console.WriteLine($"Ván thứ {i+1} thua. So tien con lai: {mon[i]}");
                }
            } 
        }
        static void Ex02()
        {

            bool stop = false;
            int money = 100, van=0;
            bool[] win=new bool[1000];
            int[] mon= new int[1000];
            Console.Write("Đây là trò chơi Tài/Xỉu. Máy tính gieo 2 con xúc sắc và lấy tổng của chúng, nếu lơn hơn 5 thì là \"Tài\", nhỏ hơn 5 là \"Xỉu\", Bằng 5 là trường hợp đặc biệt.\nMáy sẽ hỏi người chơi đoán Tài/Xỉu/5. Nếu người chơi đoán đúng/sai tài/xỉu thì thắng +5$/-5$. Đoán trúng số 5 thì cộng gấp 3 (thua thì trừ 5).");
            do
            { 
                Console.WriteLine($"Hiện tại bạn có {money}$");
                Random rnd = new Random();
                int die_1 = rnd.Next(6) + 1;
                int die_2 = rnd.Next(6) + 1;
                int pair_of_dice = die_1 + die_2;
                //hỏi người chơi đoán tài/xỉu/5
                //...
                //so sánh,....
                Console.WriteLine($"Bạn hiện còn {money}$");
                Console.WriteLine("Hãy chọn Tài hay Xỉu hay 5");
                string input = Console.ReadLine();
                string kq;
                if (pair_of_dice > 5) { kq = "tài"; }
                else if (pair_of_dice < 5) { kq = "xỉu"; }
                else { kq = "5"; }
                if (kq == "5")
                {
                    if (input == "5")
                    {
                        Console.WriteLine($"Bạn đã chọn đúng, tổng hai xúc xắc là 5. Bạn được nhận 15$");
                        money = money + 15;
                        win[van] = true;
                        mon[van] = money;
                        van++;
                    }
                    else
                    {
                        Console.WriteLine($"Bạn đã chọn sai, tổng hai xúc xắc là 5. Bạn bị mất 5$");
                        money = money - 5;
                        win[van] = false;
                        mon[van] = money;
                        van++;
                    }
                }
                else if (input.ToLower().Equals(kq))
                {
                    Console.WriteLine($"Bạn đã chọn đúng, tổng hai xúc xắc là {pair_of_dice}.\nKết quả là {kq}.\nBạn được nhận 5$");
                    money = money + 5;
                    win[van] = true;
                    mon[van] = money;
                    van++;
                }
                else 
                { 
                    Console.WriteLine($"Bạn đã chọn sai, tổng hai xúc xắc là {pair_of_dice}.\nKết quả là {kq}.\nBạn bị mất 5$");
                    money = money - 5;
                    win[van] = false;
                    mon[van] = money;
                    van++;
                }
                //hỏi người chơi có tiếp tục
                Console.Write("Bạn chơi nữa không? <c/k>: ");
                string t1 = Console.ReadLine();
                if (t1.ToLower().Equals("k"))
                {
                    Console.WriteLine("Bye, hẹn gặp lại");
                    stop=true;
                }
                if (money<5) { stop = true; }
            } while (!stop);
        } 
    }

}
