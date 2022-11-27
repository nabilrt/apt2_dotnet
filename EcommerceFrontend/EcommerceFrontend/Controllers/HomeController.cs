using EcommerceFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace EcommerceFrontend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Fetch the JSON string from URL.
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://localhost:44347/api/products");
            var products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json);

            //Return the JSON string.
            return View(products);
        }

        public ActionResult Create()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://localhost:44347/api/categories");
            var categories = new JavaScriptSerializer().Deserialize<List<CategoryModel>>(json);
            ViewBag.categorias = categories;
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel p)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44347/");

            //HTTP POST
            var response = client.PostAsync("api/product/add", new StringContent(
     new JavaScriptSerializer().Serialize(p), Encoding.UTF8, "application/json")).Result;

            var result = response;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://localhost:44347/api/products/"+id);
            var product = new JavaScriptSerializer().Deserialize<ProductModel>(json);

            //Return the JSON string.
            return View(product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Delete(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44347/");

            //HTTP POST
            var response = client.GetAsync("api/product/delete/"+id).Result;

            var result = response;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://localhost:44347/api/products/" + id);
            var product = new JavaScriptSerializer().Deserialize<ProductModel>(json);

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44347/");

            //HTTP POST
            var response = client.PostAsync("api/product/edit", new StringContent(
     new JavaScriptSerializer().Serialize(product), Encoding.UTF8, "application/json")).Result;

            var result = response;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}