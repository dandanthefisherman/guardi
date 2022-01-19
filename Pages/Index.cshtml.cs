using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc.RazorPages;
using guardi.Data;
using System.Linq;

namespace guardi.Pages
{
    public class IndexModel : PageModel
    {
        

         public IndexModel()
        {
            //_daprClient = daprClient ?? throw new ArgumentNullException(nameof(daprClient));
        }

        public async Task OnGet()
        {
            //var forecasts = await _daprClient.InvokeMethodAsync<IEnumerable<Article>>(
              //  HttpMethod.Get,
                //"daprbackend",
                //"article");

             //List<Article> ArticleList = InMemoryDatabase.ListOfArticles();

            ViewData["articledata"] = InMemoryDatabase.ListOfArticles();

            List<Article> covidlist = InMemoryDatabase.ListOfArticles();

            ViewData["covidarticles"] = covidlist.Where(lo => lo.ArticleType == "Covid").ToList();

            
            
        }
    }
}