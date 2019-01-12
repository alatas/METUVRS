using METU.VRS.Models.Interface;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace METU.VRS.Models
{
    public class Visitor : ILastModified
    {
        public int ID { get; set; }

        public string UID { get; set; }

        [Required]
        [Display(Name = "Visitor Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid email address, please refer (https://en.wikipedia.org/wiki/Email_address#Examples)")]
        [Display(Name = "Visitor Email")]
        [MaxLength(100)]
        public string Email { get; set; }

        public VisitorStatus Status { get; set; }

        [Display(Name = "Visiting Purpose")]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Visit Date")]
        [DataType(DataType.DateTime)]
        public DateTime VisitDate { get; set; } = DateTime.Today;

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ApproveDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EntryDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }

        public virtual Vehicle Vehicle { get; set; } = new Vehicle();
        public virtual User User { get; set; }
    }

    public enum VisitorStatus
    {
        [Description("Not Set")] NotSet = 0,
        [Description("Waiting For Approval")] WaitingForApproval = 10,
        [Description("Waiting For Arrival")] WaitingForArrival = 20,
        [Description("Arrived")] Arrived = 30,
        [Description("Not Arrived")] NotArrived = 40,
        [Description("Expired")] Expired = 50,
        [Description("Rejected")] Rejected = 60,
    }
}