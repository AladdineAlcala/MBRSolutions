using MBRSolutions.Web.HelperClass;
using System.Runtime.CompilerServices;

namespace MBRSolutions.Web.Models
{
    public class APIRequest
    {
        public APIType APIType { get; set; } = APIType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
