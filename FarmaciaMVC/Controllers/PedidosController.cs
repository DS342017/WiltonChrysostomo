using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaMVC.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            HttpResponseMessage response = VG.WebApiClient.GetAsync("Pedidos").Result;           
            return View(response.Content.ReadAsAsync<IEnumerable<Models.Pedido>>().Result);
        }

        public ActionResult AdicionarPedido(int id = 0)
        {
            return View(new Models.Pedido());
        }
       
        [HttpPost]
        public ActionResult AdicionarPedido(Models.Pedido pedido)
        {
            HttpResponseMessage response = VG.WebApiClient.PostAsJsonAsync("Pedido", pedido).Result;
            return RedirectToAction("Index");
        }
        public ActionResult EditarPedido(int id = 0)
        {
            HttpResponseMessage response = VG.WebApiClient.GetAsync("Pedido/" + id.ToString()).Result;
            return View(response.Content.ReadAsAsync<Models.Pedido>().Result);
        }
        [HttpPost]
        public ActionResult EditarPedido(Models.Pedido pedido)
        {
            HttpResponseMessage response = VG.WebApiClient.PutAsJsonAsync("Pedido/" + pedido.IdPedidos, pedido).Result;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = VG.WebApiClient.DeleteAsync("Pedido/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}