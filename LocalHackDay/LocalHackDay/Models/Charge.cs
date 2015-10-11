using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalHackDay.Models
{
    [Table("Charges")]
    public class Charge
    {
        public int ChargeID { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public int BillID { get; set; }


        public virtual Bill Bill { get; set; }
    }
}