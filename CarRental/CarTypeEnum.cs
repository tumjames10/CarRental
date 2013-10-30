using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EFDBModel
{
    public enum CarRentalType
    {
        SelfDrive,
        Chauffeur
    }

    public enum ReservationStatus
    {
        New,
        Reserved,
        Rejected,
        Cancelled
    }
}
