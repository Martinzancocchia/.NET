using Library.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Library.Entidades;

using Territories.MVC.Api.Models;


namespace Territories.MVC.Api.Controllers
{
    public class TerritoryController : ApiController
    {
        TerritoriesLogic logic = new TerritoriesLogic();
        
        [HttpGet]
        [Route("api/territories")]
        public IHttpActionResult Get()
        {
            var territorios = logic.GetAll();
            List<TerritoriesResp> territories = territorios.Select(t => new TerritoriesResp
            {
                TerritoriesId = t.TerritoryID,
                TerritoriesName = t.TerritoryDescription,
                TerritoriesRegion = t.RegionID,

            }).ToList();
            return Ok(territories);
        }

        [HttpGet]
        [Route("api/territories")]// GET api/<controller>/5
        public IHttpActionResult Get(string id)
        {
            var territorio = logic.GetByID(id);

            return Ok(territorio);
        }

        // POST api/<controller>


        
        [HttpPost]
        [Route("api/territories")]
        public IHttpActionResult Add([FromBody]TerritoriesRequest territoriesReq)
        {
            try
            {   
                
                Library.Entidades.Territories territorio = new Library.Entidades.Territories { TerritoryID = territoriesReq.territoryID, TerritoryDescription = territoriesReq.territoryDescription, RegionID = territoriesReq.regionID };
                
                logic.Add(territorio);
                return Ok(territorio);
                
               
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }

        [HttpPut]
        [Route("api/territories/{id}")]// PUT api/<controller>/5
        public IHttpActionResult Update(string id, [FromBody] TerritoriesRequest territoriesReq)
        {
            Library.Entidades.Territories territories = logic.GetByID(id);

            Library.Entidades.Territories territorio = new Library.Entidades.Territories { TerritoryID = territories.TerritoryID, TerritoryDescription = territoriesReq.territoryDescription, RegionID = territoriesReq.regionID };

            logic.Update(territorio);

            return Ok(territorio);
        }

        [HttpDelete]
        [Route("api/territories/{id}")]// DELETE api/<controller>/5
        public IHttpActionResult Delete(string id)
        {
            Library.Entidades.Territories territories = logic.GetByID(id);
            
            
            logic.Delete(id);

           return Ok(territories);
           
        }
    }
}