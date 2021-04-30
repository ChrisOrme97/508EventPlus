using _508EventPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Data
{
    public class DbInitilizer
    {
        public static void Initialize(EventsPlusContext context)
        {
            // GET: Recieves and Stores Customer Information

            context.Database.EnsureCreated();
            if (context.Customers.Any())
            {
                return; 
            }
            var customers = new Customer[]
            {
                new Customer{ID=1,FirstName="Lily",LastName="Anderson",PhoneNumber="07564589067",EmailAddress="lilyanderson97@gmail.com",Address="12 Strauss Avenue, Coventry, CV12 6AS",DateOfBirth=DateTime.Parse("1997-09-05")},
                new Customer{ID=2,FirstName="Mick",LastName="Manners",PhoneNumber="07689545895",EmailAddress="MickManners98@gmail.com",Address="14 Little Lane, Coventry, CV9 6UI",DateOfBirth=DateTime.Parse("1998-10-08")},
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            // GET: Recieves and Stores Organiser Information 

            var organisers = new Organiser[]
            {
                new Organiser{ID=1,FirstName="Clive",LastName="Clinton",PhoneNumber="07697806532",EmailAddress="cliveclinton@gmail.com"},
                new Organiser{ID=2,FirstName="Adam",LastName="Johnson",PhoneNumber="07545643453",EmailAddress="adamjohnson@gmail.com"}

            };
            foreach (Organiser o in organisers)
            {
                context.Organisers.Add(o);
            }
            context.SaveChanges();
            
            // GET: Recieves and Stores Event Information.

            var events = new Event[]
            {
                new Event{ID=2001,OrganisersID=1,CustomersID=1,Venue="TheTranquilArena",Date=DateTime.Parse("2021-03-05"),EventType="BirthdayParty",NumOfAttendees=200,SpecialRequirements="None",Price="£2000"},
                new Event{ID=2002,OrganisersID=2,CustomersID=2,Venue="TheSwanLake",Date=DateTime.Parse("2021-04-12"),EventType="Wedding",NumOfAttendees=260,SpecialRequirements="None",Price="£3000"}
            };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();
        }
        
    }
}
