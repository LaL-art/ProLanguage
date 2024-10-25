using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }
   
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string  IsAdmin { get; set; }
}