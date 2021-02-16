using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Areas.Identity.Data
{
    public class EventsPlusUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="varchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
    }
}
