books book = new books();

Console.Write("Въведете Книга:");

book.title = Console.ReadLine();

Console.Write("Въведете автор:");

book.author = Console.ReadLine();

Console.Write("Въведете година на издаване:");

book.age = int.Parse(Console.ReadLine());

book.writeal();