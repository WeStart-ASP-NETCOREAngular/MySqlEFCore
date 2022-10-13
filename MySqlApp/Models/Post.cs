namespace MySqlApp.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
