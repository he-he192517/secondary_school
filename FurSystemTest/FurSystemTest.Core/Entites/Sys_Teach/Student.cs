using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    /// <summary>
    /// 学生表
    /// </summary>
    [SugarTable("students")]
    public class Student
    {
        /// <summary>
        /// 学生ID，自增主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "StudentID")]
        [Description("序号")]
        public int StudentId { get; set; }

        /// <summary>
        /// 班级ID，假设需要与班级表关联
        /// </summary>
        [SugarColumn(ColumnName = "ClassID")]
        [Description("班级ID")]
        public int ClassId { get; set; }

        /// <summary>
        /// 学生姓名，非空
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(100)", ColumnName = "Name")]
        [Description("学生姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [SugarColumn(ColumnDataType = "enum('男','女')", ColumnName = "Gender")]
        [Description("性别")]
        public string Gender { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [SugarColumn(ColumnDataType = "date", ColumnName = "BirthDate")]
        [Description("出生日期")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(50)", ColumnName = "Ethnicity")]
        [Description("民族")]
        public string Ethnicity { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(18)", ColumnName = "IDCardNumber")]
        [Description("身份证号")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 学籍状态
        /// </summary>
        [SugarColumn(ColumnDataType = "enum('在读','已毕业','休学','退学')", ColumnName = "EnrollmentStatus")]
        [Description("学籍状态")]
        public string EnrollmentStatus { get; set; }

        /// <summary>
        /// 入学时间
        /// </summary>
        [SugarColumn(ColumnDataType = "date", ColumnName = "EnrollmentDate")]
        [Description("入学时间")]
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(15)", ColumnName = "PhoneNumber")]
        [Description("联系电话")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(20)", ColumnName = "StudentNumber")]
        [Description("学号")]
        public string StudentNumber { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [SugarColumn(ColumnDataType = "text", ColumnName = "Remarks")]
        [Description("备注字段")]
        public string Remarks { get; set; }
    }
}
