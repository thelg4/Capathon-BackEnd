using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capathon.Models;

public partial class Dependent
{
    [Key]
    public int DId { get; set; }

    [ForeignKey("User")]
    public int UId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? AuthorizedPickup { get; set; }

    public string? MedicalInfo { get; set; }

    public string? Accomodations { get; set; }

    public bool? SpecialNeeds { get; set; }
    
    public bool? DietaryRestrictions { get; set; }

    public bool? Allergies { get; set; }

    public virtual User User { get; set; } = null!; // THIS MATTERS ??
}
