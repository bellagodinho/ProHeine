using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Accounts
{
    public class UserLoginViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
    }
}
