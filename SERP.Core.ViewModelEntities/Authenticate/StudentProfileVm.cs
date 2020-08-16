using System;
using System.Collections.Generic;
using System.Text;

namespace SERP.Core.ViewModelEntities.Authenticate
{
    public class StudentProfileVm
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string RegistrationNumber { get; set; }
        public string RollCode { get; set; }
        public string ClassName { get; set; }
        public string BatchName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string FatherPhone { get; set; }
        public string P_Address { get; set; }
        public string C_Address { get; set; }
        public string ParentPhoto { get; set; }
        public string StudentPhoto { get; set; }
        public string FatherEmail { get; set; }

    }
}
