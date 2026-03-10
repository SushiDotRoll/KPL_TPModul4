using System;

class Program
{
    static void TampilkanKelurahan()
    {
        string[,] data =
        {
            {"Batununggal","40266"},
            {"Kujangsari","40287"},
            {"Mengger","40267"},
            {"Wates","40256"},
            {"Cijaura","40287"},
            {"Jatisari","40286"},
            {"Margasari","40286"},
            {"Sekejati","40286"},
            {"Kebonwaru","40272"},
            {"Maleer","40274"},
            {"Samoja","40273"}
        };

        Console.WriteLine("{0,-15} {1}", "Kelurahan", "Kode Pos");

        for (int i = 0; i < data.GetLength(0); i++)
        {
            Console.WriteLine("{0,-15} {1}", data[i, 0], data[i, 1]);
        }
    }

    static void Main(string[] args)
    {
        TampilkanKelurahan();
        Console.ReadLine();
    }
}