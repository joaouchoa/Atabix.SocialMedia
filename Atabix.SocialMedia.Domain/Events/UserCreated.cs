using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atabix.SocialMedia.Domain.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; set; }
        private string DisplayName { get; set; }

        public UserCreated(string email, string displayName)
        {
            Email = email;
            DisplayName = displayName;
        }
    }
}
