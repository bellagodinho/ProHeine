using Amazon.SQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Interfaces.Helpers.AWS
{
    public interface IAWSSQSQueueControlRepository
    {
        Task<HttpStatusCode> SendMessageAsync(string messageBody);
    }
}
