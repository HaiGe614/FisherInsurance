using Microsoft.AspNetCore.Mvc;

namespace FisherInsurance.controllers
{
[Route("claim")]
public class CustomerCareController : Controller 
{
    [Route("Index")]
    public IActionResult Index() {
    return Ok("This is the index of the CustCareController"); 
    }
    
    [Route("CustomerCare/claims")]
    public IActionResult quote() {
    return Ok ("This is the index of the quoteCustCareController"); 
    }

    [Route("fileclaim")]
    public IActionResult NewClaim() {
    return Ok ("This is the index of the MakeNewCustomerCareController"); 
    }

    [Route("myclaims")]
    public IActionResult ClaimHistory() {
    return Ok ("This is the index of the ClaimHistoryController"); 
    }
}
}