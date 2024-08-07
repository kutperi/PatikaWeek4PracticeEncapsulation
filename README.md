# Patika Week 4 Practice: Encapsulation

Bu proje, kullanıcıdan araç bilgilerini alarak oluşturulan bir `Car` nesnesinin bilgilerini ekrana yazdırır. Proje, `PatikaWeek4PracticeEncapsulation` isimli bir namespace altında yer almaktadır.

## Özellikler

- Kullanıcıdan araç markası, modeli, rengi ve kapı sayısını alır.
- Alınan bilgileri kullanarak bir `Car` nesnesi oluşturur.
- Oluşturulan `Car` nesnesinin bilgilerini ekrana yazdırır.
- Kapı sayısı olarak yalnızca 2 veya 4 kabul edilir, aksi durumda hata mesajı ve -1 atanır.

## Gereksinimler

- .NET Core SDK

## Kullanım

Program çalıştıktan sonra, sırasıyla aşağıdaki bilgileri girmeniz istenecektir:
- Marka
- Model
- Renk
- Kapı sayısı (yalnızca 2 veya 4 kabul edilir)

### Örnek Kullanım

```csharp
using PatikaWeek4PracticeEncapsulation;

// Yeni bir Car nesnesi oluştur
Car car1 = new Car();

// Kullanıcıdan özellikleri belirlemesini iste
Console.WriteLine("Lütfen bir Marka giriniz..");
car1.Brand = Console.ReadLine();

Console.WriteLine("Lütfen bir Model giriniz..");
car1.Model = Console.ReadLine();

Console.WriteLine("Lütfen bir renk giriniz..");
car1.Colour = Console.ReadLine();

Console.WriteLine("Lütfen kapı sayısını yazınız..");
car1.GateCount = Convert.ToInt32(Console.ReadLine());

// Kullanıcının girdiği bilgileri göster
car1.CarInfo();
