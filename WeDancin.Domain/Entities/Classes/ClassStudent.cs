using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;

namespace WeDancin.Domain.Entities.Classes
{
    [Table("classes_class_student")]
    public class ClassStudent
    {
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        public Class Class { get; set; }

        [ForeignKey("ClassStudentStatus")]
        public int StudentStatusId { get; set; }
        public ClassStudentStatus ClassStudentStatus { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}
