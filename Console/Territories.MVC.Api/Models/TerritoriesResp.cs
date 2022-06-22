using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Territories.MVC.Api.Models
{
    public class TerritoriesResp
    {
        public string TerritoriesId { get; set; }
        public string TerritoriesName { get; set; }
        public int TerritoriesRegion { get; set; }
    }
}