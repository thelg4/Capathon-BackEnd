namespace Capathon.Dtos.User
{
    public class GetUserDto
    {
        public int UId { get; set; }

        public string? DIds { get; set; }

        public int? CId { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        // public virtual ICollection<Dependent> Dependents { get; set; } = null!;
    }
}