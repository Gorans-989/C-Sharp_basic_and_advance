using System;
using System.Collections.Generic;
using System.Text;
using VideoRentalApp_Data.BaseModels;

namespace VideoRentalApp_Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        // card number is used as userName
        public int CardNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }

    }
}
