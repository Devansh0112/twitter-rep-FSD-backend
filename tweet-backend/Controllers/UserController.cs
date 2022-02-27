using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tweet_backend.Models;
using tweet_backend.Services;

namespace tweet_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;
        public UserController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }
        [HttpGet]
        public async Task<List<Users>> Get() {
            return await _mongoDBService.GetAsync();
        }

        [HttpPost("SignIn")]
        public async Task<bool> SignInUser([FromBody] UserCred userCred)
        {
            return await _mongoDBService.SignInUserAsync(userCred);
        }
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Users user) { }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> AddToPlaylist(string id, [FromBody] string movieId) { }
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(string id) { }
    }
}
