using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        // [AllowAnonymous] //esta etiqueta funciona de manera similar a la de Authorize
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers()
        {
            var users = await _userRepository.GetMemberAsync();

            return Ok(users);
        }

        /* 
            Solo si nos pasa un token de autentificacion JWT, 
            este se puede aplicar a nivel de clase, asi como propiedad aca.
            a nivel de controlador seria el superior
        */
        //[Authorize] 
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDTO>> GetUser(string username)
        {
            return await _userRepository.GetMemberAsync(username);

            //return _mapper.Map<MemberDTO>(user);
        }
    }
}