using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public static class ControllerExtensions
    {
        public static ActionResult<T> Maybe<T>(this Controller controller, T entity)
        {
            if(entity == null)
            {
                return new NotFoundResult();
            }
            else
            {
                return new OkObjectResult(entity);
            }
        }

        public static ActionResult Either<T,F>(this Controller controller, bool condition)
            where T: ActionResult, new()
            where F: ActionResult, new()
        {
            if(condition)
            {
                return new T();
            }
            else
            {
                return new F();
            }
        }
    }
}
