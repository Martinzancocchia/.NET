using Lab.MVC.Models;
using Library.Logic.RickMortyApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Lab.MVC.Controllers
{
    public class CharactersController : Controller
    {
        RyM rymlogic = new RyM();
        public async Task<ActionResult> Index()
        {
            var personajes = await rymlogic.GetCharacters();
            var response= JsonConvert.DeserializeObject<RymResponse>(personajes);
            return View(response.results);
        }
    }
}