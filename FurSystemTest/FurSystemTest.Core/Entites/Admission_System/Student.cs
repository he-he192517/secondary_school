using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Enum.Admission_System;
using System.ComponentModel;

namespace FurSystemTest.Core.Entites.Admission_System
{
    /// <summary>
    /// 学生表
    /// </summary>
    [SugarTable("Students")]
    public class Student
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "StudentID")]
        public int StudentId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(100)", ColumnName = "Name")]
        [Description("姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 性别（男、女）
        /// </summary>
        [SugarColumn(ColumnDataType = "int", ColumnName = "Gender")]
        [Required(ErrorMessage = "请选择")]
        [Description("性别")]
        public GenderType? Gender { get; set; }

        /// <summary>
        /// 准考证号
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(20)", ColumnName = "ExamNumber")]
        [Description("准考证号")]
        public string ExamNumber { get; set; }

        /// <summary>
        /// 考生号
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(20)", ColumnName = "CandidateNumber")]
        [Description("考生号")]
        public string CandidateNumber { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(20)", ColumnName = "PhoneNumber")]
        [Description("电话号码")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(20)", ColumnName = "IDNumber")]
        [Description("身份证号")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 学校ID
        /// </summary>
        [SugarColumn(ColumnName = "SchoolID")]
        [Description("学校名称")]
        public int SchoolId { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [SugarColumn(ColumnName = "ClassId")]
        [Description("学校名称")]
        public int ClassId { get; set; }
    }
}
