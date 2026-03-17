using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Bai10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347|| LHP: 225LTC03");
        Console.WriteLine("Bai 10: Sap xep sinh vien giam dan theo diem.");
        List<Student> students = new List<Student>() {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 } };
        Console.WriteLine("Danh sach sinh vien:");
        foreach (Student sv in students)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-10} || Score={sv.Score,-5}");
        var dssv = students.OrderByDescending(sv => sv.Score);
        Console.WriteLine("Danh sach ten sinh vien sau khi sap xep giam dan theo diem:");
        foreach(Student sv in dssv)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-10} || Score={sv.Score,-5}");
    }
}
