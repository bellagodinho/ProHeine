using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Helpers
{

    public class Email
    {
        public string EmailRemetente { get; set; }

        public string NomeRemetente { get; set; }

        public string EmailDestinatario { get; set; }

        public string NomeDestinatario { get; set; }

        public List<EmCopia> EmCopia { get; set; }

        public string Assunto { get; set; }

        public string Corpo { get; set; }
    }

    public class EmCopia
    {
        public string EmailDestinatario { get; set; }

        public string NomeDestinatario { get; set; }
    }

    //public class Email
    //{
    //    public string RecipientMail { get; set; }
    //    public string RecipientName { get; set; }
    //    public string RecipientMail { get; set; }
    //    public string RecipientName { get; set; }
    //    public List<InCopy> InCopy { get; set; }
    //    public string MessageSubject { get; set; }
    //    public string MessageBody { get; set; }
    //}

    //public class InCopy
    //{
    //    public string RecipientMail { get; set; }
    //    public string RecipientName { get; set; }
    //}
}
