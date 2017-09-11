using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAPITests.Api
{
    public class ConfigTest
    {
        public string BasePath { get; set; } = "http://localhost:5000";
        public string ApiKeyPrefix { get; set; } = "api_key";
        public string ApiKey { get; set; } = "ADMINKEY";
        
    }
}
