using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalApp_Data.BaseModels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }


    }
}
