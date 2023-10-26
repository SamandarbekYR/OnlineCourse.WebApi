using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourse.Domain.Entities.Users
{
    [Table("user_role")]
    public class UserRole : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;
    }
}
