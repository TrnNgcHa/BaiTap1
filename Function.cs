using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Function
{
    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        if (a == 0 || b == 0)
            return -1;


        if (a < b)
            return GCD(a - b, b);
        else if (a > b)
            return GCD(a, b - a);
        else
            return a;
    }

    public static int Reverse(int n)
    {
        int result = 0;
        while (n != 0)
        {
            int digit = n % 10;
            result = result * 10 + digit;
            n /= 10;
        }
        return result;
    }

    public static bool Symmetry(int n)
    {
        if (n < 0)
            return false;

        return n == Reverse(n);
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }


    public static bool NumDetect(string s)
    {
        foreach (char c in s)
        {
            if (!(((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122)))
                return true;
        }
        return false;
    }

    public static string Standard(string p)
    {
        p = p.Trim();

        string[] words = p.Split(new char[] { ' ' });
        
        string result = "";
        foreach (string word in words)
        {
            if (word != "")
                result += word + " ";
        }

        return result.Trim();
    }

    public static string Left(string s, int n)
    {
        if (n < 0 || n > s.Length)
            return "";

        return s.Substring(0, n);
    }

    public static string Right(string s, int n)
    {
        if (n < 0 || n > s.Length)
            return "";

        return s.Substring(s.Length - n, n);
    }

    public static string Mid(string s, int i, int n)
    {
        if (i < 0 || i >= s.Length || n < 0 || i + n > s.Length)
            return "";
        return s.Substring(i, n);
    }

    public static string Proper(string s)
    {
        s = Standard(s);
        if (s == "")
            return "";
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", words);
    }
}
