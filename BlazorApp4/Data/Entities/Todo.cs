namespace BlazorApp4.Data.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }

    }
}
