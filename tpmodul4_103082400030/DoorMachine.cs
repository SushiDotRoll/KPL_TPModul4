using System;
class DoorMachine
{
    private string state;
    public DoorMachine()
    {
        state = "Terkunci";
        Console.WriteLine("Pintu terkunci");
    }
    public void BukaPintu()
    {
        if (state == "Terkunci")
        {
            state = "Terbuka";
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }
    public void KunciPintu()
    {
        if (state == "Terbuka")
        {
            state = "Terkunci";
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}