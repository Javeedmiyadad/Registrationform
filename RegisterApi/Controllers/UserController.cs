using RegisterApi.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RegisterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private UserContext _userContext;

        public UserController(UserContext context)
        {
            _userContext = context;
        }

        [HttpPost]
        [Route("post")]
        public async Task<ActionResult> Post([FromBody] User user)
        {
            if (user == null)
            {
                return NotFound("User data is not supplied");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _userContext.Users.AddAsync(user);
            await _userContext.SaveChangesAsync();
            return Ok(user);
        }

        [HttpGet]
        [Route("get")]
        public List<Departments> Get()
        {
            return _userContext.department.ToList();
        }

       [HttpGet]
        [Route("getbydeptid/{id}")]
        public ActionResult<Designation> GetByDeptId(int id)
        {
            if (id <= 0)
            {
                return NotFound("department id must be higher than zero");
            }
            
            List<Designation> designations=_userContext.designation.Where(x=>x.departmentsid==id).ToList<Designation>();
 
            if (designations == null)
            {
                return NotFound("department not found");
            }
            return Ok(designations);
        }
    }


}
