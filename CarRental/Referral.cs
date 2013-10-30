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
    [Table("Referral")]
    public class Referral : IAuditable
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferralID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public ICollection<Borrower> BorrowerList { get; set; }

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
