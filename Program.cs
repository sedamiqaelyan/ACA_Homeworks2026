using Homework11;
//TASK1
/*
Car car = new Car("Toyota", "Corolla", 2019);
car.Describe();
car.Start();
Console.WriteLine(car.isRunning);
car.Stop();
Console.WriteLine(car.isRunning);
*/


//TASK2
/*
Temperature t = new Temperature(25);
t.Describe();
Console.WriteLine(t.Fahrenheit);
t.Celsius = 100;
t.Describe();
t.Celsius = -300;
t.Describe();

*/

//Task3

Library lib = new Library(5);
lib.AddBook(new Book("Dune", "Herbert"));
lib.AddBook(new Book("1984", "Orwell"));
lib.AddBook(new Book("Brave New World", "Huxley"));
lib.ListAvailable();       // all 3 books
lib.BorrowBook("1984");    // Borrowed: 1984
lib.ListAvailable();       // Dune, Brave New World
/*lib.BorrowBook("1984");    // Not available
lib.ReturnBook("1984");    // Returned: 1984
lib.ListAvailable();       // all 3 books
//Console.WriteLine(Library.TotalLibraries); // 1*/