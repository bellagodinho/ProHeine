using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Helpers
{
    [Table("helpers_bank_account_type")]
    public class BankAccountType
    {
        public int Id { get; set; }
        public string AccountTypeName { get; set; }
    }
}
