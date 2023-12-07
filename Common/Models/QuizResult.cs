namespace Common.Models
{
    public class QuizResult
    {
        public User User { get; set; }
        public int RightAnswersCount { get; set; }
        public double RightAnswersPercent { get; set; }
        public string Diagnose { get; set; }

        public QuizResult() { }

        public QuizResult(User user, int rightAnswersCount, double rightAnswersPercent, string diagnose)
        {
            User = user;
            Diagnose = diagnose;
            RightAnswersCount = rightAnswersCount;
            RightAnswersPercent = rightAnswersPercent;
        }
    }
}