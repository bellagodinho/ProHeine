using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDancin.Domain.Entities.Helpers;

namespace WeDancin.Domain.Entities.Accounts
{
    [Table("accounts_user_bankaccount")]
    public class UserBankAccount
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("AccountType")]
        public int AccounTypeId { get; set; }
        public BankAccountType AccountType { get; set; }

        [ForeignKey("Bank")]
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        
        public string Branch { get; set; }
        public string Account { get; set; }
        public bool Primary { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        
        public bool Disabled { get; set; }

    }
}
