using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyWeb.Models
{
    public class SurveyQuestion
    {
        public SurveyQuestionContext SurveyQuestionContext { get; set; }

        public int Id { get; set; }

        public int SurveyId { get; set; }

        public string Question { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public List<SurveyQuestionChoice> Choices { get; set; }
    }
}
