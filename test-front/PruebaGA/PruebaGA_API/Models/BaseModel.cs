namespace PruebaGA_API.Models
{
    public class BaseModel
    {
        public string status { get; set; }
        public List<CountryModel> data { get; set; }
        public string message { get; set; }
    }
}
