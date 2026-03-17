using System;
using System.Linq;
using System.Collections.Generic;
class Bai3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 3: Sap xep tang dan.");
        List<int> numbers = new List<int> { 8,3,6,4,7,1,5,2 };
        Console.WriteLine("Danh sach truoc khi sap xep la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.OrderBy(p => p);
        Console.WriteLine("Danh sach sau khi sap xep tang dan la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}