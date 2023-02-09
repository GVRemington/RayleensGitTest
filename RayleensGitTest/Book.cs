using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayleensGitTest
{
    internal class BookList
    {
        private string title;
        private string description;
        private string author;

        public BookList(string Name, string AuthorLastName, string AuthorFirstName, string Description)
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
