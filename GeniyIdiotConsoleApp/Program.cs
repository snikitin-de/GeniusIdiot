using Common;
using Common.Models;

namespace GeniusIdiotConsoleApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quizResultsFileProvider = new FileProvider("quizResults.json");
            var questionsFileProvider = new FileProvider("questions.json");
            var questionStorage = new QuestionStorage(questionsFileProvider);
            var user = new User();

            ConsoleMenuIO.PrintLoginMenu(string.Empty);

            switch (ConsoleMenuIO.GetMenuItem(ConsoleMenu.GetLoginMenu()))
            {
                case (int)ConsoleMenu.LoginMenu.Login:
                    
                    user = UserStorage.GetUser();
                    QuizIO.GoToMainMenu();
                    break;
                case (int)ConsoleMenu.LoginMenu.ExitProgram:
                    return;
            }

            while (true)
            {
                ConsoleMenuIO.PrintMainMenu(user.FirstName);

                switch (ConsoleMenuIO.GetMenuItem(ConsoleMenu.GetMainMenu()))
                {
                    case (int)ConsoleMenu.MainMenu.ShowQuestions:
                        Quiz.ShowQuestions(questionStorage);
                        break;
                    case (int)ConsoleMenu.MainMenu.AddQuestion:
                        Quiz.AddQuestions(questionStorage);
                        questionStorage.Save();
                        break;
                    case (int)ConsoleMenu.MainMenu.DeleteQuestion:
                        Quiz.DeleteQuestions(questionStorage);
                        break;
                    case (int)ConsoleMenu.MainMenu.ShowQuizResults:
                        Quiz.ShowQuizResults(quizResultsFileProvider.Read<QuizResult>());
                        break;
                    case (int)ConsoleMenu.MainMenu.StartQuiz:
                        Quiz.StartQuiz(questionStorage, user);
                        break;
                    case (int)ConsoleMenu.MainMenu.ChangeUser:
                        user = UserStorage.GetUser();
                        break;
                    case (int)ConsoleMenu.MainMenu.ExitProgram:
                        return;
                }

                QuizIO.GoToMainMenu();
            }
        }
    }
}