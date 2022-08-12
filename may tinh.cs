using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnShap
{
    internal class Class1
    {
        static void Main()
        {
            
            int choice = 0;
            do
            {
                Console.WriteLine("=========CASIO============");
                Console.WriteLine("1.phep tinh cong");
                Console.WriteLine("2.phep tinh tru");
                Console.WriteLine("3.phep tinh nhan");
                Console.WriteLine("4.phep tinh chia");
                Console.WriteLine("0.thoat chuong trinh");
                Console.WriteLine("ban chon?");

                string input = Console.ReadLine();
                choice = Convert.ToInt32(input);
                int a = 0;
                int b = 0;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("=============hen gap lai============");
                        break;
                    case 1:
                        Console.WriteLine("nhap a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine("nhap a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine("nhap a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine("nhap a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" {a} / {b} = {a / b}");
                        break;


                    default:
                        Console.WriteLine("nhap cac chuc nawng tu 1 -> 4");
                        break;
                }
            }while(choice != 0);
            
        }
    }
}
