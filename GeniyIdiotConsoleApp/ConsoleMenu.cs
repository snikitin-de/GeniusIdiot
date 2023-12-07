using GeniusIdiotConsoleApp.Models;
using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    public class ConsoleMenu
    {
        public enum LoginMenu
        {
            Login = 1,
            ExitProgram
        };

        public enum MainMenu
        {
            ShowQuestions = 1,
            AddQuestion,
            DeleteQuestion,
            ShowQuizResults,
            StartQuiz,
            ChangeUser,
            ExitProgram
        };

        public static List<MenuItem> GetLoginMenu()
        {
            return new List<MenuItem>
            {
                new MenuItem((int)LoginMenu.Login, "Войти в программу"),
                new MenuItem((int)LoginMenu.ExitProgram, "Закрыть программу")
            };
        }

        public static List<MenuItem> GetMainMenu()
        {
            return new List<MenuItem>
            {
                new MenuItem((int)MainMenu.ShowQuestions, "Просмотреть список вопросов"),
                new MenuItem((int)MainMenu.AddQuestion, "Добавить вопрос"),
                new MenuItem((int)MainMenu.DeleteQuestion, "Удалить вопрос"),
                new MenuItem((int)MainMenu.ShowQuizResults, "Просмотреть результаты"),
                new MenuItem((int)MainMenu.StartQuiz, "Начать векторину"),
                new MenuItem((int)MainMenu.ChangeUser, "Сменить пользователя"),
                new MenuItem((int)MainMenu.ExitProgram, "Закрыть программу")
            };
        }
    }
}
