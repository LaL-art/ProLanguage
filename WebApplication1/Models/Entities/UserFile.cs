using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entities;

public class UserFile
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();  // Унікальний ідентифікатор типу Guid

    [Required]
    [StringLength(255)]
    public string FileName { get; set; } 

    [Required]
    [StringLength(255)]
    public string FilePath { get; set; }  

    [Required]
    public DateTime UploadDate { get; set; } = DateTime.Now; 

    public bool IsPublic { get; set; } = false;  

    // Власник файлу (Foreign Key)
    public Guid UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
}
    
