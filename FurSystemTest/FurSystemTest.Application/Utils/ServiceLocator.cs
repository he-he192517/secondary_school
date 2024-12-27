using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Utils
{
    /// <summary>
    /// Ioc获取
    /// </summary>
    public class ServiceLocator
    {
        public static IServiceProvider Instance { get; set; }
    }
}
