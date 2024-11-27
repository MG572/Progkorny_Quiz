using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBeadando
{
    public class QuestionLoader
    {
        public static List<Question> LoadQuestions(string filePath)
        {
            var questions = new List<Question>();

            try
            {
                var lines = File.ReadAllLines(filePath);
                int i = 0;

                while (i < lines.Length)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                    {
                        i++;
                        continue;
                    }

                    var questionText = lines[i].Trim();
                    i++;

                    var choices = new List<string>();
                    while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]) && !int.TryParse(lines[i].Trim(), out _))
                    {
                        choices.Add(lines[i].Trim());
                        i++;
                    }

                    if (choices.Count == 0)
                    {
                        throw new Exception("Error: Missing choices for a question.");
                    }

                    int correctAnswerIndex = -1;
                    if (i < lines.Length && int.TryParse(lines[i].Trim(), out correctAnswerIndex) && correctAnswerIndex >= 0 && correctAnswerIndex < choices.Count)
                    {
                        i++;
                    }
                    else
                    {
                        throw new Exception("Error: Invalid correct answer index.");
                    }

                    questions.Add(new Question
                    {
                        Text = questionText,
                        Choices = choices,
                        CorrectAnswerIndex = correctAnswerIndex
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading questions: {ex.Message}");
            }

            return questions;
        }
    }
}


//private void LoadQuestions()
//{
//    _questions = new List<Question>
//{
//    new Question { Text = "What is the capital of France?",
//                   Choices = new List<string> { "Berlin", "Madrid", "Paris", "Rome" },
//                   CorrectAnswerIndex = 2 },
//    new Question { Text = "Which planet is known as the Red Planet?",
//                   Choices = new List<string> { "Earth", "Mars", "Jupiter", "Venus" },
//                   CorrectAnswerIndex = 1 },
//    new Question { Text = "What is 2 + 2?",
//                   Choices = new List<string> { "3", "4", "5", "6" },
//                   CorrectAnswerIndex = 1 }
//};
//}