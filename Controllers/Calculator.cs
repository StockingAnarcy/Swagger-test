using Microsoft.AspNetCore.Mvc; 

namespace Calculator.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet]
        [Route("add")]
        public ActionResult<int> Add(int a, int b)
        {
            return a + b;
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return a - b;
        }
        
        [HttpGet("multiply")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return a * b;
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide(int a, int b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }
}

