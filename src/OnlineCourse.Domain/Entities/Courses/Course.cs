using OnlineCourse.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourse.Domain.Entities.Courses
{
    [Table("courses")]
    public class Course : Auditable
    {
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Column("price")]
        public double Price { get; set; }
        [Column("image")]
        public string Image { get; set; } = string.Empty;
    }
}
