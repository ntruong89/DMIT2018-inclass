using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
   public class ReservationbySpecialEventController
    {
        
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListSpecialEvents()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int SpecialEventId)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.Find(SpecialEventId);
            }
        }

        
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> LookupReservationsBySpecialEvent(string eventCode)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var data = from info in context.Reservations
                           where info.EventCode == eventCode
                           select info;
                return data.ToList();
            }
        }
       
        
    }
}
