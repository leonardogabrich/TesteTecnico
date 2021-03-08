using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.API.Models;
using System.Net.Http;
using Nancy.Json;
using System.Net.Http.Json;

namespace WebAppNetCore.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<Pessoa> pessoas = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Cadastro/");
                //HTTP GET
                var responseTask = client.GetAsync("ObtemTodasPessoas");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    pessoas = JSserializer.Deserialize<List<Pessoa>>(readTask.Result);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    pessoas = Enumerable.Empty<Pessoa>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(pessoas);
        }
        public ActionResult create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult create(Pessoa pessoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Cadastro/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Pessoa>("CadastrarPessoa", pessoa);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(pessoa);
        }

        public ActionResult Edit(int id)
        {
            Pessoa pessoa = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Cadastro/");
                //HTTP GET
                var responseTask = client.GetAsync("BuscarPessoa?Id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    pessoa = JSserializer.Deserialize<Pessoa>(readTask.Result);
                }
            }

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Cadastro/");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<Pessoa>("AtualizaCadastro", pessoa);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(pessoa);
        }
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/Cadastro/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("DeletarPessoa?Id=" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
