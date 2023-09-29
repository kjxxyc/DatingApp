using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        // [Key]
        public int Id { get; set; }
        
        //[Required] no se hizo de esta manera, LA VALIDACION NO IRA EN LA BD, SINO EN EL DTO
        public string UserName { get; set; } //= string.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime LastActive { get; set; } = DateTime.UtcNow;

        public string Gender { get; set; }

        public string Introduction { get; set; }

        public string Interests { get; set; }

        public string LookingFor { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public List<Photo> Photos { get; set; } = new();

        // public int GetAge() {

        //     return DateOfBirth.CalcuateAge();
        // }
    }
}