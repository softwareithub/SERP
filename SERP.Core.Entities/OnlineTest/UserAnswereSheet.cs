using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Core.Entities.OnlineTest
{
    public class UserAnswereSheet
    {
        public int TestDetailId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public int CandidateId { get; set; }
    }
}
