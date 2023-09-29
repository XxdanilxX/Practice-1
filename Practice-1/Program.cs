
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Завдання 1: Перевірка коректності логіна
        
        while (true)
        {
            Console.WriteLine("Введіть логін: ");
            string login = Console.ReadLine();

            if (Login(login))
            {
                Console.WriteLine("Логін коректний.");
                break;
            }
            else
            {
                Console.WriteLine("Логін некоректний.");
                
            }
        }


        // Завдання 2: Заміна визначених слів
        Console.WriteLine("Введіть текст: ");
        string text = Console.ReadLine();

        string result = Words(text);
        Console.WriteLine("Результат заміни слів: ");
        Console.WriteLine(result);
    }

    // Метод для перевірки коректності логіна за допомогою регулярних виразів
    static bool Login(string login)
    {
        // Регулярний вираз для перевірки логіна
        string pattern = @"^[A-Za-z][A-Za-z0-9]{1,9}$";

        // Перевірка логіна за допомогою Regex.IsMatch
        return Regex.IsMatch(login, pattern);
    }

    // Метод для заміни визначених слів у тексті
    static string Words(string text)
    {
        // Визначення слова та його форм
        string wordToReplace = "word";
        string[] wordForms = { "words", "word", "more worlds"};

        // Перетворення слова та його форм у вираз регулярного виразу
        string wordPattern = "(" + string.Join("|", wordForms) + ")";

        // Заміна в тексті
        string result = Regex.Replace(text, wordPattern, "New word", RegexOptions.IgnoreCase);

        return result;
    }
}

