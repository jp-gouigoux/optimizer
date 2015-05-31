using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Optimizer
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        // GET: /api/jobs
        public IEnumerable<Job> GetAll()
        {
            return new List<Job>
            {
                new Job { Id = "a34b678", RepaymentAmount = 1000, Done = false },
                new Job { Id = "12cf45e", RepaymentAmount = 300, Done = false },
            };
        }
    }
}
