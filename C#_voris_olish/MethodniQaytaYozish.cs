using System;
class Avtomobil
{
    public virtual void Markasi()
    {
        Console.WriteLine("Damas");
    }
}
class VorisT: Avtomobil
{
    public override void Markasi()
    {
        Console.WriteLine("Malibu");
    }
}
class Dastur
{
    static void Main()
    {
        VorisT v1 = new VorisT();
        v1.Markasi();
    }
}
