using RayleensGitTest;


Calculator myCalc = new Calculator();

Console.WriteLine(myCalc.Multiply(10, 5));
Console.WriteLine(myCalc.Add(10, 5));
Console.WriteLine(myCalc.Divide(10, 5));
Console.WriteLine(myCalc.Subtract(10, 5));
Console.WriteLine(myCalc.added(10,5));

Book FirstBook = new Book("Harry Potter", "Rowling", "J. K. ", "A wonderful book full of magic and wonder for children. ");


Console.WriteLine(FirstBook.getBookTitle + ": " + FirstBook.getBookAuthor);
Console.WriteLine(FirstBook.getBookDescription);