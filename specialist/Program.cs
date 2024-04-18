speshal specialist = new speshal();

Console.Write("Въведете име:");

specialist.name = Console.ReadLine();

Console.Write("Въведете заплата:");

specialist.salary = int.Parse(Console.ReadLine());

Console.Write("Въведете одтел:");

specialist.otdel = Console.ReadLine();

specialist.info();