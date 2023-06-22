using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum Status
{
    Pendente = 0,
    Finalizado = 1
}

namespace Todo.Models
{
    public class UserTask
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public Status Status { get; set; }
	}
}