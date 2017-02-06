using Microsoft.AspNetCore.Mvc;
[Route("customer")]
public class CustomerCareController : Controller 
{
    public IActionResult Index() {
    return Ok("This is the index of the CustCareController"); 
    }
    
    [Route("CustomerCare/claims")]
    public IActionResult quote() {
    return Ok ("This is the index of the quoteCustCareController"); 
    }

    [Route("claim/fileclaim")]
    public IActionResult NewClaim() {
    return Ok ("This is the index of the MakeNewCustomerCareController"); 
    }

    [Route("claim/myclaims")]
    public IActionResult ClaimHistory() {
    return Ok ("This is the index of the ClaimHistoryController"); 
    }
}