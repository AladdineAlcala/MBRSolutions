using System.Collections.Generic;

namespace MBRSolutions.Web.Models
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = false;
        public object Result { get; set; }
        public List<string> ErrorMessages { get; set; }
        public string DisplayMessage { get; set; }
       
       

    }
}
