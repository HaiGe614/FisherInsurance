using System;
using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.controllers{
public class HomeController : Controller 
{
    public IActionResult Index() {
    //return Ok("This is the index of the HomeController"); 
    return View()
    ;
} 
}
}