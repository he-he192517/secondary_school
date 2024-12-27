using Furion.ConfigurableOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application;

public class AppInfoOptions : IConfigurableOptions
{
    public string ClientId { get; set; }
    public string Version { get; set; }
    public string Company { get; set; }
}
