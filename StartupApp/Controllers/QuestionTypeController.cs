using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StartupApp.Controllers.Resources;
using StartupApp.Models;
using StartupApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Controllers
{
    public class QuestionTypeController : Controller
    {
        private readonly IMapper mapper;

        public QuestionTypeController(AppDBContext context, IMapper mapper)
        {
            this.Context = context;
            this.mapper = mapper;
        }

        public AppDBContext Context { get; }

        [HttpGet("/api/getDifficulty")]
        public IEnumerable<QuestionTypeResource> GetQuestionTypes()
        {
            var Question_Types=Context.Questiontypes.Include(m => m.Difficulty_Levels).ToList();
            return mapper.Map<List<QuestionType>, List<QuestionTypeResource>>(Question_Types);
        }
    }
}
