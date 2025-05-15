using Slide1;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Player p1 = new Player();
        ////Bien tinh duoc truy cap thong qua ten class

        //Console.WriteLine($"Mau: {p1.health}");
        //Console.WriteLine($"Diem: {Player.score}");
        //p1.GiamMau();
        //Console.WriteLine($"Mau: {p1.health}");
        //Player.TangDiem();
        //Console.WriteLine($"Diem: {Player.score}");

        //Student s1 = new Student(1,"Nguyen Van A", 12);
        //Console.WriteLine($"ID: {s1.id}, Name: {s1.name}, Age: {s1.age}");


        //int[] a = {1,3,7,6, 8};
        ////Kiem tra xem thu trong mang nay co ton tai so 5 khong
        //bool check = false;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] == 5)
        //    {
        //        Console.WriteLine("Ton tai so 5");
        //        check = true;
        //    }
        //}
        //if (!check)
        //{
        //    Console.WriteLine("Khong ton tai so 5 trong mang");
        //}
        //HashSet
        //Moi phan tu la duy nhat
        //Chi phi tim kiem la 1
        //var intSet = new HashSet<int>();
        //intSet.Add(1);
        //intSet.Add(3);
        //intSet.Add(7);
        //intSet.Add(6);
        //intSet.Add(8);
        ////if (intSet.Contains(5))
        ////{
        ////    Console.WriteLine("Ton tai");
        ////}
        ////else {
        ////    Console.WriteLine("khong ton tai");
        ////}
        //// for each int i in set
        ////Voi moi phan tu i trong intSet
        //foreach (var i in intSet)
        //{
        //    Console.WriteLine(i);
        //}

        var listInt = new List<int>();
        listInt.Add(1);
        listInt.Add(2);
        listInt.Add(9);
        listInt.Add(411);
        listInt.Add(5);
        listInt.Remove(1);
        foreach (var i in listInt)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Sau khi sap xep");
        listInt.Sort();
        foreach (var i in listInt)
        {
            Console.WriteLine(i);
        }
        int viTri = listInt.BinarySearch(9);
        if (viTri > 0) {
            Console.WriteLine("Vi tri cua phan tu 9 la: "+viTri);
        } else { Console.WriteLine("khong tim thay"); }

    }

}

