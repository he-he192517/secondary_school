using System;
using System.Collections.Generic;
using Furion;
using SqlSugar;

namespace FurSystemTest.Core
{
    /// <summary>
    /// 数据库上下文对象
    /// </summary>
    public static class DbContext
    {
        /// <summary>
        /// SqlSugar 数据库实例
        /// </summary>
        public static readonly SqlSugarScope Instance = new SqlSugarScope(
            // 读取 appsettings.json 中的 ConnectionConfigs 配置节点
            App.GetConfig<List<ConnectionConfig>>("ConnectionConfigs")[0]
            , db =>
            {
                // 这里配置全局事件，比如拦截执行 SQL
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    // 打印 SQL到swegger，生产环境可以注释掉
                    App.PrintToMiniProfiler("SqlSugar Executing", sql);
                    //打印sql到控制台，生产环境可以注释掉
                    Console.WriteLine(sql);//输出sql
                };

            });
    }
}

