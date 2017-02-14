using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
public class LifeController : Controller 
{
    public IActionResult Index() {
    //return Ok("This is the index of the LifeController"); 
    return View();
    }
    
    public IActionResult Quote() {
    Quote quote = new Quote 
    {            
        Id = 545,            
        Product = "Life Insurance",
        ExpireDate = DateTime.Now.AddDays(45),            
        Price = 45.00M
                
        };
    //return Ok ("This is the index of the LifeController"); 
    return View(quote); 
    }
}