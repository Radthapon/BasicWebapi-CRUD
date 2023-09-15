using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebapi_CRUD.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Greeting ()
        {
            return "Hi";
        }

        //CRUD
        //Create - new record => [POST]
        //Read - retrieve a single and list of record => [GET]
        //Update - modify and existing id record => [PUT]
        //Delete - remove and existing id record => [DELETE]

        // HTTP Verbs
        // GET
        // POST
        // PUT or PATCH
        // DELETE
    }
}
