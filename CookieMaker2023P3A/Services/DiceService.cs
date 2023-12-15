namespace CookieMaker2023P3A.Services
{
    public class DiceService : IDice
    {

        //private static readonly Random _random = new Random(); // generátor náhodných čísel
        private readonly Random _random;
        public DiceService() // služba nemá žádné závislosti
        {
            _random = Random.Shared;
            Roll(); // ihned po vytvoření hoď kostkou, aby byly zbývající vlastnosti naplněny
        }
        public int LastRoll { get; private set; } // vrací hodnotu posledního hodu
        public int LastSides { get; private set; } // vrací velikost poslední kostky
        public int Roll(int sides) // hod kostkou
        {
            LastSides = sides;
            LastRoll = _random.Next(sides) + 1;
            return LastRoll;
        }

        public int Roll() // hod kostkou
        {
            return Roll(6); // zavoláme jinou metodu, která ale potřebuje parametr
        }
    }
}
