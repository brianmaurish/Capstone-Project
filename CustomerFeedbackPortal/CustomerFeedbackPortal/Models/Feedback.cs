using System.ComponentModel.DataAnnotations;

namespace CustomerFeedbackPortal.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email {  get; set; }

        [Range(1,5)]
        public int Rating { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime SubmittedOn { get; set; } = DateTime.Now;

    }
}
