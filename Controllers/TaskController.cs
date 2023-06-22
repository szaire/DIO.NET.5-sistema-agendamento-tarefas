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

		// =========================PÁGINA INICIAL==========================
		
        public IActionResult Index()
        {
			var contatos = _context.Tasks.ToList<UserTask>();
			return View(contatos);
		}

		// ===========================CRIAR TASK============================
		
		public IActionResult Criar()
		{
			return View();
		}

		// Request para criar nova tarefa
		[HttpPost]
		public IActionResult Criar(UserTask task)
		{
			if(ModelState.IsValid)
			{
				_context.Tasks.Add(task);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}

			return View("Criar");
		}

		// ========================EDITAR TASK==============================

		public IActionResult Editar(int id)
		{
			var task_db = _context.Tasks.Find(id);

			if (task_db == null)
			{
				return NotFound();
			}
			
			return View(task_db);
		}

		[HttpPost]
		public IActionResult Editar(UserTask task)
		{
			var task_db = _context.Tasks.Find(task.Id);

			if (task_db == null)
			{
				NotFound();
			}

			task_db.Titulo = task.Titulo;
			task_db.Descricao = task.Descricao;
			task_db.Data = task.Data;
			task_db.Status = task.Status;

			_context.Tasks.Update(task_db);
			_context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		// ========================DETALHES TASK============================

		public IActionResult Detalhes(int id)
		{
			var task_db = _context.Tasks.Find(id);

			if (task_db == null)
			{
				return NotFound();
			}

			return View(task_db);
		}

		// ========================DELETAR TASK=============================

		public IActionResult Deletar(int id)
		{
			var task_db = _context.Tasks.Find(id);

			if (task_db == null)
			{
				return NotFound();
			}

			return View(task_db);
		}

		[HttpPost]
		public IActionResult Deletar(UserTask task)
		{
			var task_db = _context.Tasks.Find(task.Id);
			
			if (task_db == null)
			{
				return NotFound();
			}

			_context.Tasks.Remove(task_db);
			_context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}
	}
}