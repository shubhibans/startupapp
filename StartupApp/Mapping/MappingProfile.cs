using AutoMapper;
using StartupApp.Controllers.Resources;
using StartupApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QuestionType, QuestionTypeResource>();
            CreateMap<Difficulty, DifficultyResource>();
        }
    }
}
