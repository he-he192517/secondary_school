using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Admission_System;
using FurSystemTest.Core.Enum.Admission_System;

namespace FurSystemTest.Application.Services.Admission_System
{
    public class ClassService : IClassService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        /// <summary>
        /// 分班
        /// </summary>
        /// <param name="asAdmissions">按成绩排序后的学生列表</param>
        /// <param name="numberOfClasses">班级数量</param>
        /// <param name="method">分班方式: 1 表示按成绩，2 表示平均分配</param>
        /// <returns></returns>
        public async Task<bool> DiviClass(List<Admission> asAdmissions, int numberOfClasses, int method)
        {
            // 按成绩排序后的录取学生列表
            var sortedAdmissions = asAdmissions.OrderByDescending(a => a.TotalScore).ToList();

            var classList = InitializeClasses(numberOfClasses);

            if (method == 1)
            {
                for (var i = 0; i < numberOfClasses; i++)
                {
                    var currentClass = classList[i];
                    var studentcount = sortedAdmissions.Count / numberOfClasses;
                    var classId = await SaveClass(currentClass);
                    for (int j = i * studentcount; j < i * (studentcount + 1); j++)
                    {
                        sortedAdmissions[j].ClassId = classId;
                    }
                }
                // 方式 1：按成绩顺序固定人数分配
                for (var i = 0; i < sortedAdmissions.Count; i++)
                {
                    var classIndex = i / numberOfClasses; // 每 numberOfClasses 名学生分配到同一班级
                    var currentClass = classList[classIndex];

                    if (classIndex < classList.Count)
                    {
                        //classList[classIndex].Students.Add(sortedAdmissions[i]);
                    }
                }
            }
            else if (method == 2)
            {
                // 方式 2：按平均分配（循环分配）
                for (int i = 0; i < sortedAdmissions.Count; i++)
                {
                    int classIndex = i % numberOfClasses;
                    //classList[classIndex].Students.Add(sortedAdmissions[i]);
                }
            }

            // 保存班级到数据库
            return await SaveClassList(classList);
        }

        /// <summary>
        /// 初始化班级列表
        /// </summary>
        private static List<Class> InitializeClasses(int numberOfClasses)
        {
            var classList = new List<Class>();
            for (var i = 0; i < numberOfClasses; i++)
            {
                classList.Add(new Class
                {
                    ClassName = $"班级 {i + 1}",
                    SchoolID = 1,
                    GradeName = Grade.Grade1
                });
            }
            return classList;
        }

        /// <summary>
        /// 创建class
        /// </summary>
        /// <param name="classList"></param>
        /// <returns></returns>
        public async Task<bool> SaveClassList(List<Class> classList)
        {
            return await _db.Storageable(classList).ExecuteCommandAsync() > 0;
        }

        /// <summary>
        /// 新增班级
        /// </summary>
        /// <param name="cClass"></param>
        /// <returns></returns>
        public async Task<int> SaveClass(Class cClass)
        {
            return await _db.Insertable(cClass).ExecuteReturnIdentityAsync();
        }
    }
}
