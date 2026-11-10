using System;
class Kitob
{
    public class Bob
    {
        public string Nomi;
        public int SahifalarSoni;
        public void ChopEt()
        {
            Console.WriteLine("Nomi: "+Nomi);
            Console.WriteLine("Sahifalar somi: "+SahifalarSoni);
        }
    }
}
class Dastur
{
    static void Main()
    {
        var k1 = new Kitob.Bob();
        k1.Nomi = "Seb bir olam, men o'zga olam";
        k1.SahifalarSoni = 306;
        var k2 = new Kitob.Bob();
        k2.Nomi = "Ikki eshik orasi";
        k2.SahifalarSoni = 700;
        k1.ChopEt();
        k2.ChopEt();
        
    }
}