using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessEntity.Test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjectForGitLabCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestMath testMath;
        public TestController(ITestMath _testMath)
        {
            testMath = _testMath;
        }
        public IActionResult AddTwoNumber(int a, int b)
        {
            return Ok(testMath.AddTwoNum(a, b));
        }
    }
}
