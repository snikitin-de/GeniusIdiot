using Common;
using Common.Models;

namespace GeniusIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        public static Size FormSize;
        public static Point FormLocation;
        public static FormWindowState FormState;
        public static string SettingsPath = "settings.json";
        public static FileProvider QuestionsFileProvider;
        public static FileProvider QuizResultsFileProvider;
        public static FileProvider SettingsFileProvider;
        public static QuestionStorage QuestionStorageSource;
        public static QuestionStorage QuestionStorageQuiz;
        public static User User;
        private SettingsStorage settingsStorage;
        private Setting defaultQuestionsPath;
        private Setting defaultQuizResultsPath;
        private string greetingText;

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            greetingText = greetingLabel.Text;

            ChangeUser();

            SettingsFileProvider = new FileProvider(SettingsPath);
            settingsStorage = new SettingsStorage(SettingsFileProvider);

            if (!SettingsFileProvider.Exists())
            {
                settingsStorage.Add("questionsPath", "questions.json");
                settingsStorage.Add("quizResultsPath", "quizResults.json");
                settingsStorage.Save();
            }

            QuizResultsFileProvider = new FileProvider(settingsStorage.Get("quizResultsPath", defaultQuizResultsPath));
            QuestionsFileProvider = new FileProvider(settingsStorage.Get("questionsPath", defaultQuestionsPath));
            QuestionStorageSource = new QuestionStorage(QuestionsFileProvider);
            QuestionStorageSource.Save();
        }

        private void showQuizResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var quizResultsForm = new QuizResultsForm();
            SetChildFormSize(quizResultsForm);
            quizResultsForm.ShowDialog();
            SetMainFormSize(quizResultsForm);
            Show();
        }

        private void editQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var editQuestionForm = new EditQuestionForm();
            SetChildFormSize(editQuestionForm);
            editQuestionForm.ShowDialog();
            SetMainFormSize(editQuestionForm);
            Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var settingsForm = new SettingsForm();
            SetChildFormSize(settingsForm);
            settingsForm.ShowDialog();
            SetMainFormSize(settingsForm);
            Show();
        }

        private void startQuizButton_Click(object sender, EventArgs e)
        {
            Hide();
            var quizForm = new QuizForm();
            SetChildFormSize(quizForm);
            quizForm.ShowDialog();
            Size = FormSize;
            Location = FormLocation;
            WindowState = FormState;
            Show();
        }

        private void showQuizResultsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var quizResultsForm = new QuizResultsForm();
            SetChildFormSize(quizResultsForm);
            quizResultsForm.ShowDialog();
            SetMainFormSize(quizResultsForm);
            Show();
        }

        private void restartAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void ChangeUser()
        {
            Hide();

            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.isLogon)
            {
                User = loginForm.user;
                greetingLabel.Text = $"{User.FirstName}, {greetingText}";
                greetingLabel.Left = Size.Width / 2 - greetingLabel.Width / 2 - 5;

                SetMainFormSize(loginForm);
                Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void SetChildFormSize(Form form)
        {
            form.Size = Size;
            form.Location = Location;
            form.WindowState = WindowState;
        }

        private void SetMainFormSize(Form form)
        {
            Size = form.Size;
            Location = form.Location;
            WindowState = form.WindowState;
        }
    }
}