using SuperCom.Domain;

namespace SuperCom.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Tickets.Any()) return;
            
            var activities = new List<Ticket>
            {
                new Ticket
                {
                    Name = "Ticket -2",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Ticket (-)2 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket -1",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Ticket (-)1 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Ticket 1 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Ticket 2 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Ticket 3 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Ticket 4 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Ticket 5 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Ticket 6 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 7",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Ticket 7 months in future",
                    Category = "House Arrest",
                    City = "Tel Aviv",
                    Location = "Israel",
                },
                new Ticket
                {
                    Name = "Ticket 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Ticket 8 months in future",
                    Category = "Prison",
                    City = "Tel Aviv",
                    Location = "Israel",
                }
            };

            await context.Tickets.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}