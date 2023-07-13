namespace Capathon.Dtos.Appointment
{
    public class AddAppointmentDto
    {
        public string? PickupTime { get; set; }

        public string? DropoffTime { get; set; }

        public string? Date { get; set; }

        public int? CId { get; set; }

        public int? DId { get; set; }

        public int? UId { get; set; }

        // public virtual CareCenter? CareCenter { get; set; }

        // public virtual Dependent? Dependent { get; set; }

        // public virtual User? User { get; set; }
    }
}