namespace ISP;

public class Game: IStartable, ICheckbale
{
    public void Start(int count, int searchNumber)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Осталось попыток: {count - i}");
            Console.Write("Введите число ");

            var number = Convert.ToInt32(Console.ReadLine());
            if (Check(number, searchNumber))
            {
                return;
            }

        }
        Console.WriteLine();
        Console.WriteLine($"Игра окончена, вам не удалось угадать за {count} попытки, попробуйте снова.");
    }

    public bool Check(int number, int searchNumber)
    {
        if (number > searchNumber)
        {
            Console.WriteLine("Меньше");
        }
        else if (number < searchNumber)
        {
            Console.WriteLine("Больше");
        }
        else
        {
            Console.WriteLine($"Вы отгадали, это число {searchNumber}");
            return true;
        }

        return false;
    }
}