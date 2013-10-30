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
    [Table("Rent")]
    public class Rent : IAuditable
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentID { get; set; }

        [ForeignKey("Borrower")]
        public int BorrowerID { get; set; }
        public Borrower Borrower { get; set; }

        [ForeignKey("Car")]
        public int CarID { get; set; }
        public Car Car { get; set; }

        public CarRentalType Type { get; set; }

        public ReservationStatus Status { get; set; }

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
