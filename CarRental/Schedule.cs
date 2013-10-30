using Billy.Framework;
using Billy.Framework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EFDBModel
{
    [Table("Schedule")]
    public class Schedule : IAuditable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleID { get; set; }

        [ForeignKey("Rent")]
        public int RentID { get; set; }
        public Rent Rent { get; set; }

        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        
        public string PickUpLocation { get; set; }
        public string PickUpFlightNumber { get; set; }

        public string DropOffLocation { get; set; }
        public string DropOffFlightNumber { get; set; }

        public User CreatedBy
        {
            get;
            set;
        }

        public int CreatedByID
        {
            get;
            set;
        }

        public DateTime CreatedOn
        {
            get;
            set;
        }

        public string IdentityGUID
        {
            get;
            set;
        }

        public User ModifiedBy
        {
            get;
            set;
        }

        public int? ModifiedByID
        {
            get;
            set;
        }

        public DateTime? ModifiedOn
        {
            get;
            set;
        }

        public string VersionGUID
        {
            get;
            set;
        }
    }
}
