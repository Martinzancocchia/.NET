using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.RickMortyApi
{
    public class RyM
    {
        public async Task<string> GetCharacters()
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");
            
        }
    }
}


    
    