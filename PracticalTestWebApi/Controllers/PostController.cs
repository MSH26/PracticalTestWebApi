using Newtonsoft.Json;
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
    [RoutePrefix("api/posts")]
    public class PostController : ApiController
    {
        readonly PostRepository postRepository = new PostRepository();

        [HttpGet]
        [Route("{postId}")]
        public IHttpActionResult GetPost(long postId)
        {
            return Ok(PostDto.CreatePostDto(postRepository.GetPost(postId)));
        }

        [HttpGet]
        [Route("{numberOfPageItems}/{pageNumber}/{maximumPages}")]
        public IHttpActionResult GetAllPosts(int numberOfPageItems, int pageNumber)
        {
            List<PostDto> posts = postRepository.GetAllPosts().Select(c => PostDto.CreatePostDto(c)).ToList();

            int count = posts.Count();
            int CurrentPage = pageNumber > 0 ? pageNumber : 1;
            int PageSize = numberOfPageItems > 0 ? numberOfPageItems : 10; 
            int TotalCount = count;
            int TotalPages = (int)Math.Ceiling(count / (double)PageSize); 
            var paginatedPosts = posts.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList(); 
            var previousPage = CurrentPage > 1 ? "Yes" : "No"; 
            var nextPage = CurrentPage < TotalPages ? "Yes" : "No";

            // Object which we are going to send in header   
            var paginationMetadata = new
            {
                totalCount = TotalCount,
                pageSize = PageSize,
                currentPage = CurrentPage,
                totalPages = TotalPages,
                previousPage,
                nextPage
            };

            System.Web.HttpContext.Current.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(paginationMetadata));
            return Ok(paginatedPosts);
        }

        [HttpGet]
        [Route("getPostsByUser/{userId}")]
        public IHttpActionResult GetPostsByUser(long userId)
        {
            return Ok(postRepository.GetPostsByUser(userId).Select(c => PostDto.CreatePostDto(c)).ToList());
        }

        [HttpGet]
        [Route("search/{searchQuery}")]
        public IHttpActionResult SearchPost(String searchQuery)
        {
            return Ok(postRepository.SearchPosts(searchQuery).Select(c => PostDto.CreatePostDto(c)).ToList());
        }
    }
}
