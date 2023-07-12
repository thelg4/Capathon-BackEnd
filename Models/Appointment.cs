using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capathon.Models;

public partial class Appointment
{
    public int AId { get; set; }

    public DateTime? PickupTime { get; set; }

    public DateTime? DropoffTime { get; set; }

    [ForeignKey("CareCenter")]
    public int? CId { get; set; }

    [ForeignKey("Dependent")]
    public int? DId { get; set; }

    [ForeignKey("User")]
    public int? UId { get; set; }

    // public virtual CareCenter? CareCenter { get; set; }

    // public virtual Dependent? Dependent { get; set; }

    // public virtual User? User { get; set; }
}
