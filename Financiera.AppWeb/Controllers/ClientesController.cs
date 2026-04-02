using Financiera.AppWeb.Models;
using Financiera.AppWeb.Models.Extensions;
using Financiera.BusinessLogic;
using Financiera.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Financiera.AppWeb.Controllers
{
    public class ClientesController : Controller
    {
        private readonly PrestamoServices services;
        public ClientesController(PrestamoServices prestamoServices)
        {
            services = prestamoServices;
        }
        public IActionResult Index()
        {
            var clientes = services.ListarClientes().Select(x => x.toViewModel()).ToList();
            foreach(var item in clientes)
            {
                item.TipoCliente = services.ObtenerTipoClientePorID(item.TipoClienteID).Nombre;
            }
            return View(clientes);
        }

        public IActionResult Details(int id)
        {
            var cliente = services.ObtenerClientePorID(id).toViewModel();
            cliente.TipoCliente = services.ObtenerTipoClientePorID(cliente.TipoClienteID).Nombre;

            return View(cliente);
        }

        public ActionResult Edit(int id)
        {
            var cliente = services.ObtenerClientePorID(id).toViewModel();
            return View(cliente);
        }
    }
}
