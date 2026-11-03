using System;
class Transport
{
    public string nomi;
    public int tezlik;

}
class Avtobus: Transport
{
    public int orindiqlarSoni;
    public void ChopET()
    {
        Console.WriteLine($"Nomi: {nomi}\nTeazligi: {tezlik}\nO'rindiqlar soni: {orindiqlarSoni}");
    }
}
class Dastur
{
    static void Main()
    {
        Avtobus a1 = new Avtobus();
        a1.nomi = "Alpomish merosi";
        a1.tezlik = 80;
        a1.orindiqlarSoni = 36;
        a1.ChopET();
    }
}
