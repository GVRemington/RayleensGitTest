
namespace RayleensGitTest
{
    internal class Book
    {
        //    
        private string title;
        private string description;
        private string author;

        public Book(string Name, string AuthorLastName, string AuthorFirstName, string Description)
        {
            title = Name;
            author = AuthorLastName +  ", " + AuthorFirstName;
            description = Description;
        }
        
        public string getBookTitle 
        {
            get { return title;}
        }
        public string getBookDescription
        {
            get { return description;}
        }
        public string getBookAuthor
        {
            get { return author;}
        }
    }
}
