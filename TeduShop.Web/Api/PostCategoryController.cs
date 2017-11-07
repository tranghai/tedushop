using System.Collections.Generic;
using System.Web.Http;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;

namespace TeduShop.Web.Api
{
    public class PostCategoryController : ApiControllerBase
    {

        public PostCategoryController(IErrorService errorService): base(errorService) { }
        // GET: api/PostCategoryController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PostCategoryController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PostCategoryController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PostCategoryController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PostCategoryController/5
        public void Delete(int id)
        {
        }
    }
}
