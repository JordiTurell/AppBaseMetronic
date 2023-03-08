namespace Services.Models
{
    public class RequestList<T>
    {
        public List<T> customdata { get; set; }
        public string token { get; set; }
        public int page { get; set; }
        public int items { get; set; }
    }
}
