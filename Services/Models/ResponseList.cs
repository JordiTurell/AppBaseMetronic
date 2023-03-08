namespace Services.Models
{
    public class ResponseList<T>
    {
        public List<T> customdata { get; set; }
        public string message { get; set; } = "Token invalid";
        public bool status { get; set; } = false;
    }
}
