namespace BookLibrary.Models
{
    public class AddBookVM //View model kullanarak istemediğim propertyleri almamış oldum
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookImageUrl { get; set; }
        public string BookAuthor { get; set; }
    }
}
