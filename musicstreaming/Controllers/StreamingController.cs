
using Microsoft.AspNetCore.Mvc;
using musicstreaming.Models;
using musicstreaming.Services;
using System;
using System.Collections.Generic;

namespace musicstreaming.Controllers
{
    [ApiController]
  [Route("[controller]")]
    public class StreamingController: ControllerBase
    {
        readonly DataService _fixedData;
        public StreamingController(DataService dService)
        {
            _fixedData =dService;
        }

        [HttpGet]

        public IEnumerable<TrackInfo> Get(){
            return _fixedData.GetListTracks();
        }

        [HttpGet("artist")]

        public string GetArtistName(){
            return "Jateen";
        }

        [HttpGet("first")]

        public TrackInfo GetFirstItem(){
            return _fixedData.GetFirstItem();
        }
        //http:localhost:5000/streaming/random
        [HttpGet("random")]

        public TrackInfo GetRandomTrack(){
            return _fixedData.GetRandomTrack();
        }

       
    }
}