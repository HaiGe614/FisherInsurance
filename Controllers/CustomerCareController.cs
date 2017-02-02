using Microsoft.AspNetCore.Mvc;
public class CustomerCareController : Controller 
{
    public IActionResult Index() {
    return Ok("This is the index of the CustCareController"); 
    }
    
    [Route("CustomerCare/claims")]
    public IActionResult quote() {
    return Ok ("This is the index of the quoteCustCareController"); 
    }
    
}