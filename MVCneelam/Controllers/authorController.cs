using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCneelam.Models;
using Newtonsoft.Json;

public class AuthorController : Controller
{
    private readonly HttpClient _httpClient;

    public AuthorController()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5043/api/") // Replace with your API base URL
        };
    }

    public async Task<IActionResult> author()
    {
        List<Author> authors = new List<Author>();

        HttpResponseMessage response = await _httpClient.GetAsync("author/Getauthor");

        if (response.IsSuccessStatusCode)
        {
            string data = await response.Content.ReadAsStringAsync();
            ViewBag.authors = JsonConvert.DeserializeObject<List<Author>>(data);
        }
        else
        {
            // Handle error if the request is not successful
            // You might want to log the error or display an error message
        }

        return View();
    }

    //registration method
    public IActionResult Add()
    {
        
        return View();
    }
}
