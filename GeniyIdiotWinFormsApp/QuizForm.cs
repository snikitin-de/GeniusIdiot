using Common;
using Common.Models;

namespace GeniusIdiotWinFormsApp
{
    public partial class QuizForm : Form
    {
        public static bool IsClosedByMenuButton = false;
        public static int RightAnswersCount;
        public static double RightAnswersPercent;
        public static string Diagnose;
        private List<Question> questions;
        private Question currentQuestion;
        private int questionsCount;
        private int questionsIndex = 0;
        private int userAnswer;

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            NewQuiz();
            QuizProgressToolStripProgressBar.Maximum = questionsCount;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (questions.Count() > 0)
                {
                    AcceptUserAnswer();
                    ShowNextQuestion();
                    DeleteCurrentQuestion();
                }
                else
                {
                    AcceptUserAnswer();

                    EndQuiz();
                    nextButton.Enabled = false;
                }

                userAnswerTextBox.Clear();
            }
        }

        private void userAnswerTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Validation.IsValidNumber(userAnswerTextBox, quizFormErrorProvider, e, out string errorMessage))
            {
                userAnswerValidationLabel.Text = errorMessage;
                userAnswerValidationLabel.Visible = true;
            }
            else
            {
                userAnswerValidationLabel.Visible = false;
            }
        }

        private void AcceptUserAnswer()
        {
            userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                RightAnswersCount++;
            }
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count());

            currentQuestion = questions[randomIndex];
            questionsIndex++;
            questionNumberLabel.Text = $"Вопрос №{questionsIndex}";
            questionTextLabel.Text = $"Текст вопроса: {currentQuestion.Text}";
            quizProgressToolStripStatusLabel.Text = $"Прогресс прохождения {questionsIndex}/{questionsCount}";
            QuizProgressToolStripProgressBar.Value = questionsIndex;

            questionTimer.Enabled = true;
            questionTimeLeftProgressBar.Value = 0;
            questionTimeLeftLabel.Text = $"Осталось времени: {questionTimeLeftProgressBar.Maximum} с";
        }

        private void DeleteCurrentQuestion()
        {
            MainForm.QuestionStorageQuiz.Delete(currentQuestion);
        }

        private void NewQuiz()
        {
            MessageBox.Show("На каждый вопрос дается 10 секунд! Если ответ на вопрос не дан, то засчитывается неверный ответ!", "Викторина");
            MainForm.QuestionStorageQuiz = new QuestionStorage(MainForm.QuestionsFileProvider);
            questions = MainForm.QuestionStorageQuiz.GetAllQuestions();
            questionsCount = questions.Count;
            questionsIndex = 0;
            RightAnswersCount = 0;

            ShowNextQuestion();
            DeleteCurrentQuestion();
        }

        private void EndQuiz()
        {
            questionTimer.Stop();
            RightAnswersPercent = RightAnswersCount / (double)questionsCount * 100;
            Diagnose = DiagnosesStorage.GetCalculatedDiagnose(RightAnswersCount, questionsCount);

            Hide();
            var quizResultForm = new QuizResultForm();
            quizResultForm.Size = Size;
            quizResultForm.Location = Location;
            quizResultForm.WindowState = WindowState;
            quizResultForm.ShowDialog();
            MainForm.FormSize = quizResultForm.Size;
            MainForm.FormLocation = quizResultForm.Location;
            MainForm.FormState = quizResultForm.WindowState;
            Close();
        }

        private void homeToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти? Викторина завершится!", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainForm.FormSize = Size;
                MainForm.FormLocation = Location;
                MainForm.FormState = WindowState;
                IsClosedByMenuButton = true;
                Close();
            }
        }

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsClosedByMenuButton)
            {
                Application.Exit();
            }
        }

        private void userAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextButton_Click(this, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            var currentProgressValue = questionTimeLeftProgressBar.Value;

            if (currentProgressValue != questionTimeLeftProgressBar.Maximum)
            {
                var timeLeft = questionTimeLeftProgressBar.Maximum - currentProgressValue;

                questionTimeLeftProgressBar.Value++;
                questionTimeLeftLabel.Text = $"Осталось времени: {timeLeft} с";
            }
            else
            {
                questionTimer.Stop();

                if (questionsIndex != questionsCount)
                {
                    ShowNextQuestion();
                }
                else
                {
                    EndQuiz();
                }
            }
        }
    }
}
