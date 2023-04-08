using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser(AppUser user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}