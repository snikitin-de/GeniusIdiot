using GeniusIdiotConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    public class ConsoleMenuIO
    {
        public static void PrintMainMenu(string userName)
        {
            Console.Clear();
            QuizIO.PrintText(GreetingUser(userName), ConsoleColors.GreetingUserConsoleColor);
            QuizIO.PrintText("Меню:\n", ConsoleColors.UserInteractionConsoleColor);
            
            foreach(var menuItem in ConsoleMenu.GetMainMenu())
            {
                QuizIO.PrintText($"{menuItem.Id}. {menuItem.Text}", ConsoleColors.UserInteractionConsoleColor); 
            }
        }

        public static void PrintLoginMenu(string userName)
        {
            Console.Clear();
            QuizIO.PrintText(GreetingUser(userName), ConsoleColors.GreetingUserConsoleColor);
            QuizIO.PrintText("Меню:\n", ConsoleColors.UserInteractionConsoleColor);

            foreach (var menuItem in ConsoleMenu.GetLoginMenu())
            {
                QuizIO.PrintText($"{menuItem.Id}. {menuItem.Text}", ConsoleColors.UserInteractionConsoleColor);
            }
        }

        public static int GetMenuItem(List<MenuItem> menu)
        {
            QuizIO.PrintText("\nВведите номер пункта меню для перехода", ConsoleColors.UserInteractionConsoleColor);
            return (int)QuizIO.GetNumberBetweenMinMax(1, menu.Count + 1);
        }

        public static string GreetingUser(string userName)
        {
            var greeting = "пожаловать в программу \"Гений-Идиот\"!\n";

            return !string.IsNullOrEmpty(userName) ? $"{userName}, добро {greeting}" : "Добро " + greeting;
        }
    }
}
