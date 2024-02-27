using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TicketManager
    {
        AplicationDbContext _context = new();


        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public IQueryable<Ticket> GetAllTicket()
        {
            return _context.Tickets.AsQueryable();
        }
    }
}
