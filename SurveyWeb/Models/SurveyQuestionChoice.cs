using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyWeb.Models
{
    public class SurveyQuestionChoice
    {
        public SurveyQuestionChoiceContext SurveyQuestionChoiceContext { get; set; }

        public int Id { get; set; }

        public int SurveyQuestionId { get; set; }

        public string Choice { get; set; }
    }
}
