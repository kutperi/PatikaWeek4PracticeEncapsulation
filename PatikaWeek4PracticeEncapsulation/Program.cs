
using PatikaWeek4PracticeEncapsulation;

// Creating an instance of Car
Car car1 = new Car();

// Ask user to define properties
Console.WriteLine("Lütfen bir Marka giriniz..");
car1.Brand = Console.ReadLine();

Console.WriteLine("Lütfen bir Model giriniz..");
car1.Model = Console.ReadLine();

Console.WriteLine("Lütfen bir renk giriniz..");
car1.Colour = Console.ReadLine();

Console.WriteLine("Lütfen kapı sayısını yazınız..");
car1.GateCount = Convert.ToInt32(Console.ReadLine());

// Display the car information by answer of user
car1.CarInfo();