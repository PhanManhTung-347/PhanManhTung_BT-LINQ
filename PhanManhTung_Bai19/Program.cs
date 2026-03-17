using System;
using System.Linq;
using System.Collections.Generic;
class Bai19
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 19: Tim so lan xuat hien nhieu nhat.");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 2, 5 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
            Console.Write(pt + " ");
        var group = numbers.GroupBy(pt => pt);
        var ptt = group.OrderByDescending(gr => gr.Count()).FirstOrDefault();
        if (ptt != null)
            Console.WriteLine($"\nPhan tu {ptt.Key} xuat hien nhieu nhat voi {ptt.Count()} lan.");
    }
}
