using Xunit;
using DevOps_projekt_zaliczeniowy; // To musi pasowaæ do namespace w Program.cs
using System.Linq;

namespace DevOps_projekt_zaliczeniowy.Tests
{
    public class TicketServiceTests
    {
        [Fact]
        public void GetTickets_ShouldReturnFourTickets()
        {
            var service = new TicketService();
            var result = service.GetTickets();
            Assert.Equal(4, result.Count());
        }

        [Fact]
        public void GetTickets_ShouldContainMetallicaConcert()
        {
            var service = new TicketService();
            var result = service.GetTickets();
            var ticket = result.FirstOrDefault(t => t.Name.Contains("Metallica"));
            Assert.NotNull(ticket);
        }
    }
}