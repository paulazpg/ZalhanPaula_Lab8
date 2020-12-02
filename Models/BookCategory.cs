namespace ZalhanPaula_Lab8.Models
{
    public class BookCategory
    {
        //fields in table
        public int ID { get; set; }
        public int BookID { get; set; }      
        public int CategoryID { get; set; }

        // navigation properties
        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}