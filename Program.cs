using System;

class Time
{
    static void Main(string[] args)
    {
        bool isValidInput = false;
        string TimeNumber = "";

        while (!isValidInput)
        {
            Console.WriteLine("Введіть номер години (1-24):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n >= 1 && n <= 24)
            {
                isValidInput = true;

                switch (n)
                {
                    case 1:
                        TimeNumber = "Перша година ночі";
                        break;
                    case 2:
                        TimeNumber = "Друга година ночі";
                        break;
                    case 3:
                        TimeNumber = "Третя година ночі";
                        break;
                    case 4:
                        TimeNumber = "Четверта година ночі";
                        break;
                    case 5:
                        TimeNumber = "П`ята година ранку";
                        break;
                    case 6:
                        TimeNumber = "Шоста година ранку";
                        break;
                    case 7:
                        TimeNumber = "Сьома година ранку";
                        break;
                    case 8:
                        TimeNumber = "Восьма година ранку";
                        break;
                    case 9:
                        TimeNumber = "Дев`ята година ранку";
                        break;
                    case 10:
                        TimeNumber = "Десята година ранку";
                        break;
                    case 11:
                        TimeNumber = "Одинадцята година ранку";
                        break;
                    case 12:
                        TimeNumber = "Дванадцята година дня";
                        break;
                    case 13:
                        TimeNumber = "Тринадцята година дня";
                        break;
                    case 14:
                        TimeNumber = "Чотирнадцята година дня";
                        break;
                    case 15:
                        TimeNumber = "П`ятнадцята година дня";
                        break;
                    case 16:
                        TimeNumber = "Шістнадцята година дня";
                        break;
                    case 17:
                        TimeNumber = "Сімнадцята година дня";
                        break;
                    case 18:
                        TimeNumber = "Вісімнадцята година вечора";
                        break;
                    case 19:
                        TimeNumber = "Дев`ятнадцята година вечора";
                        break;
                    case 20:
                        TimeNumber = "Двадцята година вечора";
                        break;
                    case 21:
                        TimeNumber = "Двадцять перша година вечора";
                        break;
                    case 22:
                        TimeNumber = "Двадцять друга година вечора";
                        break;
                    case 23:
                        TimeNumber = "Двадцять третя година вечора";
                        break;
                    case 24:
                        TimeNumber = "Двадцять четверта година ночі";
                        break;
                    default:
                        TimeNumber = "Невірний номер години";
                        isValidInput = false;
                        break;
                }

                Console.WriteLine($"Період дня за номером години {n}: {TimeNumber}");
            }
            else
            {
                Console.WriteLine("Невірний ввід. Будь ласка, введіть ціле число від 1 до 24.");
            }
        }

        Console.ReadLine();
    }
}
