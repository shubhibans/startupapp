using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Models
{
    public class QuestionType
    {
        public string Type { get; set; }

        public ICollection<Difficulty> Difficulty_Levels { get; set; }

        public QuestionType()
        {
            Difficulty_Levels = new Collection<Difficulty>();
        }

    }
}
