using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BPO.Web.Models;

namespace BPO.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Task")]
    public class TaskController : Controller
    {
        public List<Project> Judge(string userId,bool locked)
        {
            throw new NotImplementedException();
        }
    }
}