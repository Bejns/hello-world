using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TEST MERGE


public class MainClass
{
    public static void Main()
    {
        int price;
        int vat;
        int payables;
        int quantity;

        Console.Title = ("Moja Prva Konzola");
        Console.WindowWidth = 80;
        Console.WindowHeight = 40;


        Console.WriteLine("Unesite količinu:");
        while (int.TryParse(Console.ReadLine(), out quantity) == false)
        {
            Console.WriteLine("Nije unet validan broj, molim unesite validan broj:");
        }

        Console.WriteLine("Unesite cenu:");
        while (int.TryParse(Console.ReadLine(), out price) == false)
        {
            Console.WriteLine("Nije unet validan broj, molim unesite validan broj:");
        }

        Console.WriteLine("Vaš iznos poreza je:");
        vat = quantity * price / 100 * 20;
        Console.WriteLine(vat);

        Console.WriteLine("Vaš iznos za plaćanje je:");
        payables = quantity * price + vat;
        Console.WriteLine(payables);

        Console.WriteLine("Konačni obračun: " + Environment.NewLine + "Količina = " + quantity + Environment.NewLine + "Cena = " + price + Environment.NewLine + "Za plaćanje= " + payables);

        if (payables > 1000)
        {
            Console.WriteLine("Odlicno, faktura je preko 1000 dinara");
        }
        else
        {
            Console.WriteLine("Ocajna faktura, ispod 1000 dinara!");
        }

        Console.ReadKey();
    }
}
