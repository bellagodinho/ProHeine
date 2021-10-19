using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Validation
{
    public class DomainExpectionValidation : Exception
    {
        public DomainExpectionValidation(string error) : base(error)
        {

        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExpectionValidation(error);
        }
    }
}
