using Desafio_prático___Gestão_de_Livraria.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_prático___Gestão_de_Livraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var response = new Book
        {
            Id = id,
            Title = "Qualquer",
            Author = "Felipe",
            AmountStock = 2,
            Gender = "Terror",
            Price = 23.30M
        };

        return Ok(response);
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        var response = new Book
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            AmountStock = book.AmountStock,
            Gender = book.Gender,
            Price = book.Price
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    public IActionResult Update(Book book)
    {
        return NoContent();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAll(int id)
    {
        var response = new List<Book>()
        {
            new Book { Id = 1 },
            new Book { Id = 2 },
            new Book { Id = 3 },
        };

        return Ok(response);
    }
}
