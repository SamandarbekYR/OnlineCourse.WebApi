using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourse.Domain.Entities.Users
{
    [Table("users")]
    public class User : Auditable
    {
        [Column("role_id")]
        public Guid RoleId { get; set; }
        public UserRole UserRole { get; set; } = default!;
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Column("gmail")]
        public string Gmail { get; set; } = string.Empty;
        [Column("image")]
        public string Image { get; set; } = string.Empty;
        [Column("password_hash")]
        public string PasswordHash { get; set; } = string.Empty;
        [Column("password_salt")]
        public string PasswordSalt { get; set; } = string.Empty;
    }
}
