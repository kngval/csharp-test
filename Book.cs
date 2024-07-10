

class Book {
    public string title;
    public string author;
    public int pages;
    public Book(string bookTitle, string name, int bookPage){
        Console.WriteLine("Hello Constructor");
        title = bookTitle;
        author = name;
        pages = bookPage;
    }

    public string moreThan(){
        if(pages > 500){
            return $"{title} have more than 500 pages";
        }
        return $"{title} have less than 500 pages";
    }
}