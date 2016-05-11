class ProductModule
{
public class commantary : record
{
    public int userID { get; set; }

    void set(DateTime date, string title, int type, string content, int ID, int userID)
    {
        base.set(date, title, type, content, ID);
        this.userID = userID;

    }
}

public class Product
    {
        public string name { get; set; }
        public string author { get; set; }
        public string publishinghouse { get; set; }
        public string language { get; set; }
        public string oryginallanguage { get; set; }
        public int pagesNUM { get; set; }
        public DateTime releasedate { get; set; }
        public int ID { get; set; }
        public int availabilty { get; set; }

        protected List<commantary> commentaries;


        List<commantary> commentariesGet()
        {
            return commentaries;
        }
        void commentariesModify(List<commantary> commentaries)
        {
            this.commentaries = commentaries;
        }
        void commentariesAdd(commantary temp)
        {
            this.commentaries.Add(temp);
        }

    }

    class ebook : product
    {
        public string readername { get; set; }
        public string type { get; set; }
        public double lenghtINh { get; set; }
    }
    class book : product
    {
        public int numberofpages { get; set; }
        public string type { get; set; }
    }

    public class API
    {
        public Product GetProductByID(int id) { }
        public void AddNewProduct(string name, string author, string publishinghouse, string language, string oryginallanguage, int pagesNUM, DateTime releasedate, int ID, int availabilty) { }
    }
}
