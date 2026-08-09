namespace Book_api_core.Models
{
    public class CreateBookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}