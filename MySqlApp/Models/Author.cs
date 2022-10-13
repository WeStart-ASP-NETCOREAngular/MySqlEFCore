using System.ComponentModel.DataAnnotations;

namespace MySqlApp.Models
{
    public class Author
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
