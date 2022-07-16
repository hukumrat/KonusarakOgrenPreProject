using System.ComponentModel.DataAnnotations;

namespace KonusarakOgrenPreProject.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public string? Brand { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Comment> Comments { get; set; }
        public Product()
        {
            Photos = new List<Photo>();
            Comments = new List<Comment>();
        }

    }
}
