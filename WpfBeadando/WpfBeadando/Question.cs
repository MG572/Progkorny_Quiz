using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBeadando
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }

}
