namespace CookieMaker2023P3A.Services
{
    public interface IDice
    {
        public int Roll(int sides);
        public int Roll();
        public int LastRoll { get; }
        public int LastSides { get; }
    }
}
