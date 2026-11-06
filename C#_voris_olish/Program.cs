using System;
class Son1
{
    public int son;
    public void ChopEt()
    {
        Console.WriteLine(son);
    }
}
class Daraja : Son1
{
    public void Kvadrat()
    {
        Console.WriteLine(son*son);
    }
    public void IstalganDaraja(int n)
    {
        Console.WriteLine(Math.Pow(son, n));
    }
}
class Dastur
{
    static void Main()
    {
        Daraja d1 = new Daraja();
        d1.son = 4;
        d1.ChopEt();
        d1.IstalganDaraja(6);
    }
}