using Common.Models;

namespace Common
{
    public class QuestionStorage
    {
        private FileProvider fileProvider = new FileProvider();
        private List<Question> questions = new List<Question> { };
        private List<Question> defaultQuestions = new List<Question>
        {
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
        };

        public QuestionStorage(FileProvider fileStorage)
        {
            fileProvider = fileStorage;

            if (fileProvider.Exists())
            {
                questions.AddRange(Read());
            } else
            {
                questions.AddRange(defaultQuestions);
            }
        }

        public List<Question> GetAllQuestions()
        {
            return questions;
        }

        public void Add(Question question)
        {
            questions.Add(question);
        }

        public void Delete(Question question)
        {
            var indexQuestion = questions.FindIndex(q => q.Text == question.Text);

            questions.RemoveAt(indexQuestion);
        }

        public List<Question> Read()
        {
            return fileProvider.Read<Question>();
        }

        public void Save()
        {
            var userQuestions = GetAllQuestions().ToArray();

            fileProvider.Add(userQuestions);
        }

        public bool IsQuestionExists(Question question)
        {
            return questions.Exists(q => q.Text == question.Text) || defaultQuestions.Exists(dq => dq.Text == question.Text);
        }

        public bool IsQuestionEmpty(Question question)
        {
            return string.IsNullOrEmpty(question.Text);
        }
    }
}
