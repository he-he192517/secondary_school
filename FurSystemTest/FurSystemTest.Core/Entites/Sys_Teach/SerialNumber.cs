using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    [SugarTable("serial_number")]
    public class SerialNumber
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true,ColumnName = "serial_id")]
        public int SerialId { get; set; }

        [SugarColumn(ColumnName = "student_serial")]
        public string StudentSerial { get; set; }

        [SugarColumn(ColumnName = "teacher_serial")]
        public string TeacherSerial { get; set; }

}
    }
