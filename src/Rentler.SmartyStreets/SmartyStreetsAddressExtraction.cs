namespace Rentler.SmartyStreets
{
    /// <summary>
    /// Represents the results of an address extraction
    /// </summary>
    public class SmartyStreetsAddressExtraction
    {
        public Meta meta { get; set; }
        public Addresses[] addresses { get; set; }
    }

    public class Addresses  
    {
        public string text { get; set; }
        public bool verified { get; set; }
        public SmartyStreetsAddress[] api_output { get; set; }
        public int line { get; set; }
        public int start { get; set; }
        public int end { get; set; }
    }

    public class Meta
    {
        public int lines { get; set; }
        public bool unicode { get; set; }
        public int address_count { get; set; }
        public int verified_count { get; set; }
        public int bytes { get; set; }
        public int character_count { get; set; }

    }
}