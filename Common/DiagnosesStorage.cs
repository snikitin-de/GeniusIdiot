using Common.Models;

namespace Common
{
    public class DiagnosesStorage
    {
        public static List<Diagnose> GetDiagnoses()
        {
            return new List<Diagnose>
            {
                new Diagnose("Идиот"),
                new Diagnose("Кретин"),
                new Diagnose("Дурак"),
                new Diagnose("Нормальный"),
                new Diagnose("Талант"),
                new Diagnose("Гений")
            };
        }

        public static string GetCalculatedDiagnose(int rightAnswersCount, int questionsCount)
        {
            var diagnoses = GetDiagnoses();
            var diagnoseRange = 0d;
            var diagnoseRanges = new List<KeyValuePair<string, double>>();
            var step = 100d / diagnoses.Count;

            foreach (var diagnose in diagnoses)
            {
                diagnoseRanges.Add(new KeyValuePair<string, double>(diagnose.Text, diagnoseRange));
                diagnoseRange += step;
            }
           
            var minimumDiagnoseRangePercent = diagnoseRanges[0].Value;
            var maximumDiagnoseRangePercent = diagnoseRanges[diagnoses.Count - 1].Value;
            var userDiagnose = string.Empty;
            var rightAnswersPercent = Math.Round(rightAnswersCount / (double)questionsCount * 100, 1);

            if (rightAnswersPercent <= Math.Round(minimumDiagnoseRangePercent, 1))
            {
                userDiagnose = diagnoseRanges[0].Key;
            }

            if (rightAnswersPercent >= Math.Round(maximumDiagnoseRangePercent, 1))
            {
                userDiagnose = diagnoseRanges[diagnoses.Count - 1].Key;
            }

            for (int i = 1; i < diagnoses.Count; i++)
            {
                var previousDiagnoseRangePercent = diagnoseRanges[i - 1].Value;
                var currentDiagnoseRangePercent = diagnoseRanges[i].Value;

                if ((rightAnswersPercent <= Math.Round(currentDiagnoseRangePercent, 1) && rightAnswersPercent > Math.Round(previousDiagnoseRangePercent, 1)))
                {
                    userDiagnose = diagnoseRanges[i - 1].Key;
                }
            }

            return userDiagnose;
        }
    }
}
