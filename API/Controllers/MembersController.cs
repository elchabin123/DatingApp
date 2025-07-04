using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API.Models;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MembersController(AppDbContext context) : ControllerBase
  {
    [HttpGet]
    public ActionResult<IReadOnlyList<AppUser>> GetMembers()
    {
      var members = context.Users.ToList();
      return members;
    }

    [HttpGet("{id}")]
    public ActionResult<AppUser> GetMember(string id)
    {
      var member = context.Users.Find(id);
      if (member == null)
      {
        return NotFound();
      }
      return member;
    }
  }
}