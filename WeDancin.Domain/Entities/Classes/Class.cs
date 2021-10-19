using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Accounts;

namespace WeDancin.Domain.Entities.Classes
{
    [Table("classes_class")]
    public class Class
    {
        public Guid Id { get; set; }
        
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string ClassName { get; set; }
        public DateTime Starts_at { get; set; }
        public DateTime Ends_at { get; set; }

        [ForeignKey("ClassLevel")]
        public int LevelId { get; set; }
        public ClassLevel ClassLevel { get; set; }

        [ForeignKey("ClassModality")]
        public int ModalityId { get; set; }
        public ClassModality ClassModality { get; set; }

        public decimal PerStudentPrice { get; set; }
        public bool FreeClass { get; set; }
        public int MaxStudents { get; set; }
        public string ClassShortDescription { get; set; }

        [ForeignKey("ClassType")]
        public int TypeId { get; set; }
        public ClassType ClassType { get; set; }

        [ForeignKey("ClassStatus")]
        public int StatusId { get; set; }
        public ClassStatus ClassStatus { get; set; }

        [ForeignKey("ClassAttendance")]
        public int AttendanceId { get; set; }
        public ClassAttendanceType ClassAttendance { get; set; }

        public string ClassImage { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}
