using Microsoft.AspNetCore.Mvc;

namespace OA.API.Filters
{
    public class IsExistsAttribute : TypeFilterAttribute
    {
        public IsExistsAttribute() : base(typeof(IsExistsOperation))
        {
        }
    }
}
