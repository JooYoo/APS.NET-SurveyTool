using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyWeb.Models
{
    public class SurveyParticipation
    {
        public SurveyParticipationContext context { get; set; }

        public int User_ID { get; set; }

        public int Survey_ID{ get; set; }

        public string ParticipationDate { get; set; }

        public int ID { get; set; }
    }
}
