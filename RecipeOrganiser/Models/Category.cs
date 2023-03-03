using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeOrganiser.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
