namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProviderId { get; set; }

        public Provider? Providers { get; set; } = default!;
    }
}
