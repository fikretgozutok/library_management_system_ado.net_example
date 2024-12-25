using Core.Utilities.Response.Abstract;

namespace Core.Utilities.Response.Concrete
{
    public class ErrorResponse : BaseResponse
    {
        public ErrorResponse() : base(false) { }
        public ErrorResponse(string message) : base(false, message) { }
    }
}
