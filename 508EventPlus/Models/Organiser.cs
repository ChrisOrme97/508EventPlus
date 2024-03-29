﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Models
{
    public class Organiser
    {
        // Specifies the data values to retrieve and display for Organiser information
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<Event> Events { get; set; }

    }
}
