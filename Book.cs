

class Book
{
    public string title;
    public string author;
    public int pages;

    private string genre = "";

    public Book(string bookTitle, string name, int bookPage, string bookGenre)
    {
        Console.WriteLine("Hello Constructor");
        title = bookTitle;
        author = name;
        pages = bookPage;
        Genre = bookGenre;
    }

    public string moreThan()
    {
        if (pages > 500)
        {
            return $"{title} have more than 500 pages";
        }
        return $"{title} have less than 500 pages";
    }

    public string Genre
    {
        get
        {
            return genre;
        }
        set
        {

            if (value == "Thriller" || value == "Mystery")
            {
                genre = value;
            }
            else
            {
                genre = "Not my type";
            }
        }
    }
}