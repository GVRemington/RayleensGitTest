using RayleensGitTest;


Calculator myCalc = new Calculator();

Console.WriteLine(myCalc.Multiply(10, 5));
Console.WriteLine(myCalc.Add(10, 5));
Console.WriteLine(myCalc.Divide(10, 5));
Console.WriteLine(myCalc.Subtract(10, 5));
Console.WriteLine(myCalc.added(10,5));

Book FirstBook = new Book("Harry Potter ", "Rowling ", ",J. K. ", " A wonderful book full of magic and wonder for children. ");
Book SecondBook = new Book("War and Peace ", "Tolstoy ", ",Leo ", " A wonderfull book full of war and peace ");

Console.WriteLine(FirstBook.getBookTitle + ": " + FirstBook.getBookAuthor);
Console.WriteLine(FirstBook.getBookDescription);
Console.WriteLine(SecondBook.getBookTitle + ": " + SecondBook.getBookAuthor);
Console.WriteLine(SecondBook.getBookDescription);