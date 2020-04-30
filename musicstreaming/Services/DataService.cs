using System;
using System.Collections.Generic;
using musicstreaming.Models;

namespace musicstreaming.Services
{
    public class DataService
    {
        //artistName,trackName, albumName, trackUrl

        public List<TrackInfo> fixedData = new List<TrackInfo>
        {
            new TrackInfo("AE, Prozax","Clamato Fever","Street Fighter 2","http://www.jateam"),
            new TrackInfo("1AE, 2Prozax","2Clamato Fever","2Street Fighter 2","http://www.jateam1"),
        };

        public IEnumerable<TrackInfo>GetTracks(){
            return fixedData;
        }

        public List<TrackInfo> GetListTracks(){
            return fixedData;
        }

        public TrackInfo GetFirstItem(){
            return fixedData[0];
        }

        public TrackInfo  GetRandomTrack(){

            var rng = new Random();
            return fixedData[rng.Next(fixedData.Count)];


        }

        //This is where we do our add and delete functions

    }
}