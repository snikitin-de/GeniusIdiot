using Common.Models;

namespace GeniusIdiotWinFormsApp
{
    public partial class QuizResultsForm : Form
    {
        private bool isClosedByMenuButton = false;

        public QuizResultsForm()
        {
            InitializeComponent();
        }

        private void quizResultsForm_Load(object sender, EventArgs e)
        {
            var quizResults = MainForm.QuizResultsFileProvider.Read<QuizResult>();

            foreach (var quizResult in quizResults)
            {
                quizResultsDataGridView.Rows.Add(quizResult.User.GetFullName(), quizResult.RightAnswersCount, (int)quizResult.RightAnswersPercent, quizResult.Diagnose);
            }
        }

        private void QuizResultsForm_FormClosing(object sender, FormClosingEventArgs e)
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
                isClosedByMenuButton = true;
                Close();
            }
        }
    }
}
