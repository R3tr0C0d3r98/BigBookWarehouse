namespace BigBookWarehouse.DAL.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public int Rating { get; set; }

    }
}
