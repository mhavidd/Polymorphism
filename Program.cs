using System;
namespace tes_vscode;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pilih printer:");
        Console.WriteLine("1. Epson");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LaserJet");
        Console.WriteLine("PILIH JENIS PRINT : (1-3)");  int input = Convert.ToInt32(Console.ReadLine());

        Printer printer;

        if (input == 1)
        {
            printer = new EpsonPrinter();
        }
        else if (input == 2)
        {
            printer = new CanonPrinter();
        }
        else if (input == 3)
        {
            printer = new LaserJetPrinter();
        }
        else
        {
            Console.WriteLine("Pilihan printer tidak valid");
            return;
        }

        printer.DisplayDimension();
        printer.Print();

        Console.ReadLine();
    }
}