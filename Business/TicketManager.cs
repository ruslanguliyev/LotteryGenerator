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

        public List<Ticket> GetAllTicketNumber(string TicketNumber)
        {
            return _context.Tickets.Where(ticket => ticket.Number == TicketNumber).ToList();
        }
        
        
        public void DeleteTicket(int Id)
        {
          
            var ticket = _context.Tickets.FirstOrDefault(t => t.Id == Id);

            if (ticket != null)
            {
                
                ticket.IsDeleted = true;
                _context.Tickets.Remove(ticket);              
                _context.SaveChanges();
            }
            else
            {
                
                throw new Exception($"Билет с идентификатором {Id} не найден.");
            }
        }

        //public Ticket GetTicketId(int id)
        //{
        //    return _context.Tickets.FirstOrDefault(x => x.Id == id);
            
        //}
    }
}
