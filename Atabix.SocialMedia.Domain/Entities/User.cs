using Atabix.SocialMedia.Domain.Enums;
using Atabix.SocialMedia.Domain.Events;
using Atabix.SocialMedia.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atabix.SocialMedia.Domain.Entities
{
    public class User : AggregateRoot
    {
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string? Header { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Description { get; set; }
        public string  Email { get; set; }
        public EUserStatus Status { get; set; }
        public LocationInfo? Location { get; set; }
        public ContactInfo? Contact { get; set; }

        public User(string fullName, string displayName, DateTime birthDate, string email) : base()
        {
            FullName = fullName;
            DisplayName = displayName;
            BirthDate = birthDate;
            Email = email;

            Status = EUserStatus.Active;
            Events.Add(new UserCreated(email, displayName));
        }

        public void Update(string displayName, string header, string description, LocationInfo location, ContactInfo contact) 
        { 
            DisplayName = displayName;
            Header = header;
            Description = description;
            Location = location;
            Contact = contact;
        }
    }
}
