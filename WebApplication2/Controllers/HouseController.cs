using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication2.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;          

namespace WebApplication2.Controllers
{
    public class HouseController : Controller
    {
        const string baseAddress = "http://partnerapi.funda.nl";
        const string requestUrl = "/feeds/Aanbod.svc/json/detail/ac1b0b1572524640a0ecc54de453ea9f/koop/6289a7bb-a1a8-40d5-bed1-bff3a5f62ee6";
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            //var HouseDetails = new HttpResponseMessage() ;
            HouseViewModel house = new HouseViewModel();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(requestUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                house = response.Content.ReadAsAsync<HouseViewModel>().Result;
            }
            else //web api sent error response 
            {
                //log response status here..
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }

            return View(house);
        }

        [HttpGet]
        public JsonResult GetMediaItems()
        {
            var avgWPBA = decimal.Parse("0");
            var numWPBA = 0;

            var res = new result() { numWPBAPerCAPA = numWPBA, avgWPBAPerCAPA = avgWPBA };

            return new JsonResult { Data = res, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}