using Slide1;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Player p1 = new Player();
        //Bien tinh duoc truy cap thong qua ten class
        
        Console.WriteLine($"Mau: {p1.health}");
        Console.WriteLine($"Diem: {Player.score}");
        p1.GiamMau();
        Console.WriteLine($"Mau: {p1.health}");
        Player.TangDiem();
        Console.WriteLine($"Diem: {Player.score}");

        Student s1 = new Student(1,"Nguyen Van A", 12);
        Console.WriteLine($"ID: {s1.id}, Name: {s1.name}, Age: {s1.age}");
    }
}

