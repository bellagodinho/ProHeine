using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Helpers.AWS
{
    public class AWSSQSQueueControl
    {
        public string SQSAccount { get; set; }
        public string SQSKey { get; set; }
        public string QueueUrl { get; set; }
        public string MessageGroupId { get; set; }

        public AWSSQSQueueControl(string SQSAccount, string SQSKey, string QueueUrl, string MessageGroupId)
        {
            if (String.IsNullOrEmpty(SQSAccount))
                throw new ArgumentNullException("SQSAccount");

            if (String.IsNullOrEmpty(SQSKey))
                throw new ArgumentNullException("SQSKey");

            if (String.IsNullOrEmpty(QueueUrl))
                throw new ArgumentNullException("QueueUrl");

            if (String.IsNullOrEmpty(MessageGroupId))
                throw new ArgumentNullException("MessageGroupId");

            this.SQSAccount = SQSAccount;
            this.SQSKey = SQSKey;
            this.QueueUrl = QueueUrl;
            this.MessageGroupId = MessageGroupId;
        }
    }
}
