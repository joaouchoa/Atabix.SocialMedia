using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atabix.SocialMedia.Domain.Entities
{
    public abstract class BaseEntity
    {
        Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeletd { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid(); 
            CreatedAt = DateTime.Now;
            IsDeletd = false;
        }

        public void Delete() 
        { 
            IsDeletd = true;
        }
    }
}
