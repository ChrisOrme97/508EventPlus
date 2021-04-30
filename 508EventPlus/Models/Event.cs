using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Models
{
    public class Event
    {
        // Specifies the data values to retrieve and display for Event information
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int OrganisersID { get; set; }
        public int CustomersID { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public string  EventType { get; set; }
        public int NumOfAttendees { get; set; }
        public string SpecialRequirements { get; set; }
        public string Price { get; set; }

    }
}
