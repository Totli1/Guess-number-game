namespace Guess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int computerNumber = rnd.Next(1, 101);
            int youTry = 0;
            string repeatGame;
            uint selectedNumber;
            Console.WriteLine("Попробуйте угадать число от 1 до 100!");
            while (true)
            {
                Console.Write("Введите число:");
                try { selectedNumber = uint.Parse(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("Введите положительное число");
                    continue;
                }
                youTry++;
                if (selectedNumber > computerNumber)
                {
                    Console.WriteLine("Меньше");
                    continue;
                }
                else if (selectedNumber < computerNumber)
                {
                    Console.WriteLine("Больше");
                    continue;
                }
                Console.WriteLine($"Вы угдали! Попыток угадать: {youTry}\nНажмите Enter чтобы повторить или введите n чтобы закончить");
                repeatGame = Console.ReadLine();
                if (repeatGame == "N" || repeatGame == "n") break;
                computerNumber = rnd.Next(1, 101);
            }
            Console.ReadLine();
        }
    }
}
