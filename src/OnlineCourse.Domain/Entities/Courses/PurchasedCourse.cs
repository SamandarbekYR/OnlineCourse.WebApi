using OnlineCourse.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Domain.Entities.Courses
{
    [Table("purchased_courses")]
    public class PurchasedCourse:BaseEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
        [Column("course_id")]
        public Guid CourseId { get; set; }
        public Course Course { get; set; } = default!;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
