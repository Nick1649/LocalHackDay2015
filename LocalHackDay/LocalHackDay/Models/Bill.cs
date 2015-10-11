using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalHackDay.Models
{
    [Table("Bill")]
    public class Bill
    {
        public Bill()
        {
            this.Charges = new HashSet<Charge>();
        }

        public int BillID { get; set; }

        public virtual ICollection<Charge> Charges { get; set; }
    }
}