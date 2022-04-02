namespace LibM.Contracts.Books
{
    public class BookViewDto
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }
    }

    public class NewBookDto
    {
        public string Name { get; set; }
        public Guid AuthorId { get; set; }

        public Guid TypeId { get; set; }
        public bool Available { get; set; }
        public int PageCount { get; set; }
    }
}
