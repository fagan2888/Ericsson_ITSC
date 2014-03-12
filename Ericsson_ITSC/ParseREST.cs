using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ericsson_ITSC
{
    public class ParseREST
    {
        var service = new RESTService("http://restservice.com");
        service.SetBasicAuthentication(Settings.AppNameCapitalized, Settings.AppKey);

        //ilki giden data, ikincisi gelen data
        var command = new RESTCommand<IEnumerable<Packages>, IEnumerable<Packages>>()
        {
            Query = "api/themepack",
            QueryParameter = "parametre",
            Type = RESTCommandType.GET,
            Body = package
        };

 
        var result = await service.Execute(command);
    }
}
