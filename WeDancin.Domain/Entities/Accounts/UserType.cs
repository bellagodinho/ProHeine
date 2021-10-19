using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Accounts
{
    [Table("accounts_user_type")]
    public class UserType
    {
        public int Id { get; set; }
        public string UserTypeName { get; set; }
    }
}
