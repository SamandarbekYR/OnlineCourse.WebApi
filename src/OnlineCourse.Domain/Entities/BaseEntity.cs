using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key,Required]
        [Column("id")]
        public Guid Id { get; set; }
    }
}
