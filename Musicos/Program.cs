internal class Program
{
    class Musico
    {
        public string name{ get; set;}
        public Musico(string n){name = n;}
        public void Saluda(){Console.WriteLine("Hola soy: " + name);}
        public virtual void Toca()
        {Console.WriteLine($"{name} esta tocando su instrumento");}
    }
    class Baterista: Musico
    {
    public string bateria{get;set;}
    public Baterista (string n, string b):base(n)
    {bateria =b;}
    public override void Toca()
    {
    Console.WriteLine($"{name} tocando su bateria");
    }
    }
    class Bajista : Musico
    {public string bajo{get;set;}
     public Bajista (string n, string b):base(n)
     {bajo =b;}
        public override void Toca()
        {
            Console.WriteLine($"{name} tocando su bajo");
        }
    }

    private static void Main(string[] args)
    {
        List<Musico> grupo = new List<Musico> ();
        grupo.Add(new Bajista("Joe","Yamaha"));
        //grupo.Add(new Musico("Joe","Yamaha"));
        //grupo.Add(new Baterista("Joe","Yamaha"));
        //grupo.Add(new Guitarrista("Joe","Yamaha"));    
        foreach(var m in grupo)
        {m.Saluda();}
        foreach(var m in grupo)
        {m.Toca();}
    }
}