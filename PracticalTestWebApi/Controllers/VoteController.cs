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
    [RoutePrefix("api/votes")]
    public class VoteController : ApiController
    {
        readonly VoteRepository voteRepository = new VoteRepository();

        [HttpPost]
        [Route("")]
        public IHttpActionResult SavePost(VoteInDto voteInDto)
        {
            return Ok(VoteOutDto.CreateVoteOutDto(voteRepository.SaveVote(VoteInDto.CreateVote(voteInDto))));
        }
    }
}
