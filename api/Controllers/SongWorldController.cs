using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class SongWorldController : ControllerBase
    {
        private SongWorld mySongWorld = new SongWorld();
        

        private readonly ILogger<SongWorldController> _logger;

        public SongWorldController(ILogger<SongWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1>Hello World!</h1>";
        }

        [HttpGet]
        [Route("[controller]/SongWorld")]
        public String GetSongWorld()
        {
            return mySongWorld.Songworld;
        }
    }
}