internal class Program
{
    class Musician
    {
        public string name{ get; set;}
        public Musician(string n){name = n;}
        public void Greethin(){Console.WriteLine("Hello i'm: " + name);}
        public virtual void Play()
        {Console.WriteLine($"{name} my roll in thi's band is ");}
    }
    class Singer: Musician
    {
        public string singer{get;set;}
        public Singer (string n, string b):base(n)
        {singer=b;}
        public override void Play()
        {
            Console.WriteLine($"{name} it's singing");
        }
    }
    class Guitarist: Musician
    {
        public string guitar {get;set;}
        public Guitarist(string n, string b): base(n)
        {guitar=b;}
        public override void Play()
        {
            Console.WriteLine($"{name} it's playing solo with the guitar");
        }
    }
    class Pianist: Musician
    {
        public string piano{get;set;}
        public Pianist(string n, string b):base(n)
        {piano=b;}
        public override void Play()
        {
            Console.WriteLine($"{name} it's playing solo with the piano");
        }
    }
    class Drumer: Musician
    {
    public string drums{get;set;}
    public Drumer (string n, string b):base(n)
    {drums =b;}
    public override void Play()
    {
    Console.WriteLine($"{name} it's playing solo with the drums");
    }
    }
    class Bass : Musician
    {public string bass{get;set;}
     public Bass (string n, string b):base(n)
     {bass =b;}
        public override void Play()
        {
            Console.WriteLine($"{name} it's playing solo with the bass");
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("With us Guns N' Roses");
        List<Musician> GunsNRoses = new List<Musician> ();
        GunsNRoses.Add(new Singer("Axl","Shure ULX2/58"));
        GunsNRoses.Add(new Pianist("Axl","Baldwin Bp 165"));
        GunsNRoses.Add(new Guitarist("Slash","Hunter Burst(Gibson Les Paul '59)"));
        GunsNRoses.Add(new Guitarist("Izzy Stradlin","Gibson ES-175")); 
        GunsNRoses.Add(new Bass("Duff","Fender Jazz Bass Special"));
        GunsNRoses.Add(new Drumer("Adler","Tama Rockstar Custom Faux Rock"));   
        foreach(var m in GunsNRoses)
        {m.Greethin();}
        foreach(var m in GunsNRoses)
        {m.Play();}
    }
}
