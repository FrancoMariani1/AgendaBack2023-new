using AgendaBack2023.Data;
using AgendaBack2023.Data.Repository.Interfaces;
using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaBack2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUserRepository _userRepository;
        //private readonly IMapper _mapper;

        public ContactController(IContactRepository contactRepository, IUserRepository userRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _userRepository = userRepository;
            //_mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            int userId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value);
            return Ok(_contactRepository.GetAllByUser(userId));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            // si se quisiese mayor seguridad, se podria comprobar que el usuario que hace la peticion es el mismo que el que tiene el contacto
            int userId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value);
            return Ok(_contactRepository.GetContactById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateAndUpdateContactDTO dto)
        {
            int userId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value);
            Contact c = _contactRepository.Create(dto, userId);
            return Created("Created", c);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] CreateAndUpdateContactDTO dto) //modificar el update como el post (interface y repo tmb)
        {
            // si se quisiese mayor seguridad, se podria comprobar que el usuario que hace la peticion es el mismo que el que tiene el contacto
            int userId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value);
            _contactRepository.Update(dto);
            return NoContent();
        }


    

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int userId = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value);
            _contactRepository.Delete(id);
            return Ok();
           

        }

    }
    }

//{
//[Route("api/[controller]")]
//[ApiController]
//public class ContactController : ControllerBase
//{
//    private readonly AgendaBackContext _context;
//    private readonly IMapper _mapper;

//    public ContactController(AgendaBackContext context, IMapper mapper)
//    {
//        _context = context;
//        _mapper = mapper;
//    }

//    [HttpGet]

//    public async Task<IActionResult> Get()
//    {
//        try
//        {
//            var contacts = await _context.Contacts.ToListAsync();

//            var contactsDTO = _mapper.Map<IEnumerable<ContactDTO>>(contacts);

//            return Ok(contacts);
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpGet("{id}")]
//    public async Task<IActionResult> Get(int id)
//    {
//        try
//        {
//            var contact = await _context.Contacts.FindAsync(id);
//            if (contact == null)
//            {
//                return NotFound();
//            }

//            var contactDTO = _mapper.Map<ContactDTO>(contact);
//            return Ok(contactDTO);
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpPost]

//    public async Task<IActionResult> Post(CreateAndUpdateContactDTO contactDTO)
//    {
//        try
//        {
//            var contact = _mapper.Map<Contact>(contactDTO);

//            _context.Add(contact);
//            await _context.SaveChangesAsync();

//            var contactItemDTO = _mapper.Map<ContactDTO>(contact);

//            return Ok(contactItemDTO);
//        }
//        catch (Exception ex)
//        {
//            if (ex.InnerException != null)
//            {

//                string innerExceptionMessage = ex.InnerException.Message;
//                string innerExceptionStackTrace = ex.InnerException.StackTrace;
//            }
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpPut]
//    public async Task<IActionResult> Put(CreateAndUpdateContactDTO contactDTO)
//    {
//        try
//        {
//            var contact = await _context.Contacts.FindAsync(contactDTO.id);
//            if (contact == null)
//            {
//                return NotFound();
//            }

//            _mapper.Map(contactDTO, contact);
//            await _context.SaveChangesAsync();

//            var updatedContactDTO = _mapper.Map<ContactDTO>(contact);
//            return Ok(updatedContactDTO);
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }

//    [HttpDelete]
//    public async Task<IActionResult> Delete(int id)
//    {
//        try
//        {
//            var contact = await _context.Contacts.FindAsync(id);
//            if (contact == null)
//            {
//                return NotFound();
//            }

//            _context.Contacts.Remove(contact);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }
//        catch (Exception ex)
//        {
//            return BadRequest(ex.Message);
//        }
//    }


//}
//}
