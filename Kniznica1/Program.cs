using System.Runtime.InteropServices.JavaScript;

namespace Kniznica1;

class Program
{
    static void Main(string[] args)
    {
        kniha Hobit = new kniha();
        Hobit.menoknihy = "Hobit";
        Hobit.menoautora = "J.R.R.Tolkien";
        Hobit.rokvydania = 1937;
        Hobit.dostupnost = true;

        kniha PanPrstenov = new kniha();
        Hobit.menoknihy = "Pán Prsteňov: Spoločenstvo Prsteňa";
        Hobit.menoautora = "J.R.R.Tolkien";
        Hobit.rokvydania = 1954;
        Hobit.dostupnost = true;

        kniha MalyPrinc = new kniha();
        Hobit.menoknihy = "Malý princ";
        Hobit.menoautora = "Antoine de Saint - Exupéry";
        Hobit.rokvydania = 1943;
        Hobit.dostupnost = true;

        kniha PychaPredsudok = new kniha();
        Hobit.menoknihy = "Pýcha a predsudok";
        Hobit.menoautora = "Jane Austen";
        Hobit.rokvydania = 1813;
        Hobit.dostupnost = true;

        while (true)
        {
            if (Console.ReadLine() == "HladajKnihu")
            {
                HladajKnihu();
            }
            else if (Console.ReadLine() == "PridajKnihui")
            {
                PridajKnihu();
            }
        }
    }
}

class kniha
    {
        public string menoknihy;
        public string menoautora;
        public int rokvydania;
        public bool dostupnost;
    }

class kniznica
{
    public List<kniha> zoznam = new List<kniha>();
}

void PridajKnihu()
{
    Console.WriteLine("Novy nazov knihy:");
    string menoknihy = Console.ReadLine();
    Console.WriteLine("Meno autora:");
    string menoautora = Console.ReadLine();
    Console.WriteLine("Rok vydania:");
    int rokvydania = int.Parse(Console.ReadLine());
}

void HladajKnihu()
{
    Console.WriteLine("Aku knihu hladas?");
    string menoautora = Console.ReadLine();

    if (menoautora == Console.ReadLine())
    {
        Console.WriteLine(menoknihy);
    }
}