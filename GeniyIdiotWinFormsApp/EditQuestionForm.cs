using Common.Models;
using System.ComponentModel;

namespace GeniusIdiotWinFormsApp
{
    public partial class EditQuestionForm : Form
    {
        private bool isClosedByMenuButton = false;

        public EditQuestionForm()
        {
            InitializeComponent();
        }

        private void editQuestionForm_Load(object sender, EventArgs e)
        {
            AddContextMenu();
            AddQuestionsToTable();
        }

        private void editQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void deleteQuestionToolStripItem_Click(object sender, EventArgs args)
        {
            var questionIndex = questionsDataGridView.CurrentRow.Index;
            var currentQuestion = MainForm.QuestionStorageSource.GetAllQuestions()[questionIndex];

            MainForm.QuestionStorageSource.Delete(currentQuestion);
            MainForm.QuestionStorageSource.Save();

            questionsDataGridView.Rows.RemoveAt(questionIndex);

            MessageBox.Show($"Вопрос: {currentQuestion.Text} удален!", "Удаление вопроса");
        }

        private void AddContextMenu()
        {
            var deleteQuestionToolStripItem = new ToolStripMenuItem();
            var strip = new ContextMenuStrip();

            deleteQuestionToolStripItem.Text = "Удалить вопрос";
            deleteQuestionToolStripItem.Click += new EventHandler(deleteQuestionToolStripItem_Click);

            foreach (DataGridViewColumn column in questionsDataGridView.Columns)
            {

                column.ContextMenuStrip = strip;
                column.ContextMenuStrip.Items.Add(deleteQuestionToolStripItem);
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var questionStorage = MainForm.QuestionStorageSource;

                var question = new Question(questionTextBox.Text, Convert.ToInt32(answerTextBox.Text));

                if (questionStorage.IsQuestionExists(question))
                {
                    MessageBox.Show("Такой вопрос уже существует! Пожалуйста, введите другой текст вопроса!", "Добавление вопроса");
                }
                else
                {
                    questionStorage.Add(question);
                    questionStorage.Save();
                    MessageBox.Show($"Вопрос: {question.Text} добавлен!", "Добавление вопроса");
                    AddQuestionsToTable();
                }

                questionTextBox.Clear();
                answerTextBox.Clear();
            }
        }

        private void AddQuestionsToTable()
        {
            var questions = MainForm.QuestionStorageSource.GetAllQuestions();

            questionsDataGridView.Rows.Clear();
            questionsDataGridView.Refresh();

            foreach (var question in questions)
            {
                questionsDataGridView.Rows.Add(question.Text);
            }
        }

        private void answerTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidNumber(answerTextBox, editQuestionErrorProvider, e, out string errorMessage))
            {
                answerValidationLabel.Text = errorMessage;
                answerValidationLabel.Visible = true;
            }
            else
            {
                answerValidationLabel.Visible = false;
            }
        }

        private void questionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidInput(questionTextBox, editQuestionErrorProvider, e, out string errorMessage))
            {
                questionTextValidationLabel.Text = errorMessage;
                questionTextValidationLabel.Visible = true;
            }
            else
            {
                questionTextValidationLabel.Visible = false;
            }
        }
    }
}
