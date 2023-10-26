using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Domain.Entities.Courses
{
    [Table("course_videos")]
    public class CourseVideo : Auditable
    {
        [Column("course_id")]
        public Guid CourseId { get; set; }
        public CourseVideo Course { get; set; } = default!;
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Column("video")]
        public string Video { get; set; } = string.Empty;
        [Column("video_image")]
        public string VidoeImage { get; set; } = string.Empty;
        [Column("video_viewed")]
        public bool VideoViewad { get; set; } = false;
    }
}
