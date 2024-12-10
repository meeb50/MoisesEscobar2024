namespace MoisesEscobar.API
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string UrlImage { get; set; } = string.Empty;
    }
}
