using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MembersController(AppDbContext context) : ControllerBase
  {
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
    {
      var members = await context.Users.ToListAsync();
      return members;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetMember(string id)
    {
      var member = await context.Users.FindAsync(id);
      if (member == null)
      {
        return NotFound();
      }
      return member;
    }
  }
}