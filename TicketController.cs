using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/tickets")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TicketController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetTickets()
    {
        var tickets = _context.Tickets.ToList();
        return Ok(tickets);
    }

    [HttpPost]
    public IActionResult CreateTicket([FromBody] Ticket ticket)
    {
        _context.Tickets.Add(ticket);
        _context.SaveChanges();
        return Created("", ticket);
    }
}
