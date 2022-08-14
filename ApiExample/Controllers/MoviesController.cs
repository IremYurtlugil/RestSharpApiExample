using ApiExample.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly RestClient _client;

        public MoviesController()
        {
            _client = new RestClient("https://movies-app1.p.rapidapi.com/api/movies");
        }
        public async Task<IActionResult> GetMovies()
        {


            var request = new RestRequest("api/movies");
            request.AddHeader("X-RapidAPI-Key", "469e4bc1dbmsh3377ea83441649fp17a853jsn1f0cc4a6cc78");
            request.AddHeader("X-RapidAPI-Host", "movies-app1.p.rapidapi.com");
            var responce = await _client.ExecuteGetAsync(request);
            if (!responce.IsSuccessful)
            {
                return BadRequest();
            }

            var result = JsonSerializer.Deserialize<MoviesApiResult>(responce.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            //Db kayıt edilecek.
            return Ok(result);

        }





    }
}

