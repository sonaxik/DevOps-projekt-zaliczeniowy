using System.Collections.Generic;

namespace DevOps_projekt_zaliczeniowy
{
    public class TicketService
    {
        public IEnumerable<Ticket> GetTickets()
        {
            return new List<Ticket>
            {
                new Ticket(1, "Koncert Metallica", "2025-06-15", 350.00m),
                new Ticket(2, "Mecz Polska - Niemcy", "2025-09-10", 120.50m),
                new Ticket(3, "Teatr: Hamlet", "2025-11-05", 80.00m),
                new Ticket(4, "Kino: Diuna 3", "2025-07-20", 35.00m)
            };
        }
    }
}