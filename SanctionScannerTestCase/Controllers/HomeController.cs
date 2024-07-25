using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using SanctionScannerTestCase.Models;

namespace SanctionScannerTestCase.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private OracleConnection connection = new OracleConnection();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    //BOOKS TABLE'S COLUMNS: ID(INTEGER), NAME(VARCHAR2), AUTHOR(VARCHAR2), COVER(VARCHAR2), ISINLIBRARY(BOOLEAN)

    //CRUD
    //CREATE
    public void CreateBook(string name, string author)
    {
        //couldn't create db connection, but here books will be created and added to the library db
        Book p = new Book(name, author);

        string sql = $"INSERT INTO BOOKS VALUES(${name}, ${author}, TRUE)";
    }

    //READ
    public Book GetBookInfo(int id)
    {
        string sql = $"SELECT * FROM BOOKS WHERE ID LIKE %{id}%";

        //here sql will be used and the desired info will be read

        //Book p = new Book(name, author, cover, isBookInLibrary);

        return new Book();
    }

    //UPDATE
    public void UpdateBook(Book book)
    {
        string sql = $"UPDATE BOOKS SET AUTHOR = ${book.Author}";
    }

    public void UpdateBookName()
    {
        string sql = $"UPDATE BOOKS SET ";
    }

    public void UpdateBookAuthor()
    {
        string sql = $"UPDATE BOOKS SET ";
    }

    public void UpdateBookCover()
    {
        string sql = $"UPDATE BOOKS SET ";
    }

    public void UpdateBookAvailability()
    {
        string sql = $"UPDATE BOOKS  ";
    }

    //DELETE
    public void DeleteBook(int bookID)
    {
        string sql = $"";
    }


    public bool BorrowBook(int bookID)
    {
        if (GetBookInfo(bookID).IsBookInLibrary)
        {
           return true; 
        }

        return false;
    }

    public Book ReturnInfo(int ID)
    {
        Book p;

        return new Book();
    }
}

