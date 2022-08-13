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
                Console.WriteLine("4.phep tinh chia ");
                Console.WriteLine("5.phep tinh chia lay phan du ");
                Console.WriteLine("6.tinh can bac 2");
                Console.WriteLine("7.tinh  tri tuyet doi");
                Console.WriteLine("8.phep tinh ^2  ");
                Console.WriteLine("0.thoat chuong trinh");
                Console.WriteLine("ban chon?");

                string input = Console.ReadLine();
                choice = Convert.ToInt32(input);
                int a = 0;
                int b = 0;
                int x = default;
                int n = default;
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
                        Console.WriteLine( $" {a} / { b} = {0.1 * a / b}");
                        break;
                    case 5:
                        Console.WriteLine( "nhap a : " );
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap b : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a } % {b} = {a % b} ");
                        break;
                    case 6:
                        Console.WriteLine("nhap x : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("căn bậc 2 của x = " +  Math.Sqrt(x));
                        break;
                    case 7:
                        Console.WriteLine("nhap x : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("|x| = " + Math.Abs(x));
                        break;
                    case 8:
                        Console.WriteLine("nhap x : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        n = x * x;
                        Console.WriteLine("x ^2 = " + n );
                        break;


                    default:
                        Console.WriteLine("nhap cac chuc nang tu 1 -> 4");
                        break;
                }
            }while(choice != 0);
            
        }
    }
}
