using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Classes
{
    [Table("classes_class_type")]
    public class ClassType
    {
        public int Id { get; set; }
        public string ClassTypeName { get; set; }
    }
}
