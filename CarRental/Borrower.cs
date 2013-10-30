using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Billy.Framework;
using Billy.Framework.Model;

namespace CarRental.EFDBModel
{
    [Table("Borrower")]
    public class Borrower : IAuditable
    {
        [Key, DatabaseGenerated ( DatabaseGeneratedOption.Identity)]
        public int BorrowerID { get; set; }

        public string Name { get; set; }
        public string PermanentAddress { get; set; }
        public string HotelAddress { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string EmailAddress { get; set; }

        [ForeignKey("Referral")]
        public int? ReferralID { get; set; }
        public Referral Referral { get; set; }
       
        public ICollection<Rent> RentList { get; set; }

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
