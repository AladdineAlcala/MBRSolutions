using System.Collections.Generic;

namespace MBRSolutions.Services.ProductAPI.Model
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = false;
        public object Result { get; set; }
        public List<string> ErrorMessages { get; set; }
        public string DisplayMessage { get; set; }
       
       

    }
}
