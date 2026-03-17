using System;
using System.Linq;
using System.Collections.Generic;
class Bai5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 5: Binh phuong moi so.");
        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8 };
        Console.WriteLine("Danh sach la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.Select(p => p * p);
        Console.WriteLine("Danh sach binh phuong moi so la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}