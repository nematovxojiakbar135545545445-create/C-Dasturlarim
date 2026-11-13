abstract class Fiz
{
    public abstract double Tezlik();
}
class YoshFizik : Fiz
{
    public double S;
    public int T;
    public YoshFizik(double s, int t)
    {
        S=s;
        T=t;
    }
    public override double Tezlik()
    {
        return S/T;
    }
}
class Yol : Fiz
{
    public int T;
    public int V;
    public Yol(int t, int v)
    {
        T=t;
        V=v;
    }
    public override double Tezlik()
    {
        return V*T;
    }
}
class Vaqt : Fiz
{
    public int S;
    public int V;
    public Vaqt(int s, int v)
    {
        S=s;
        V=v;
    }
    public override double Tezlik()
    {
        return S/V;
    }
}
class EKinetik: Fiz
{
    public double M;
    public double V;
    public EKinetik(double m, double v)
    {
        M=m;
        V=v;
    }
    public override double Tezlik()
    {
        return (M*V*V)/2;
    }
}
class EPotensial : Fiz
{
    public double M;
    public double G;
    public double H;
    public EPotensial(double m, double g, double h)
    {
        M=m;
        G=g;
        H=h;
    }
    public override double Tezlik()
    {
        return M*G*H;
    }
    
}
class Dastur
{
    static void Main()
    {
        var f1 = new YoshFizik(24, 6);
        Console.WriteLine(f1.Tezlik());
        var f2 = new Yol(56, 45);
        Console.WriteLine(f2.Tezlik());
        var f3 = new Vaqt(24, 6);
        Console.WriteLine(f3.Tezlik());
        var f4 = new EKinetik(24, 6);
        Console.WriteLine(f4.Tezlik());
        var f5 = new EPotensial(24, 6, 5);
        Console.WriteLine(f5.Tezlik());
    }
}
