using System;
using System.ComponentModel.DataAnnotations;

public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    
    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    public string Status { get; set; } = "Open";

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
