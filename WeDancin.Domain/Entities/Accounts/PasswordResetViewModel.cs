using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Accounts
{
    public class PasswordResetViewModel
    {
        public Guid Id { get; set; }
        public string PasswordHash { get; set; }
    }
}
