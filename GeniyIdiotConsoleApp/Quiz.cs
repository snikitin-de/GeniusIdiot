using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusIdiotConsoleApp
{
    public class Quiz
    {
        public static int? userAnswer;

        public static void ShowQuizResults(List<QuizResult> quizResults)
        {
            var borderTableLength = 114;
            var headerFormat = "|{0,-40}|{1,-40}|{2,-30}|";
            var rowFormat = "|{0,-40}|{1,40}|{2,-30}|";

            Console.Clear();
            Console.ForegroundColor = ConsoleColors.ResultConsoleColor;
            QuizIO.PrintText("> Результаты викторин\n", ConsoleColors.UserInteractionConsoleColor);
            Console.WriteLine(new string('-', borderTableLength));
            Console.WriteLine(headerFormat, "Имя пользователя", "Количество/процент правильных ответов", "Диагноз пользователя");
            Console.WriteLine(new string('-', borderTableLength));

            foreach (var quizResult in quizResults)
            {
                Console.WriteLine(rowFormat, quizResult.User.GetFullName(), $"{quizResult.RightAnswersCount}/{(int)quizResult.RightAnswersPercent}%", quizResult.Diagnose);
            }

            Console.WriteLine(new string('-', borderTableLength));
            Console.ResetColor();
        }

        public static int GetQuizResult(QuestionStorage questionStorage)
        {
            var rightAnswersCount = 0;
            var questions = questionStorage.GetAllQuestions().ToList();
            var questionsCount = questions.Count;
            var random = new Random();

            for (var i = 0; i < questionsCount; i++)
            {
                var randomQuestionsIndex = random.Next(0, questions.Count);

                QuizIO.PrintText($"\nВопрос №{i + 1}", ConsoleColors.UserInteractionConsoleColor);
                QuizIO.PrintText(questions[randomQuestionsIndex].Text, ConsoleColors.UserInteractionConsoleColor);

                var userAnswer = QuizIO.GetNumber();
                var rightAnswer = questions[randomQuestionsIndex].Answer;

                if (userAnswer == rightAnswer)
                {
                    rightAnswersCount++;
                }

                questions.RemoveAt(randomQuestionsIndex);
            }

            return rightAnswersCount;
        }

        public static void ShowQuestions(QuestionStorage questionStorage)
        {
            var borderTableLength = 116;
            var headerFormat = "|{0,-23}|{1,-90}|";
            var rowFormat = "|{0,23}|{1,-90}|";

            Console.Clear();
            Console.ForegroundColor = ConsoleColors.ResultConsoleColor;
            QuizIO.PrintText("> Список вопросов\n", ConsoleColors.UserInteractionConsoleColor);
            Console.WriteLine(new string('-', borderTableLength));
            Console.WriteLine(headerFormat, "Идентификатор вопроса", "Текст вопроса");
            Console.WriteLine(new string('-', borderTableLength));

            var questions = questionStorage.GetAllQuestions();

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(rowFormat, i, questions[i].Text);
            }

            Console.WriteLine(new string('-', borderTableLength));
            Console.ResetColor();
        }

        public static Question GetQuestion()
        {
            QuizIO.PrintText($"\nВведите текст вопроса", ConsoleColors.UserInteractionConsoleColor);
            var question = Console.ReadLine();

            QuizIO.PrintText($"\nВведите правильный ответ. Ответ должен быть числом.", ConsoleColors.UserInteractionConsoleColor);
            var answer = QuizIO.GetNumber();

            Console.WriteLine();

            return new Question(question, answer);
        }

        public static void AddQuestions(QuestionStorage questionStorage)
        {
            Console.Clear();
            QuizIO.PrintText($"> Добавление вопроса", ConsoleColors.UserInteractionConsoleColor);

            do
            {
                var isCorrectQuestion = false;
                var question = new Question();

                while (!isCorrectQuestion)
                {
                    question = GetQuestion();

                    if (questionStorage.IsQuestionEmpty(question))
                    {
                        QuizIO.PrintText($"Вопрос не может быть пустым! Введите корректный вопрос.", ConsoleColors.ErrorConsoleColor);
                    }
                    else if (questionStorage.IsQuestionExists(question))
                    {
                        QuizIO.PrintText($"Вопрос уже существует! Введите другой вопрос.", ConsoleColors.ErrorConsoleColor);
                    }
                    else
                    {
                        break;
                    }
                }

                questionStorage.Add(question);

                QuizIO.PrintText($"Не хотите ли добавить еще вопрос для векторины? Введите \"да\" или \"нет\".", ConsoleColors.UserInteractionConsoleColor);
            } while (QuizIO.GetChoice());
        }

        public static void DeleteQuestions(QuestionStorage questionStorage)
        {
            Console.Clear();
            QuizIO.PrintText($"> Удаление вопроса", ConsoleColors.UserInteractionConsoleColor);

            if (questionStorage.GetAllQuestions().Count == 0)
            {
                QuizIO.PrintText($"\nОтсутствуют вопросы для тестирования.", ConsoleColors.WarningConsoleColor);
            }
            else
            {
                do
                {
                    ShowQuestions(questionStorage);

                    QuizIO.PrintText($"\nВведите идентификатор вопроса, который желаете удалить.", ConsoleColors.UserInteractionConsoleColor);
                    var questionIndex = (int)QuizIO.GetNumberBetweenMinMax(0, questionStorage.GetAllQuestions().Count);

                    questionStorage.Delete(questionStorage.GetAllQuestions()[questionIndex]);

                    ShowQuestions(questionStorage);
                    questionStorage.Save();

                    if (questionStorage.GetAllQuestions().Count == 0)
                    {
                        QuizIO.PrintText($"\nОтсутствуют вопросы для тестирования.", ConsoleColors.WarningConsoleColor);
                    }
                    else
                    {
                        QuizIO.PrintText($"\nНе хотите ли удалить еще вопрос из векторины? Введите \"да\" или \"нет\".", ConsoleColors.UserInteractionConsoleColor);
                        if (!QuizIO.GetChoice())
                        {
                            break;
                        }
                    }
                } while (questionStorage.GetAllQuestions().Count != 0);
            }
        }

        public static void StartQuiz(QuestionStorage questionStorage, User user)
        {
            var questionsCount = questionStorage.GetAllQuestions().Count;
            var resultConsoleColor = ConsoleColor.Cyan;
            var quizResultsFileProvider = new FileProvider("quizResults.json");

            Console.Clear();
            QuizIO.PrintText($"> Викторина", ConsoleColors.UserInteractionConsoleColor);

            var userName = user.FirstName;
            var rightAnswersCount = GetQuizResult(questionStorage);
            var rightAnswersPercent = rightAnswersCount / (double)questionsCount * 100;
            var diagnose = DiagnosesStorage.GetCalculatedDiagnose(rightAnswersCount, questionsCount);

            QuizIO.PrintText($"\nКоличество правильных ответов: {rightAnswersCount}. Вы ответили правильно на {(int)rightAnswersPercent}% вопросов.", resultConsoleColor);
            QuizIO.PrintText($"{userName}, ваш диагноз: {diagnose}.", resultConsoleColor);

            quizResultsFileProvider.Append(new QuizResult(user, rightAnswersCount, rightAnswersPercent, diagnose));

        }
    }
}
