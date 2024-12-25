using Core.Utilities.Response.Abstract;

namespace Core.Utilities.Response.Concrete
{
    public class SuccessResponse : BaseResponse
    {
        public SuccessResponse() : base(true) { }
        public SuccessResponse(string message) : base(true, message) { }
    }
}
