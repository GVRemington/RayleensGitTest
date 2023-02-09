using RayleensGitTest;


Calculator myCalc = new Calculator();

Console.WriteLine(myCalc.Multiply(10, 5));
Console.WriteLine(myCalc.Add(10, 5));
Console.WriteLine(myCalc.Divide(10, 5));
Console.WriteLine(myCalc.Subtract(10, 5));
Console.WriteLine(myCalc.added(10,5));

BookList FirstBook = new BookList("Harry Potter", "Rowling", "J. K. ", "A wonderful book full of magic and wonder for children. ");
BookList SecondBook = new BookList("War and Peace", "Tolstoy ", "Leo ", "A wonderful book about war and peace ");

Console.WriteLine(FirstBook.getBookTitle + ": " + FirstBook.getBookAuthor);
Console.WriteLine(FirstBook.getBookDescription);