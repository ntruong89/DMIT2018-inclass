using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
     public class RestaurantAdminController
     {
         #region Manage Waiters
         #region Command
         public int AddWaiter ( Waiter item )
         {
                using (RestaurantContext context = new RestaurantContext())
                {
                    //To Do: Validation of waiter data...
                    var added = context.Waiters.Add(item); // context.Waiters.Add(is a list) this code does an insert to add a waiter in. the Database generate ID 
                    context.SaveChanges();
                    return added.WaiterID;
                }

         }
            
         public void UpdateWaiter(Waiter item)
         {
             using (RestaurantContext context = new RestaurantContext())
             {
                 //TODO: Validation
                 var attached = context.Waiters.Attach(item);
                 var matchingWithExistingValues = context.Entry<Waiter>(attached); // context.Entry<Waiter>(attached) this part of the code looks up information about an pbject in the database.
                 matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                 context.SaveChanges();
             }

         }
         public void DeleteWaiter(Waiter item)
         {
             using (RestaurantContext context = new RestaurantContext())
             {
                 //TODO: Validation
                 var existing = context.Waiters.Find(item.WaiterID);
                 context.Waiters.Remove(existing);
                 context.SaveChanges();
             }
         }
        
         #endregion
         #region Query
         public List<Waiter> ListAllWaiters()
         {
             using (RestaurantContext context = new RestaurantContext())
             {
                 return context.Waiters.ToList();
             }
         }

         public Waiter GetWaiter(int waiterId)
         {
             using (RestaurantContext context = new RestaurantContext())
             {
                 return context.Waiters.Find(waiterId);
             }
         }
         #endregion
         #endregion

         #region Manage Tables
         #region Command
         #endregion
         #region Query
         #endregion
         #endregion

         #region Manage Items
         #region Command
         #endregion
         #region Query
         #endregion
         #endregion

         #region Manage Special Events
         #region Command
         #endregion
         #region Query
         #endregion
         #endregion

     }
}
