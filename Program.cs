using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("|------------------------<MENU>--------------------------------|");
            Console.WriteLine("|Chương trình hỗ trợ các yêu cầu sau:                          |");
            Console.WriteLine("|1.USCLN(a, b) Trả về USCLN của 2 số nguyên                    |");
            Console.WriteLine("|2.Reverse(n) Trả về số nghịch đảo ngược của số nguyên         |");
            Console.WriteLine("|3.Symmetry(n) Kiểm tra số đối xứng                            |");
            Console.WriteLine("|4.Swap(ref a, ref b) Hoán vị 2 số nguyên                      |");
            Console.WriteLine("|5.Standard(string s) Xóa khoảng trắng thừa của chuỗi          |");
            Console.WriteLine("|6.Left(s, n) Trả về n kí tự bên trái của chuỗi                |");
            Console.WriteLine("|7.Right(s, n) Trả về n kí tự bên phải của chuỗi               |");
            Console.WriteLine("|8.Mid(s, index, n) Trả về n kí tự từ vị trí index của chuỗi   |");
            Console.WriteLine("|9.Proper(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường  |");
            Console.WriteLine("|--------------------------------------------------------------|");

            bool check = false;
            do
            {
                Console.Write("Nhập yêu cầu của bạn: ");
                int request = Convert.ToInt32(Console.ReadLine());
                App.Respond(request);


                Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N)");
                switch(Console.ReadLine().ToUpper())
                {
                    case "Y":
                        check = true;
                        break;
                    case "N":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập Y hoặc N");
                        break;
                }
            } while (check);
        }
    }
}