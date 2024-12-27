using System.Reflection;
using Furion;

namespace FurSystemTest.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
            "FurSystemTest.Application",
            "FurSystemTest.Core",
            "FurSystemTest.Web.Core"
        };
        }
    }
}