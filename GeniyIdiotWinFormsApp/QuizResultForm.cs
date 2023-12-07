using Common.Models;

namespace GeniusIdiotWinFormsApp
{
    public partial class QuizResultForm : Form
    {
        private bool isClosedByMenuButton = false;

        public QuizResultForm()
        {
            InitializeComponent();
        }

        private void QuizResultForm_Load(object sender, EventArgs e)
        {
            diagnoseLabel.Text = $"{MainForm.User.FirstName}, ваш диагноз: {QuizForm.Diagnose}.";
            rightAnswersCountLabel.Text = $"Количество правильных ответов: {QuizForm.RightAnswersCount}.";
            rightAnswersPercentLabel.Text = $"Вы ответили правильно на {(int)QuizForm.RightAnswersPercent}% вопросов.";
        }

        private void QuizResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosedByMenuButton)
            {
                Application.Exit();
            }
        }

        private void homeToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти в главное меню?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Хотите ли вы сохранить результаты тестирования?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MainForm.QuizResultsFileProvider.Append(new QuizResult(MainForm.User, QuizForm.RightAnswersCount, QuizForm.RightAnswersPercent, QuizForm.Diagnose));
                }

                QuizForm.IsClosedByMenuButton = true;
                isClosedByMenuButton = true;
                Close();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти в главное меню?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Хотите ли вы сохранить результаты тестирования?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MainForm.QuizResultsFileProvider.Append(new QuizResult(MainForm.User, QuizForm.RightAnswersCount, QuizForm.RightAnswersPercent, QuizForm.Diagnose));
                }

                QuizForm.IsClosedByMenuButton = true;
                isClosedByMenuButton = true;
                Close();
            }
        }
    }
}
