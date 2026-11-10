using System;
class Universitet
{
    public class Fakultet
    {
        public string Nomi;
        public int TalabalarSoni;
        public void ChopEt()
        {
            Console.WriteLine("Nomi: "+Nomi);
            Console.WriteLine("Talabalar somi: "+TalabalarSoni);
        }
    }
}
class Dastur
{
    static void Main()
    {
        var t1 = new Universitet.Fakultet();
        t1.Nomi = "Fizmat";
        t1.TalabalarSoni = 2000;
         var t2 = new Universitet.Fakultet();
        t2.Nomi = "IT";
        t2.TalabalarSoni = 1500;
        t1.ChopEt();
        t2.ChopEt();

    }
}