using GamesStore.Persistence.IdTypes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesStore.Persistence.Entities;

[Table("User")]
public class User
{
    [Column("id")]
    [Key]
    public UserId Id { get; set; } = new UserId(Guid.Empty);

    [Column("full_name")]
    public string FullName { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;
}
