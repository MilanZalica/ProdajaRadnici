using System;

namespace Prodajaradnici
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodavac a = new Prodavac("Marko Markovic", 40);
            a.Prodao(700);
            Console.WriteLine(a);
            Prodavac b = new Prodavac("Petar Petrovic", 40);
            b.Prodao(600);
            Console.WriteLine(b);
            Sef s = new Sef("Nikola Nikolic",50,2);
            s.Dodeli(a);
            s.Dodeli(b);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
