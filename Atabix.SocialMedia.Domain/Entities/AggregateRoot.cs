using Atabix.SocialMedia.Domain.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atabix.SocialMedia.Domain.Entities
{
    public abstract class AggregateRoot : BaseEntity
    {
        public List<IEvent> Events { get; set; }
        public AggregateRoot() 
        {
            Events = new List<IEvent>();
        }
    }
}
