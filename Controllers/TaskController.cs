using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO.NET._5_sistema_agendamento_tarefas.Contexts;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace DIO.NET._5_sistema_agendamento_tarefas.Controllers
{
    public class TaskController : Controller
    {
		private readonly TodoContext _context;

        public TaskController(TodoContext context)
        {
			_context = context;
		}

        public IActionResult Index()
        {
			var contatos = _context.Tasks.ToList<UserTask>();
			return View(contatos);
		}

		public IActionResult Criar()
		{
			
		}
	}
}