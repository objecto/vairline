namespace vairline.api.Models
{
    public class Airline
    {
        public int Id { get; set; } // Primary key for Airline
        public string Name { get; set; } // Name of the airline
        public string IcaoCode { get; set; } // ICAO code for the airline
        public string Callsign { get; set; } // Callsign of the airline
        public DateTime Founded { get; set; } // Date the airline was founded
        public string Country { get; set; } // Country of the airline

        // Relationship: An airline can have multiple pilots
        public ICollection<Pilot> Pilots { get; set; }

        // Constructor to initialize collections
        public Airline()
        {
            Pilots = new List<Pilot>();
        }
    }
}
