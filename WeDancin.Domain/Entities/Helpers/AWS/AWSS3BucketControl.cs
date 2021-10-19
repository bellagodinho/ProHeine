using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Helpers.AWS
{
    public class AWSS3BucketControl
    {
        public string StorageAccount { get; set; }
        public string StorageKey { get; set; }
        public string BucketName { get; set; }

        public AWSS3BucketControl(string storageAccount, string storageKey, string bucketName)
        {
            if (String.IsNullOrEmpty(storageAccount))
                throw new ArgumentNullException("StorageAccount");

            if (String.IsNullOrEmpty(storageAccount))
                throw new ArgumentNullException("StorageKey");

            if (String.IsNullOrEmpty(storageAccount))
                throw new ArgumentNullException("BucketName");

            this.StorageAccount = storageAccount;
            this.StorageKey = storageKey;
            this.BucketName = bucketName;
        }
    }
}