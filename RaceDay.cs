using System.ComponentModel.DataAnnotations;

namespace RaceDay_MVC.Models
{
    public class Participants
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public double Weight { get; set; }
        [Required]
        [Range(1, 300)]
        public double Height { get; set; }
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        [Required]
        [Range(1, 90)]
        public string Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Passwordhash { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string Role { get; set; } = "Participant";
    }

    public class DtoParticipantsLogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string PhnoneNumber { get; set; }
    }

    public class DtoParticipantsResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Passwordhash { get; set; }
        public string PhnoneNumber { get; set; }
    }

    public class ParticipantsLoginRequest
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Passwordhash { get; set; }
    }
    public class ParticipantsLoginResponse
    {
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Passwordhash { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string ParticipantsId { get; set; }
    }

    public class ParticipantsUpdateRequest
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public double Weight { get; set; }
        [Required]
        [Range(1, 300)]
        public double Height { get; set; }
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        [Required]
        [Range(1, 90)]
        public string Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Passwordhash { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string ParticipantsId { get; set; }
    }

    public class ParticipantsUpdateResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ParticipantsId { get; set; }
        public string Message { get; set; }
    }

    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Label { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(150)]
        public string Passwordhash { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string Role { get; set; } = "Organizer";
    }

    public class OrganizerLoginRequest
    {
        [Required]
        [StringLength(100)]
        public string Label { get; set; }
        [Required]
        [StringLength(150)]
        public string Passwordhash { get; set; }
    }

    public class OrganizerLoginResponse
    {
        public string Label { get; set; }
        [Required]
        [StringLength(150)]
        public string Passwordhash { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string OrganizerId { get; set; }
        public string Message { get; set; }
    }

    public class OrganizerUpdateRequest
    {
        [Required]
        [StringLength(100)]
        public string Label { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(150)]
        public string Passwordhash { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string OrganizerId { get; set; }
    }

    public class OrganizerUpdateResponse
    {
        public string Label { get; set; }
        public string Email { get; set; }
        public string OrganizerId { get; set; }
        public string Message { get; set; }
    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string NameLabel { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public int AgeRange { get; set; }
        [Required]
        [Range(1, 100)]
        public string Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        [Required]
        public int OrganizerId { get; set; }
        public int ParticipantsId { get; set; }
        public int ParticipantsCount { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
    public class EventResponse
    {
        public string NameLabel { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int AgeRange { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int OrganizerId { get; set; }
        public int ParticipantsId { get; set; }
        public int ParticipantsCount { get; set; }
        public int CategoryId { get; set; }
    }

    public class EventUpdateRequest
    {
        [Required]
        [StringLength(100)]
        public string NameLabel { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public int AgeRange { get; set; }
        [Required]
        [Range(1, 100)]
        public string Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        [Required]
        public int OrganizerId { get; set; }
        [Required]
        public int ParticipantsId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ParticipantsCount
        {
            get; set;
        }
        public class EventUpdateResponse
        {
            public string NameLabel { get; set; }
            public string Description { get; set; }
            public string PhoneNumber { get; set; }
            public int AgeRange { get; set; }
            public string Location { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; }
            public int OrganizerId { get; set; }
            public int ParticipantsId { get; set; }
            public int ParticipantsCount { get; set; }
            public int CategoryId { get; set; }
        }

        public class Result
        {
            public int Id { get; set; }
            [Required]

            public int EventId { get; set; }
            [Required]
            public int ParticipantId { get; set; }
            [Required]
            public TimeSpan Time { get; set; }
            [Required]
            public int Position { get; set; }
            [Required]
            [Range(1, 1000)]
            public double Distance { get; set; }
            [Required]
            [Range(1, 100)]
            public string CategoryId { get; set; }

        }
        public class ResultUpdateRequest
        {
            [Required]
            public int EventId { get; set; }
            [Required]
            public int ParticipantId { get; set; }
            [Required]
            public int OrganzierId { get; set; }
            [Required]
            public TimeSpan Time { get; set; }
            [Required]
            public int Position { get; set; }
            [Required]
            [Range(1, 1000)]
            public double Distance { get; set; }
            [Required]
            [Range(1, 100)]
            public string CategoryId { get; set; }
        }
        public class ResultssUpdateResponse
        {
            public string Message { get; set; }

        }

        public class ResultssResponse
        {
            public int EventId { get; set; }
            public int ParticipantId { get; set; }
            public int OrganzierId { get; set; }
            public TimeSpan Time { get; set; }
            public int Position { get; set; }
            public double Distance { get; set; }
            public string CategoryId { get; set; }
        }

        public class Registration
        {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public int EventId { get; set; }
            [Required]
            public int ParticipantId { get; set; }
        }
        public class RegistrationResponse
        {
            public string Message { get; set; }
        }
       
        public class RegistrationUpdateRequest
        {
            public string Name { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public int EventId { get; set; }
            [Required]
            public int ParticipantId { get; set; }
        }
        public class RegistrationUpdateResponse
        {
            public string Message { get; set; }
        }
    }
}