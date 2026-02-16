using System.ComponentModel.DataAnnotations;

namespace BlogApi.Web.Models;

public class Account
{
    [Key]
    public int Id { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Length(5, 20)]
    public string DisplayName {  get; set; }

    public string HashPassword { get; set; }

    public int LockInTryCount { get; set;  }
    public bool IsLocked { get; set; }

    public DateTime ModifiedDate { get; set; }
    public DateTime CreateDate { get; set; }

    public Role Role { get; set; } = Role.DefaultUser;
}