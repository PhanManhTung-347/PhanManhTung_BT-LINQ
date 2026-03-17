using System;
using System.Linq;
using System.Collections.Generic;
class Bai16
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 16: Tinh tong cac phan tu.");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
            Console.Write(pt + " ");
        var tong = numbers.Sum();
        Console.WriteLine($"\nTong cac phan tu trong danh sach la:{tong}");

    }
}
