using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Core.Entities.OnlineTest
{
    public class TestDetail
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public DateTime TestDateTime { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        public int QuestionCount { get; set; }
        public string TimeLimit { get; set; }
    }
}
