using WebApplication2.Helpers;

namespace WebApplication2.Models
{
    public class AlertResult
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public AlertStatusId AlertStatus { get; set; }

        public AlertResult(AlertStatusId alertStatus, string title, string desription)
        {
            Title = title;
            Description = desription;
            AlertStatus = alertStatus;
        }
        public AlertResult(AlertStatusId alertStatus, string desription)
        {
            Description = desription;
            AlertStatus = alertStatus;
        }
    }
}