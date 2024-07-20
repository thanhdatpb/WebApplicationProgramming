namespace HelloProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get;set; }
        public DateTime ProductionDate { get; set; }
    }
}
