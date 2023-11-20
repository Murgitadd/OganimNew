namespace Oganim.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string BgImg { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public Departments Departments { get; set; }
        public int DepartmentId { get; set; }

    }
}
