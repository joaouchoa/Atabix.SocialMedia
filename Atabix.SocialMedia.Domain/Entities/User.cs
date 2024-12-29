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
        public string FullName { get; private set; }
        public string DisplayName { get; private set; }
        public string? Header { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string? Description { get; private set; }
        public string  Email { get; private set; }
        public EUserStatus Status { get; private set; }
        public LocationInfo? Location { get; private set; }
        public ContactInfo? Contact { get; private set; }

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
