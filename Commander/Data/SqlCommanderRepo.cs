using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var data = _context.Commands.ToList();

            return data;
        }

        public Command GetCommandById(int id)
        {
            var data = _context.Commands.FirstOrDefault(p => p.Id == id);

            return data;
        }
    }
}
