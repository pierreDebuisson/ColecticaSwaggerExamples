using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAPITests.Api
{
    public class ConfigTest
    {
        public string BasePath { get; set; } = "https://quill.colectica.org/";
        public string ApiKeyPrefix { get; set; } = "api_key";
        public string ApiKey { get; set; } = "QUILLTEST";
        
    }
}
