namespace Capathon.Dtos.CareCenter
{
    public class AddCareCenterDto
    {
        public string? CenterName {get;set;}
        
        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public bool? IsCorp { get; set; }

        public string? Type { get; set; }
    }
}