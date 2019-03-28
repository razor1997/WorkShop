using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                ID=1,
                Name= "MVP summit",
                StartDate = new DateTime(2018,3,5),
                EndDate = new DateTime(2018,3,8)
            },
             new Trip
            {
                ID=2,
                Name= "DevIntersection 2018",
                StartDate = new DateTime(2018,3,25),
                EndDate = new DateTime(2018,3,28)
            },
            new Trip
            {
                ID=3,
                Name= "Build 2018",
                StartDate = new DateTime(2018,5,7),
                EndDate = new DateTime(2018,5,9)
            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }
        public Trip Get(int id)
        {
            return MyTrips.First(t => t.ID == id);
        }
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.ID == tripToUpdate.ID));
        }
        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.ID == id));
        }
    }
}
