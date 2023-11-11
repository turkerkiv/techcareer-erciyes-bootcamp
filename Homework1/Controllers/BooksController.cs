using System.Diagnostics;
using Homework1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework1.Controllers;
public class BooksController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(BookRepository.Books);
    }

    [HttpPost]
    public IActionResult Index(string query)
    {
        List<Book> result = BookRepository.Books;

        if(!String.IsNullOrEmpty(query))
        {
            result = BookRepository.GetBookByName(query);
        }

        return View(result);
    }
}