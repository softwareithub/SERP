using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Core.Entities.OnlineTest
{
    public class TestQuestionDetail
    {
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public string Question { get; set; }
        public int QuestionPoint { get; set; }
        public string Option { get; set; }
    }
}
