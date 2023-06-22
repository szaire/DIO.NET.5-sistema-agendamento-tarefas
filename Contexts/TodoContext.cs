using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;
using Microsoft.EntityFrameworkCore;

namespace DIO.NET._5_sistema_agendamento_tarefas.Contexts
{
    public class TodoContext : DbContext
    {
		public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<UserTask> Tasks { get; set; }
    }
}