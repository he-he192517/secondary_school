using FurSystemTest.Core.Enum.Admission_System;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Dtos.Admission_System
{
    public class StuAdmissionDto
    {
        [Description("姓名")]
        public string Name { get; set; }

        [Description("性别")]
        public GenderType? Gender { get; set; }

        [Description("准考证号")]
        public string ExamNumber { get; set; }

        [Description("考生号")]
        public string CandidateNumber { get; set; }

        [Description("电话号码")]
        public string PhoneNumber { get; set; }

        [Description("身份证号")]
        public string IdNumber { get; set; }

        [Description("学校名称")]
        public int SchoolId { get; set; }

        [Description("总分")]
        public decimal TotalScore { get; set; }

        [Description("录取院校")]
        public int AdmittedSchool { get; set; }

        [Description("通知书确认状态")]
        public NoticeType AdmissionNoticeConfirmed { get; set; } = NoticeType.Unconfirmed;

        [Description("录取时间")]
        public DateTime AdmissionTime { get; set; } = DateTime.Now;
    }
}
