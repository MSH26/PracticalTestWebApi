using PracticalTestWebApi.Context;
using PracticalTestWebApi.Entity;
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
    [RoutePrefix("api/comments")]
    public class CommentController : ApiController
    {
        readonly CommentRepository commentRepository = new CommentRepository();
        readonly VoteRepository voteRepository = new VoteRepository();

        [HttpGet]
        [Route("{postId}")]
        public IHttpActionResult GetComments(long postId)
        {
            return Ok(commentRepository.GetComments(postId).Select(c => 
            {
                CommentDto commentDto = CommentDto.CreateCommentDto(c);
                commentDto.TotalLikeCount = voteRepository.GetTotalLikesCounts(commentDto.CommentId);
                commentDto.TotalDislikeCount = voteRepository.GetTotalDislikesCounts(commentDto.CommentId);
                return commentDto;
            }).ToList());
        }

        [HttpGet]
        [Route("commentById/{commentId}")]
        public IHttpActionResult GetComment(long commentId)
        {
            CommentDto commentDto = CommentDto.CreateCommentDto(commentRepository.GetComment(commentId));
            commentDto.TotalLikeCount = voteRepository.GetTotalLikesCounts(commentId);
            commentDto.TotalDislikeCount = voteRepository.GetTotalDislikesCounts(commentId);
            return Ok(commentDto);
        }
    }
}
