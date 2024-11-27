using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBeadando
{
    public class QuizManager
    {
        private List<Question> _questions;
        private int _currentQuestionIndex;
        private int _score;
        private List<QuizResult> _quizResults;

        public QuizManager(List<Question> questions)
        {
            _questions = questions;
            _currentQuestionIndex = 0;
            _score = 0;
            _quizResults = new List<QuizResult>();
        }

        public Question GetCurrentQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                return null;
            }

            return _questions[_currentQuestionIndex];
        }

        public void SubmitAnswer(int selectedIndex)
        {
            var currentQuestion = _questions[_currentQuestionIndex];

            _quizResults.Add(new QuizResult
            {
                Question = currentQuestion.Text,
                UserAnswer = currentQuestion.Choices[selectedIndex],
                CorrectAnswer = currentQuestion.Choices[currentQuestion.CorrectAnswerIndex]
            });

            if (selectedIndex == currentQuestion.CorrectAnswerIndex)
            {
                _score++;
            }

            _currentQuestionIndex++;
        }

        public bool HasMoreQuestions()
        {
            return _currentQuestionIndex < _questions.Count;
        }

        public int GetScore()
        {
            return _score;
        }

        public List<QuizResult> GetResults()
        {
            return _quizResults;
        }

        public double GetProgress()
        {
            return (_currentQuestionIndex / (double)_questions.Count) * 100;
        }
    }
}
