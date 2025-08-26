using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class App
{
    public static void Respond(int request)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        switch (request)
        {
            case 1:
                {
                    Console.WriteLine("Nhập hai số nguyên muốn tìm ước chung lớn nhất: ");

                    Console.Write("Nhập số nguyên thứ nhất: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập số nguyên thứ hai: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"USCLN của {a} và {b} là: {Function.GCD(a, b)}");
                    break;
                }
                
            case 2:
                {
                    Console.Write("Nhập số nguyên muốn tìm số nghịch đảo: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Số nghịch đảo của {n} là: {Function.Reverse(n)}");
                    break;
                }
                
            case 3:
                {
                    Console.Write("Nhập số nguyên muốn kiểm tra đối xứng: ");
                    int m = Convert.ToInt32(Console.ReadLine());

                    if (Function.Symmetry(m))
                        Console.WriteLine($"{m} là số đối xứng");
                    else
                        Console.WriteLine($"{m} không phải là số đối xứng");
                    break;
                }
                
            case 4:
                {
                    Console.Write("Nhập hai số nguyên muốn hoán vị: ");

                    Console.Write("Nhập số nguyên thứ nhất: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập số nguyên thứ hai: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Trước khi hoán vị, số nguyên thứ nhất là: {x}, số nguyên thứ hai là: {y}");
                    Function.Swap(ref x, ref y);
                    Console.WriteLine($"Sau khi hoán vị, số nguyên thứ nhất là: {x}, số nguyên thứ hai là: {y}");
                    break;
                }
                
            case 5:
                {
                    Console.Write("Nhập chuỗi muốn bỏ khoảng trắng thừa: ");
                    string s = Console.ReadLine();

                    if(Function.NumDetect(s))
                    {
                        Console.WriteLine("Chuỗi không hợp lệ! Vui lòng nhập chuỗi bao gồm chữ cái.");
                        return;
                    }

                    Console.WriteLine($"Chuỗi sau khi bỏ khoảng trắng thừa: '{Function.Standard(s)}'");
                    break;
                }
            case 6:
                {
                    Console.Write("Nhập chuỗi muốn lấy số ký tự bên trái: ");
                    string str1 = Console.ReadLine();

                    if (Function.NumDetect(str1))
                    {
                        Console.WriteLine("Chuỗi không hợp lệ! Vui lòng nhập chuỗi bao gồm chữ cái.");
                        return;
                    }

                    Console.Write("Nhập số ký tự muốn lấy từ chuỗi: ");
                    int j = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{j} ký tự bên trái của chuỗi là: '{Function.Left(str1, j)}'");
                    break;
                }

            case 7:
                {
                    Console.Write("Nhập chuỗi muốn lấy số ký tự bên phải: ");
                    string str2 = Console.ReadLine();

                    if (Function.NumDetect(str2))
                    {
                        Console.WriteLine("Chuỗi không hợp lệ! Vui lòng nhập chuỗi bao gồm chữ cái.");
                        return;
                    }

                    Console.Write("Nhập số ký tự muốn lấy từ chuỗi: ");
                    int k = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{k} ký tự bên phải của chuỗi là: '{Function.Right(str2, k)}'");
                    break;
                }
            case 8:
                {
                    Console.Write("Nhập chuỗi muốn lấy ký tự: ");
                    string str3 = Console.ReadLine();

                    if (Function.NumDetect(str3))
                    {
                        Console.WriteLine("Chuỗi không hợp lệ! Vui lòng nhập chuỗi bao gồm chữ cái.");
                        return;
                    }

                    Console.Write("Nhập vị trí bắt đầu lấy ký tự: ");
                    int i = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhập số ký tự muốn lấy từ chuỗi: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{n} ký tự từ vị trí {i} của chuỗi là: '{Function.Mid(str3, i, n)}'");

                    break;
                }
            case 9:
                {
                    Console.Write("Nhập chuỗi muốn chuẩn hóa: ");
                    string str4 = Console.ReadLine();

                    if (Function.NumDetect(str4))
                    {
                        Console.WriteLine("Chuỗi không hợp lệ! Vui lòng nhập chuỗi bao gồm chữ cái.");
                        return;
                    }

                    Console.WriteLine($"Chuỗi sau khi chuẩn hóa: '{Function.Proper(str4)}'");
                    break;
                }
            default:
                Console.WriteLine("Yêu cầu không hợp lệ!");
                break;
        }
    }
}
