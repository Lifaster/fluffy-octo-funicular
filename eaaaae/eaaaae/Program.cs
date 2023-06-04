using System;

class Program
{
    static void Main(string[] args)
    {
        Anketa();
        
        Console.ReadKey();
    }
    static void Anketa()
    {
        (string Name, string surname, int Age, bool Pet, string[] PetsName, string[] favcolors) Ank;
        Console.WriteLine("Ваше имя");
        Ank.Name = Console.ReadLine();
        Console.WriteLine("Ваша фамилия");
        Ank.surname = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        Ank.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("У вас есть домашние питомцы? да/нет");
        switch (Console.ReadLine())
        {
            case "yes" or "да":
                Ank.Pet = true;
                break;
            case "no" or "нет":
                Ank.Pet = false;
                break;
            default:
                Ank.Pet = false;
                break;
        }
        if (Ank.Pet == true)
        {
            Console.WriteLine("Сколько у вас питомцев?");
            int CountPet = int.Parse(Console.ReadLine());
            Ank.PetsName = Pets(CountPet);
        }
        Console.WriteLine("Сколько у вас любимых цветов?");
        int CountColor = int.Parse(Console.ReadLine());
        Ank.favcolors = FavColors(CountColor);
        Console.WriteLine("жду");
    }
    static string[] Pets(int count)
    {
        var PetsName = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Имя {0} питомца", i+1);
            PetsName[i] = Console.ReadLine();
        }
        return PetsName;
    }
    static string[] FavColors(int count)
    {
        var favColors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Любимый цвет №{0}", i + 1);
            favColors[i] = Console.ReadLine();
        }
        return favColors;
    }
}
        