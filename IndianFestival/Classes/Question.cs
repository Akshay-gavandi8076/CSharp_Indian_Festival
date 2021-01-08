using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianFestival.Classes
{
    public class Question
    {
        public int id { get; set; }
        public string qText { get; set; }
        public string qType { get; set; }
        public int image { get; set; }
        public List<Answer> answers { get; set; }

        public Question()
        {
            answers = new List<Answer>();
        }
    }

    public class Answer
    {
        public string aText { get; set; }
        public bool isCorrcect { get; set; }
    }
}
