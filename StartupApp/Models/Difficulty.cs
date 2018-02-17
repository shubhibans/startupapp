using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Models
{
    public class Difficulty
    {

        public int Id { get; set; }

        public string Difficulty_Level { get; set; }

        public QuestionType QuestionType { get; set; }

        public string QuestionTypeType { get; set; }
    }
}
