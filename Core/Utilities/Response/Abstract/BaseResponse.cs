using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Response.Abstract
{
    public abstract class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;

        public BaseResponse(bool isSuccess) => IsSuccess = isSuccess;

        public BaseResponse(bool isSuccess, string message) : this(isSuccess) => Message = message;
        
    }
}
