namespace Mission10_API.Data
{
    //new model for the data that we want to retrieve
    public class CombinedData
    {
        public string? BowlerName { get; set; }

        public string? BowlerAddress { get; set; }

        public string? BowlerCity { get; set; }

        public string? BowlerState { get; set; }

        public string? BowlerZip { get; set; }

        public string? BowlerPhoneNumber { get; set; }

        public string TeamName { get; set; } = null!;

    }
}
