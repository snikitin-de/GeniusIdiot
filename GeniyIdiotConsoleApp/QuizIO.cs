using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GeniusIdiotConsoleApp
{
    public class QuizIO
    {
        public static bool GetChoice()
        {
            while (true)
            {
                var userChoice = Console.ReadLine().ToLower();

                if (userChoice == "да" || userChoice == "нет")
                {
                    return userChoice == "да" ? true : false;
                }
                else
                {
                    PrintText($"Пожалуйста, введите \"да\" или \"нет\"!", ConsoleColors.ErrorConsoleColor);
                }
            }
        }

        public static int? GetNumber()
        {
            int? userInput = null;

            while (true)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (FormatException)
                {
                    PrintText($"Вы ввели строку! Пожалуйста, введите число!", ConsoleColors.ErrorConsoleColor);
                }
                catch (OverflowException)
                {
                    PrintText($"Вы ввели число больше, чем {int.MaxValue}! Пожалуйста, введите меньшее число!", ConsoleColors.ErrorConsoleColor);
                }
            }

            return userInput;
        }

        public static int? GetNumberBetweenMinMax(int minNumber, int maxNumber)
        {
            int? userInput = null;

            while (true)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput >= maxNumber)
                    {
                        PrintText($"Введите число, которое меньше {maxNumber}!", ConsoleColors.ErrorConsoleColor);
                        continue;
                    }
                    else if (userInput < minNumber)
                    {
                        PrintText($"Введите число, которое больше или равно {minNumber}!", ConsoleColors.ErrorConsoleColor);
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    PrintText($"Вы ввели строку! Пожалуйста, введите число!", ConsoleColors.ErrorConsoleColor);
                }
                catch (OverflowException)
                {
                    PrintText($"Вы ввели число больше, чем {int.MaxValue}! Пожалуйста, введите меньшее число!", ConsoleColors.ErrorConsoleColor);
                }
            }

            return userInput;
        }

        public static Dictionary<string, string> GetFullName()
        {
            var fullName = new Dictionary<string, string>();

            Console.Clear();
            PrintText("> Вход в программу\n", ConsoleColors.UserInteractionConsoleColor);
            PrintText("Введите ваше ФИО (части имени вводите через пробел)", ConsoleColors.UserInteractionConsoleColor);

            var userInput = Console.ReadLine();
            var userInputSplitted = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var regexOnlyLetters = new Regex(@"[^A-Za-zА-Яа-яЁё]+", RegexOptions.Compiled);

            while (true)
            {
                if (userInputSplitted.Length == 0)
                {
                    PrintText("ФИО пользователя не может быть пустым!\n", ConsoleColors.ErrorConsoleColor);
                }
                else if (userInputSplitted.Length > 3)
                {
                    PrintText("ФИО пользователя не может состоять более чем из трех частей!\n", ConsoleColors.ErrorConsoleColor);
                }
                else if (regexOnlyLetters.Matches(userInput).Count > 0)
                {
                    PrintText("ФИО пользователя не может содержать никакие символы кроме букв!\n", ConsoleColors.ErrorConsoleColor);
                }
                else
                {
                    break;
                }
                
                PrintText("Введите ваше ФИО (части имени вводите через пробел)", ConsoleColors.UserInteractionConsoleColor);

                userInput = Console.ReadLine();
                userInputSplitted = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            switch (userInputSplitted.Length)
            {
                case 1: fullName.Add("FirstName", userInputSplitted[0]); break;
                case 2: fullName.Add("FirstName", userInputSplitted[1]); fullName.Add("LastName", userInputSplitted[0]); break;
                case 3: fullName.Add("FirstName", userInputSplitted[1]); fullName.Add("LastName", userInputSplitted[0]); fullName.Add("MiddleName", userInputSplitted[2]); break;
            }

            return fullName;
        }

        public static void GoToMainMenu()
        {
            do
            {
                PrintText($"\nНе хотите ли перейти в главное меню? Введите \"да\" или \"нет\".", ConsoleColors.UserInteractionConsoleColor);
            } while (!GetChoice());
        }

        public static void PrintText(string text, ConsoleColor color, bool isAddNewLine = true)
        {
            Console.ForegroundColor = color;

            if (isAddNewLine)
            {
                Console.WriteLine(text);
            } else
            {
                Console.Write(text);
            }

            Console.ResetColor();
        }
    }
}
