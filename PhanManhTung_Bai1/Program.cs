using System;
using System.Linq;
using System.Collections.Generic;
class Bai1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 1: Loc so chan");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
        {
            Console.Write(pt+" ");
        }
        var ds = numbers.Where(p => p % 2 == 0);
        Console.WriteLine("\nDanh sach so chan la:");
        foreach (var sc in ds)
        {
            Console.Write(sc+" ");
        }
    }
}