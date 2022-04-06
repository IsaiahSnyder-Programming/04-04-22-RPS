namespace RPS.models
{
    public class Items
    {
        public string? Name { get; private set; }
        public int? Wins { get; set; }
        public bool Picked { get; set; }

        public Items(string? name, int? wins)
        {
            Name = name;
            Wins = wins;
            Picked = false;
        }
    }
}