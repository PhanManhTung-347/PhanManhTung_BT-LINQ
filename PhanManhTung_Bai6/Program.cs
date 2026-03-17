using System;
using System.Linq;
using System.Collections.Generic;
class Bai6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 6: Dem so chan.");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.Where(p => p % 2 == 0);
        var count= ds.Count();
        Console.WriteLine("Danh sach so chan:");
        foreach (var s in ds)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine($"\nSo luong so chan trong danh sach la {count} so");
    }
}