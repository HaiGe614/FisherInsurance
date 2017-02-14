using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
public class HouseController : Controller 
{
    public IActionResult Index() {
    //return Ok("This is the index of the HouseController"); 
    return View();
    }
    
    public IActionResult Quote() {
    Quote quote = new Quote 
    {            
        Id = 445,            
        Product = "House Insurance",
        ExpireDate = DateTime.Now.AddDays(45),            
        Price = 45.00M
                
        };
    //return Ok ("This is the index of the HouseController"); 
    return View(quote);

    }
}