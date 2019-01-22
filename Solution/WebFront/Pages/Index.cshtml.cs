using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFront.Pages
{
    using System.Net.Http;

    public class IndexModel : PageModel
    {
        public async Task OnGet()
        {
            Console.WriteLine("Getting data");
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync("http://backend-svc/api/values");
                Console.WriteLine("Got " + result);
            }
        }
    }
}
