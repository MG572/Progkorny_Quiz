using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfBeadando
{
    public partial class MainWindow : Window
    {
        private QuizManager _quizManager;

        public MainWindow()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            try
            {
                var questions = QuestionLoader.LoadQuestions("questions.txt");
                _quizManager = new QuizManager(questions);
                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DisplayQuestion()
        {
            AnswersPanel.Children.Clear();
            FeedbackText.Text = "";
            var question = _quizManager.GetCurrentQuestion();
            //if (question == null)
            //{
            //    FeedbackText.Text = $"Quiz complete! Your score: {_quizManager.GetScore()}/{_quizManager.GetResults().Count}";
            //    SubmitButton.IsEnabled = false;
            //    return;
            //}

            QuestionText.Text = question.Text;

            for (int i = 0; i < question.Choices.Count; i++)
            {
                var radioButton = new RadioButton
                {
                    Content = question.Choices[i],
                    GroupName = "Answers",
                    Tag = i,
                    Style = (Style)FindResource("StyledRadioButton"),
                    Padding = new Thickness(10),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalContentAlignment = VerticalAlignment.Center
                };
                AnswersPanel.Children.Add(radioButton);
            }

            QuizProgress.Value = _quizManager.GetProgress();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRadioButton = AnswersPanel.Children
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.IsChecked == true);

            if (selectedRadioButton == null)
            {
                FeedbackText.Text = "Please select an answer.";
                return;
            }

            int selectedIndex = (int)selectedRadioButton.Tag;
            _quizManager.SubmitAnswer(selectedIndex);

            if (!_quizManager.HasMoreQuestions())
            {
                ShowResults();
            }
            else
            {
                DisplayQuestion();
            }
        }

        private void ShowResults()
        {
            var resultWindow = new ResultWindow(_quizManager.GetResults(), _quizManager.GetScore(), _quizManager.GetResults().Count);
            resultWindow.Show();
            this.Close();
        }
    }
}
