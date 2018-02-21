using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Controllers.Resources
{
    public class QuestionTypeResource
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public ICollection<DifficultyResource> Difficulty_Levels { get; set; }

        public QuestionTypeResource()
        {
            Difficulty_Levels = new Collection<DifficultyResource>();
        }

    }
}
