using PracticalTestWebApi.Models;
using PracticalTestWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticalTestWebApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        readonly UserRepository userRepository = new UserRepository();

        [HttpGet]
        [Route("authenticate/{userName}")]
        public IHttpActionResult AutheticateUser(string userName)
        {
            return Ok(UserDto.CreateUserDto(userRepository.GetUserByUserName(userName)));
        }

        [HttpGet]
        [Route("{userId}")]
        public IHttpActionResult GetUser(long userId)
        {
            return Ok(UserDto.CreateUserDto(userRepository.GetUser(userId)));
        }
    }
}
