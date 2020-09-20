using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using _4_1.Models;
using System.Runtime.CompilerServices;

public class HomeController : Controller
{
    private ContactContext context { get; set; }

    public HomeController(ContactContext ctx)
    {
        context = ctx;
    }

    public IActionResult Index()
    {
        //        var contacts = context.Contacts.OrderBy(m => m.CategoryID).ToList();
        var contacts = context.Contacts.ToList();
        return View(contacts);
    }
} 