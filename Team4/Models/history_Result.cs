//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team4.Models
{
    using System;
    
    public partial class history_Result
    {
        public int Customer_ID { get; set; }
        public string Ticket_ID { get; set; }
        public int NoOfTickets { get; set; }
        public string Bus_ID { get; set; }
        public string Bus_Name { get; set; }
        public string Type { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Cost { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.DateTime DateOfJourney { get; set; }
        public Nullable<int> TotalCost { get; set; }
    }
}
