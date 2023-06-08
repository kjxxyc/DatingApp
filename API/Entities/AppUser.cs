using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

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
    }
}