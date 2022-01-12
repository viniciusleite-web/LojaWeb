using LojaWeb.Controllers.Base;
using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaWeb.Models.ModeloDados;

namespace LojaWeb.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IMapper _mapper;
        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            List<ClienteViewModel> lstCliente = new List<ClienteViewModel>() { new ClienteViewModel() {
            Nome = "Pablo" ,
            Endereço = "" ,
            Telefone = "123",
            CPF = ""} ,
            new ClienteViewModel()
            {
                Nome = "Carlos",
                Endereço = "",
                Telefone = "789",
                CPF = ""
            } };
            return View(lstCliente);
        }
        public IActionResult Create()
        {
            var cliente = new ClienteModel() { CPF = "1",Endereço = "a", Id = "1",Nome= "Carlos" , NumeroCartaoCredito = "1", Telefone = "1" };
            var clienteVM = _mapper.Map<ClienteViewModel>(cliente);
            return View(clienteVM);
        }
        [HttpPost]
        public IActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                List<ClienteViewModel> lstCliente = new List<ClienteViewModel>();
                lstCliente.Add(cliente);
                Mensagem("Cliente salvo com sucesso", "success");
                return View("Index", lstCliente);
            }
            return View(cliente);
        }
    }
}
