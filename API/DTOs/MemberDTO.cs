using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDTO
    {
        // [Key]
        public int Id { get; set; }
        
        //[Required] no se hizo de esta manera, LA VALIDACION NO IRA EN LA BD, SINO EN EL DTO
        public string UserName { get; set; } //= string.Empty;

        public string PhotoUrl { get; set; }

        public int  Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; } 

        public DateTime LastActive { get; set; } 

        public string Gender { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public List<PhotoDto> Photos { get; set; }
    }
}