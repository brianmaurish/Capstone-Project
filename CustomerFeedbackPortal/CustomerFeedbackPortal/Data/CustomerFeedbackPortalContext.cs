namespace CustomerFeedbackPortal.Data
{
    using CustomerFeedbackPortal.Models;
    using Microsoft.EntityFrameworkCore;

    public class CustomerFeedbackPortalContext : DbContext
    {
        public CustomerFeedbackPortalContext(DbContextOptions<CustomerFeedbackPortalContext> options)
            : base(options) { }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
