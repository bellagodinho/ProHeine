using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Accounts
{
    [Table("accounts_user_details")]
    public class UserDetails
    {
     
        [Key]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string ArtisticName { get; set; }
        public string Instagram { get; set; }
        public string TikTok { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AboutMe { get; set; }
        public string DanceModalities { get; set; }
        public string DanceCareer { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}
