using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
   public class Table
    {
       //By conventuon, if we a a property with the as the class, but 
       // with a surfix of ID, then Entity Framework will recongize that proeperty
       // as mapping to the database table's primary key column.
       public int TableID { get; set; }
       public byte TableNumber { get; set;}
       public bool Smoking { get; set; }
       public int Capacity { get; set; }
       public bool Available { get; set; }

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
