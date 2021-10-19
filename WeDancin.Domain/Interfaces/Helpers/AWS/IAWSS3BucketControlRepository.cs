using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Interfaces.Helpers.AWS
{
    public interface IAWSS3BucketControlRepository
    {
        Task<string> UploadAsync(IFormFile fileUpload);
        MemoryStream DownloadAsync(string blobName);
    }
}
